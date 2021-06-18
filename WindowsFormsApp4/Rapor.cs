using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class Rapor
    {
        private string _tarihBaslangic;
        private string _tarihBitis;

        public Rapor(string tarihBaslangic, string tarihBitis)
        {
            _tarihBaslangic = tarihBaslangic;
            _tarihBitis = tarihBitis;
        }

        public void KullaniciAlimKayitlariniAl()
        {

        }
        public void PDFCiktisiAl()
        {     
            
        }

        public void ExcelCiktisiAl()
        {

        }

        public void CSVCiktisiAl()
        {

        }

        public void DATCiktisiAl()
        {

        }

    }
}
