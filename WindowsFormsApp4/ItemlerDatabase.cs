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
            string sorgu = "SELECT* FROM itemler WHERE itemOnay = '" +itemOnay+"'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public DataSet ItemComboboxFill(int itemOnay)
        {
            ConnectionControl();
            string sorgu = "SELECT DISTINCT ItemAdi FROM itemler WHERE itemOnay = '" + itemOnay + "'";
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
         
            string sorgu = String.Format("SELECT* FROM itemler where ItemAdi ='" + itemAdi + "' AND itemSahibi != '" + kulAdi + "' AND ItemMiktari != 0 ORDER BY ItemFiyat ASC", itemAdi,kulAdi);
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();

            return ds;
        }


        public void ItemlerUrunMiktariGuncelle(string isim, int urunMiktari, int itemId)
        {

            _connection.Open();


            string komutString = String.Format("UPDATE itemler SET ItemMiktari = @ItemMiktari WHERE itemId = @itemId");
            Console.WriteLine(String.Format("satici: {0}, urunMiktari: {1}, itemId: {2}", isim, urunMiktari, itemId));
            SqlCommand komut = new SqlCommand(komutString, _connection);
            komut.Parameters.AddWithValue("@ItemMiktari", urunMiktari);
            komut.Parameters.AddWithValue("@itemSahibi", isim);
            komut.Parameters.AddWithValue("@itemId", itemId);

            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();

            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
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
