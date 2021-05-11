using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class KullanicilarDatabase
    {

        static VeritabaniSinifi connect = new VeritabaniSinifi();
        public static SqlConnection _connection = new SqlConnection(connect.BaglantiAdresi);

        public DataSet KullanicilariCek()
        {
            ConnectionControl();
            string sorgu = "SELECT* FROM kullanicilar";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }


        public void KullaniciEkle(kullanici kullaniciObjesi)
        {
          
            
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into kullanicilar values(@kullaniciAdi,@AdSoyad,@sifre,@TcNo,@telefon,@email,@adres,@kullaniciTuru)", _connection);

            command.Parameters.AddWithValue("@kullaniciAdi", kullaniciObjesi.kulAdi);
            command.Parameters.AddWithValue("@AdSoyad", kullaniciObjesi.adSoyad);
            command.Parameters.AddWithValue("@sifre", kullaniciObjesi.sifre);
            command.Parameters.AddWithValue("@TcNo", kullaniciObjesi.Tc);
            command.Parameters.AddWithValue("@telefon", kullaniciObjesi.telefonNo);
            command.Parameters.AddWithValue("@email", kullaniciObjesi.eMail);
            command.Parameters.AddWithValue("@adres", kullaniciObjesi.Adres);
            command.Parameters.AddWithValue("@kullaniciTuru", kullaniciObjesi.KullaniciTuru);
         
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
