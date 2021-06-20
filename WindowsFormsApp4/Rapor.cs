using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp4
{
    class Rapor
    {
        //private string _tarihBaslangic;
        //private string _tarihBitis;

        //public Rapor(string tarihBaslangic, string tarihBitis)
        //{
        //    _tarihBaslangic = tarihBaslangic;
        //    _tarihBitis = tarihBitis;
        //}
        public void PDFCiktisiAl(DataGridView dgvIslemKaydi)
        {
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(STF_Helvetica_Turkish, 7, iTextSharp.text.Font.NORMAL);
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            
            if (save.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdfTable = new PdfPTable(dgvIslemKaydi.ColumnCount);
                // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.
                pdfTable.DefaultCell.Padding = 3; // hücre duvarı ve veri arasında mesafe
                pdfTable.WidthPercentage = 80; // hücre genişliği
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; // yazı hizalaması
                pdfTable.DefaultCell.BorderWidth = 1; // kenarlık kalınlığı  // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.
                foreach (DataGridViewColumn column in dgvIslemKaydi.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontTitle));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240); // hücre arka plan rengi
                    pdfTable.AddCell(cell);
                }
                try
                {
                    foreach (DataGridViewRow row in dgvIslemKaydi.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value == null)
                            {
                                // your cell value is null, do something in null value case
                            }
                            else
                            {
                                pdfTable.AddCell(new PdfPCell(new Phrase(cell.Value.ToString(), fontTitle)));
                            }
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);// sayfa boyutu.
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    pdfDoc.Close();
                }
            }
        }
   
        public void ExcelCiktisiAl(DataGridView dgvIslemKaydi)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dgvIslemKaydi.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                myRange.Value2 = dgvIslemKaydi.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgvIslemKaydi.Columns.Count; i++)
            {
                for (int j = 0; j < dgvIslemKaydi.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                    myRange.Value2 = dgvIslemKaydi[i, j].Value;
                }
            }
            MessageBox.Show("EXCEL türünde rapor alma başarılı.");
        }

        public void CSVCiktisiAl(DataGridView dgvIslemKaydi)
        {
            // Eğer veri yoksa bir şey yapma
            if (dgvIslemKaydi.Rows.Count == 0)
            {
                return;
            }
            StringBuilder sb = new StringBuilder();
            // Sütün başlıkları
            string columnsHeader = "";
            for (int i = 0; i < dgvIslemKaydi.Columns.Count; i++)
            {
                columnsHeader += dgvIslemKaydi.Columns[i].Name + ",";
            }
            
            sb.Append(columnsHeader + Environment.NewLine);
            // Her cell'in üzerinden geç
            foreach (DataGridViewRow dgvRow in dgvIslemKaydi.Rows)
            {
                // satırın boş olup olmadığını kontrol et
                if (!dgvRow.IsNewRow)
                {
                    for (int c = 0; c < dgvRow.Cells.Count; c++)
                    {
                        sb.Append(dgvRow.Cells[c].Value.ToString().Trim() + ",");
                    }
                    // yeni bir boş satır ekle
                    
                    sb.Append(Environment.NewLine);
                }
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                {

                    // stringbuilder'i dosyaya yaz
                    sw.WriteLine(sb.ToString());
                }
            }
            // Rapor işlemi başarılı
            MessageBox.Show("CSV türünde rapor alma başarılı.");
        }

        public void DATCiktisiAl(DataGridView dgvIslemKaydi)
        {
            // Eğer veri yoksa bir şey yapma
            if (dgvIslemKaydi.Rows.Count == 0)
            {
                return;
            }
            StringBuilder sb = new StringBuilder();
            // Sütün başlıkları
            string columnsHeader = "";
            for (int i = 0; i < dgvIslemKaydi.Columns.Count; i++)
            {
                columnsHeader += dgvIslemKaydi.Columns[i].Name + ",";
            }

            sb.Append(columnsHeader + Environment.NewLine);
            // Her cell'in üzerinden geç
            foreach (DataGridViewRow dgvRow in dgvIslemKaydi.Rows)
            {
                // satırın boş olup olmadığını kontrol et
                if (!dgvRow.IsNewRow)
                {
                    for (int c = 0; c < dgvRow.Cells.Count; c++)
                    {
                        sb.Append(dgvRow.Cells[c].Value.ToString().Trim() + ",");
                    }

                    sb.Append(Environment.NewLine);
                }
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "DAT files (*.dat)|*.dat";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                {

                    sw.WriteLine(sb.ToString());
                }
            }
            // DAT türünde rapor alma başarılı olduğunda
            MessageBox.Show("DAT türünde rapor alma başarılı.");
        }

    }
}
