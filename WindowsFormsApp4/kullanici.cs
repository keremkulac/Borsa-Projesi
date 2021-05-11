using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class kullanici
    {
  

         public string kulAdi { get; set; }
         public string adSoyad { get; set; }
         public string sifre { get; set; }
         public int Tc { get; set; }
         public int telefonNo { get; set; }
         public string eMail { get; set; }
         public string Adres { get; set; }
         public string KullaniciTuru { get; set; }

        public kullanici()
        {
            kulAdi = "Atanmadi";
            adSoyad = "Atanmadi";
        }



    }
}
