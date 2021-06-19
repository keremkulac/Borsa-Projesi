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
        public void PDFRaporAl(DataGridView dgvIslemKaydi)
        {
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
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
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
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                using (FileStream stream = new FileStream(save.FileName + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);// sayfa boyutu.
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
        public void PDFCiktisiAl(string urunAdi, int urunFiyat, int urunMiktar, string saticiAdi, string aliciAdi, string tarih, string islemTur)
        {
            DataSet ds = new DataSet();
            ItemlerDatabase kayit = new ItemlerDatabase();
            //  ds = kayit.ItemKaydiCek();

            iTextSharp.text.Document rapor = new iTextSharp.text.Document();
            PdfWriter.GetInstance(rapor, new FileStream("C:Deneme.Pdf", FileMode.Create));
            if (rapor.IsOpen() == false)
            {
                rapor.Open();
            }
            rapor.Add(new Paragraph("Ürün Adı     " + urunAdi));
            rapor.Add(new Paragraph("Ürün Fiyati  " + urunFiyat + "TL"));
            rapor.Add(new Paragraph("Ürün Miktari " + urunMiktar + "kg"));
            rapor.Add(new Paragraph("Satici Adi   " + saticiAdi));
            rapor.Add(new Paragraph("Alici Adi    " + aliciAdi));
            rapor.Add(new Paragraph("Islem Tarihi " + tarih));
            rapor.Add(new Paragraph("Islem Türü   " + islemTur));
            MessageBox.Show("PDF türünde rapor alma başarılı");
            rapor.Close();
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
        }

        public void CSVCiktisiAl()
        {

        }

        public void DATCiktisiAl()
        {

        }

    }
}
