using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class ItemlerDatabase
    {
        static VeritabaniSinifi connect = new VeritabaniSinifi();
        public static SqlConnection _connection = new SqlConnection(connect.BaglantiAdresi);

        public DataSet ItemleriCekByItemOnay(int itemOnay)
        {
            ConnectionControl();
            string sorgu = "SELECT ID=IslemID,[Ürün Adı]=ItemAdi,[Ürün Fiyat]=ItemFiyat,[Ürün Miktar]=ItemMiktar,Satıcı=ItemSatici,Tarih=ItemIslemTarih,[İşlem Türü]=IslemTur,Onay=ItemOnay FROM ItemIslemKaydi WHERE ItemOnay = '" + itemOnay + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public DataSet ItemComboboxFill(int itemOnay)
        {
            ConnectionControl();
            string sorgu = "SELECT DISTINCT ItemAdi FROM ItemIslemKaydi WHERE ItemOnay = '" + itemOnay + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public DataSet ItemleriCekByItemAdi(string itemAdi, string kulAdi,string islemTur)
        {
            ConnectionControl();          
            string sorgu = String.Format("SELECT [Ürün Adı]=ItemAdi,[Ürün Fiyatı]=ItemFiyat,[Ürün Miktarı]=ItemMiktar,Satıcı=ItemSatici,ID=IslemID FROM ItemIslemKaydi where ItemAdi ='" + itemAdi + "' AND IslemTur ='" + islemTur + "' AND ItemSatici != '" + kulAdi + "' AND ItemMiktar != 0 ORDER BY ItemFiyat ASC", itemAdi, kulAdi);
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public void ItemlerUrunMiktariGuncelle(string isim, int urunMiktari, int islemID)
        {
            _connection.Open();
            string komutString = String.Format("UPDATE ItemIslemKaydi SET ItemMiktar =@ItemMiktari WHERE IslemID = @IslemID");
            SqlCommand komut = new SqlCommand(komutString, _connection);
            komut.Parameters.AddWithValue("@ItemMiktari", urunMiktari);
            komut.Parameters.AddWithValue("@ItemSahibi", isim);
            komut.Parameters.AddWithValue("@IslemID", islemID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            _connection.Close();
        }

        public void islemKaydiEkle(string itemAdi, double urunFiyati, int urunMiktari, string saticiAdi,string aliciAdi , string islemTarihi,string islemTuru,int itemOnay)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into ItemIslemKaydi values(@ItemAdi,@ItemFiyat,@ItemMiktar,@ItemSatici,@ItemAlici,@ItemIslemTarih,@IslemTur,@ItemOnay)", _connection);
            command.Parameters.AddWithValue("@ItemAdi", itemAdi);
            command.Parameters.AddWithValue("@ItemFiyat", urunFiyati);
            command.Parameters.AddWithValue("@ItemMiktar", urunMiktari);
            command.Parameters.AddWithValue("@ItemSatici", saticiAdi);
            command.Parameters.AddWithValue("@ItemAlici", aliciAdi);
            command.Parameters.AddWithValue("@ItemIslemTarih", islemTarihi);
            command.Parameters.AddWithValue("@IslemTur", islemTuru);
            command.Parameters.AddWithValue("@ItemOnay", itemOnay);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public DataSet ItemKaydiCek(string itemAdi,string baslangic,string bitis)
        {
            ConnectionControl();
            //string sorgu = String.Format("SELECT* FROM itemler WHERE ItemAdi = '{0}'  AND itemSahibi != '{1}' ORDERBY ItemFiyat ASC", itemAdi, kulAdi); 
            string sorgu = "select[Ürün Adı] = ItemAdi, Fiyat = ItemFiyat, Miktar = ItemMiktar, Satıcı = ItemSatici, Alıcı = ItemAlici, Tarih = ItemIslemTarih,[İşlem Tür] = IslemTur From ItemIslemKaydi where ItemAdi='" + itemAdi + "' and ItemIslemTarih between '"+ baslangic + "' and '"+ bitis + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;        
        }
        public void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
    }
}
