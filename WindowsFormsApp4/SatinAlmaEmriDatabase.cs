using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class SatinAlmaEmriDatabase
    {

        static VeritabaniSinifi connect = new VeritabaniSinifi();
        public static SqlConnection _connection = new SqlConnection(connect.BaglantiAdresi);
        public void VeritabaninaEmirVer (SatinAlmaEmri AlmaEmri)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into AlimEmirleri values(@EmirSahibi,@AlinacakItem,@Miktar,@Fiyat)", _connection);
            command.Parameters.AddWithValue("@EmirSahibi", AlmaEmri.emirSahibi);
            command.Parameters.AddWithValue("@AlinacakItem", AlmaEmri.alinacakItem);
            command.Parameters.AddWithValue("@Miktar", AlmaEmri.miktar);
            command.Parameters.AddWithValue("@Fiyat", AlmaEmri.fiyat);
            System.Windows.Forms.MessageBox.Show("Sayın "+AlmaEmri.emirSahibi+" Satın alma emrinizi aldık! "+AlmaEmri.fiyat+ " fiyatında "+AlmaEmri.alinacakItem+ " ürünü satışa çıkarsa otomatik alım sağlanacak.");
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public DataSet EmirleriCek(string urunAdi)
        {
            ConnectionControl();
             SqlDataAdapter da = new SqlDataAdapter(String.Format("SELECT [Urun_Adi]=AlinacakItem, [Urun_Fiyat]=Fiyat, [Urun_Miktar]=Miktar FROM AlimEmirleri WHERE AlinacakItem= '{0}' ", urunAdi), _connection);
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
