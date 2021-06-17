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
            string sorgu = "SELECT* FROM Itemler WHERE ItemOnay = '" + itemOnay + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public DataSet ItemComboboxFill(int itemOnay)
        {
            ConnectionControl();
            string sorgu = "SELECT DISTINCT ItemAdi FROM Itemler WHERE ItemOnay = '" + itemOnay + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public DataSet ItemleriCekByItemAdi(string itemAdi, string kulAdi)
        {
            ConnectionControl();
            //string sorgu = String.Format("SELECT* FROM itemler WHERE ItemAdi = '{0}'  AND itemSahibi != '{1}' ORDERBY ItemFiyat ASC", itemAdi, kulAdi); 
            string sorgu = String.Format("SELECT* FROM Itemler where ItemAdi ='" + itemAdi + "' AND ItemSahibi != '" + kulAdi + "' AND ItemMiktari != 0 ORDER BY ItemFiyat ASC", itemAdi, kulAdi);
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public void ItemlerUrunMiktariGuncelle(string isim, int urunMiktari, int itemId)
        {
            _connection.Open();
            string komutString = String.Format("UPDATE Itemler SET ItemMiktari = @ItemMiktari WHERE ItemID = @ItemID");
            SqlCommand komut = new SqlCommand(komutString, _connection);
            komut.Parameters.AddWithValue("@ItemMiktari", urunMiktari);
            komut.Parameters.AddWithValue("@ItemSahibi", isim);
            komut.Parameters.AddWithValue("@ItemID", itemId);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            _connection.Close();
        }

        public void ItemKaydiEkle(string itemAdi, int itemId, string satici, int urunFiyati, int urunMiktari, string alimTarihi, string alici)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into kayitlar values(@ItemAdi,@itemSahibi,@ItemFiyat,@ItemMiktari,@itemId,@alimTarihi,@itemAlici,@tur)", _connection);
            command.Parameters.AddWithValue("@ItemAdi", itemAdi);
            command.Parameters.AddWithValue("@itemSahibi", satici);
            command.Parameters.AddWithValue("@ItemFiyat", urunFiyati);
            command.Parameters.AddWithValue("@ItemMiktari", urunMiktari);
            command.Parameters.AddWithValue("@itemId", itemId);
            command.Parameters.AddWithValue("@alimTarihi", alimTarihi);
            command.Parameters.AddWithValue("@itemAlici", alici);
            command.Parameters.AddWithValue("@tur", "x");
            command.ExecuteNonQuery();
            _connection.Close();
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
