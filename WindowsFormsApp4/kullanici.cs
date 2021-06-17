using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Kullanici
    {
  

         public string KulAdi { get; set; }
         public string AdSoyad { get; set; }
         public string Sifre { get; set; }
         public long Tc { get; set; }
         public long TelefonNo { get; set; }
         public string Email { get; set; }
         public string Adres { get; set; }
         public string KullaniciTuru { get; set; }
         public int MevcutBakiye { get; set; }
         public int BakiyeOnay { get; set; }
        public int BeklemedeBakiye { get; set; }

        public Kullanici()
        {
            KulAdi = "Atanmadi";
            MevcutBakiye = 0;
            BakiyeOnay = 0;
            AdSoyad = "Atanmadi";
        }



    }
}
