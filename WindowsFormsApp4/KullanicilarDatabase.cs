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

        public DataSet BakiyeleriOnaylanmamisKullanicilar()
        {
            ConnectionControl();
            string sorgu = "SELECT* FROM kullanicilar where bakiyeOnay = 1";
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
                "Insert into kullanicilar values(@kullaniciAdi,@AdSoyad,@sifre,@TcNo,@telefon,@email,@adres,@kullaniciTuru, @kullaniciBakiye, @bakiyeOnay,@beklemedeBakiye)", _connection);

            command.Parameters.AddWithValue("@kullaniciAdi", kullaniciObjesi.kulAdi);
            command.Parameters.AddWithValue("@AdSoyad", kullaniciObjesi.adSoyad);
            command.Parameters.AddWithValue("@sifre", kullaniciObjesi.sifre);
            command.Parameters.AddWithValue("@TcNo", kullaniciObjesi.Tc);
            command.Parameters.AddWithValue("@telefon", kullaniciObjesi.telefonNo);
            command.Parameters.AddWithValue("@email", kullaniciObjesi.eMail);
            command.Parameters.AddWithValue("@adres", kullaniciObjesi.Adres);
            command.Parameters.AddWithValue("@kullaniciTuru", kullaniciObjesi.KullaniciTuru);
            command.Parameters.AddWithValue("@kullaniciBakiye", kullaniciObjesi.mevcutBakiye);
            command.Parameters.AddWithValue("@bakiyeOnay", kullaniciObjesi.bakiyeOnay);
            command.Parameters.AddWithValue("@beklemedeBakiye", kullaniciObjesi.beklemedeBakiye);
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

        public void BakiyeEkle(string kulAdi, int bakiyeMiktari) // Admin
        {
            _connection.Open();


            string komutString = String.Format("UPDATE kullanicilar SET kullaniciBakiye = (kullaniciBakiye + @bakiyeMiktari), bakiyeOnay = 0, beklemedeBakiye = 0 WHERE  kullaniciAdi = @kulAdimiz");

            SqlCommand komut = new SqlCommand(komutString, _connection);
            komut.Parameters.AddWithValue("@bakiyeMiktari", bakiyeMiktari);
            komut.Parameters.AddWithValue("@kulAdimiz", kulAdi);


            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();

            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            _connection.Close();
        }



        public void BeklemeyeBakiyeYolla(string kulAdi, int bakiyeMiktari)
        {
            _connection.Open();


            string komutString = String.Format("UPDATE kullanicilar SET beklemedeBakiye = (beklemedeBakiye+ @bekleyenBakiyeMiktari), bakiyeOnay = 1 WHERE kullaniciAdi = @kulAdimiz");

            SqlCommand komut = new SqlCommand(komutString, _connection);
            komut.Parameters.AddWithValue("@bekleyenBakiyeMiktari", bakiyeMiktari);
            komut.Parameters.AddWithValue("@kulAdimiz", kulAdi);


            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();

            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            _connection.Close();
        }

        public DataRow kullaniciDegerleri(string kulAdi)
        {
            SqlDataAdapter komut = new SqlDataAdapter(String.Format("select * from kullanicilar where kullaniciAdi = '{0}' ", kulAdi), _connection);
            DataTable dt = new System.Data.DataTable();
            komut.Fill(dt);

            return dt.Rows[0];
        }

        public void KullaniciBakiyeDegistir(string isim, int yeniBakiye)
        {
            _connection.Open();


            string komutString = String.Format("UPDATE kullanicilar SET kullaniciBakiye = @yeniBakiye WHERE kullaniciAdi = @kulAdimiz");

            SqlCommand komut = new SqlCommand(komutString, _connection);
            komut.Parameters.AddWithValue("@yeniBakiye", yeniBakiye);
            komut.Parameters.AddWithValue("@kulAdimiz", isim);


            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();

            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            _connection.Close();

        }

    }
}
