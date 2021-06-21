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
            string sorgu = "SELECT [Kullanıcı Adı]=KullaniciAdi,Şifre=Sifre,[Ad Soyad]=AdSoyad,[TC Kimlik No]=TcNo,Telefon=Telefon,Email=Email,Adres=Adres,Bakiye=KullaniciBakiye FROM Kullanicilar";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public DataSet BakiyeleriOnaylanmamisKullanicilar()
        {
            ConnectionControl();
            string sorgu = "SELECT [Kullanıcı Adı]=KullaniciAdi,[Ad Soyad]=AdSoyad,Bakiye=KullaniciBakiye,[Onaylanacak Bakiye Miktar]=BeklemedeBakiye,[Para Birimi]=BakiyeParaBirimi FROM Kullanicilar where BakiyeOnay = 1";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public DataSet MuhasebeciVerileriniCek()
        {
            ConnectionControl();
            string sorgu = "SELECT [KullaniciAdi]=KullaniciAdi,[KullaniciBakiye]=KullaniciBakiye FROM Kullanicilar WHERE KullaniciTuru ='Muhasebe'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public void KullaniciEkle(Kullanici kullaniciObjesi)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into Kullanicilar values(@KullaniciAdi,@Sifre,@AdSoyad,@TcNo,@Telefon,@Email,@Adres,@KullaniciTuru, @KullaniciBakiye, @BakiyeOnay,@BeklemedeBakiye)", _connection);
            command.Parameters.AddWithValue("@KullaniciAdi", kullaniciObjesi.KulAdi);
            command.Parameters.AddWithValue("@Sifre", kullaniciObjesi.Sifre);
            command.Parameters.AddWithValue("@AdSoyad", kullaniciObjesi.AdSoyad);  
            command.Parameters.AddWithValue("@TcNo", kullaniciObjesi.Tc);
            command.Parameters.AddWithValue("@Telefon", kullaniciObjesi.TelefonNo);
            command.Parameters.AddWithValue("@Email", kullaniciObjesi.Email);
            command.Parameters.AddWithValue("@Adres", kullaniciObjesi.Adres);
            command.Parameters.AddWithValue("@KullaniciTuru", kullaniciObjesi.KullaniciTuru);
            command.Parameters.AddWithValue("@KullaniciBakiye", kullaniciObjesi.MevcutBakiye);
            command.Parameters.AddWithValue("@BakiyeOnay", kullaniciObjesi.BakiyeOnay);
            command.Parameters.AddWithValue("@BeklemedeBakiye", kullaniciObjesi.BeklemedeBakiye);
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

        public void BakiyeEkle(string kulAdi, double bakiyeMiktari) // Admin
        {
            _connection.Open();
            string komutString = String.Format("UPDATE Kullanicilar SET KullaniciBakiye = (KullaniciBakiye + @BakiyeMiktari), BakiyeOnay = 0, BeklemedeBakiye = 0 WHERE  KullaniciAdi = @KulAdimiz");
            SqlCommand komut = new SqlCommand(komutString, _connection);
            komut.Parameters.AddWithValue("@BakiyeMiktari", bakiyeMiktari);
            komut.Parameters.AddWithValue("@KulAdimiz", kulAdi);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            _connection.Close();
        }

        public void BeklemeyeBakiyeYolla(string kulAdi, double bakiyeMiktari, string Bakiye)
        {
            _connection.Open();
            string komutString = String.Format("UPDATE Kullanicilar SET BeklemedeBakiye = (BeklemedeBakiye+ @BekleyenBakiyeMiktari), BakiyeOnay = 1, BakiyeParaBirimi = @BakiyeParaBirimi WHERE KullaniciAdi = @KulAdimiz");
            SqlCommand komut = new SqlCommand(komutString, _connection);
            komut.Parameters.AddWithValue("@BekleyenBakiyeMiktari", bakiyeMiktari);
            komut.Parameters.AddWithValue("@KulAdimiz", kulAdi);
            komut.Parameters.AddWithValue("@BakiyeParaBirimi", Bakiye);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            _connection.Close();
        }


        //public void BakiyeParaBirimi(string Bakiye, string kulAdi)
        //{


        //    _connection.Open();

        //    string komutString = String.Format("UPDATE Kullanicilar SET BakiyeParaBirimi=@ItemOnay WHERE kulAdi = {0}", kulAdi);
        //    SqlCommand komut = new SqlCommand(komutString, _connection);
        //    komut.Parameters.AddWithValue("@BakiyeParaBirimi", Bakiye);

        //    komut.ExecuteNonQuery();
        //    System.Windows.Forms.MessageBox.Show("Başarıyla onaya düştü!");
        //    _connection.Close();
        //}





        public DataRow kullaniciDegerleri(string kulAdi)
        {
            SqlDataAdapter komut = new SqlDataAdapter(String.Format("select * from Kullanicilar where KullaniciAdi = '{0}' ", kulAdi), _connection);
            DataTable dt = new System.Data.DataTable();
            komut.Fill(dt);
            return dt.Rows[0];
        }

        public void KullaniciBakiyeDegistir(string isim, double yeniBakiye)
        {
            _connection.Open();
            string komutString = String.Format("UPDATE Kullanicilar SET KullaniciBakiye = @YeniBakiye WHERE KullaniciAdi = @KulAdimiz");
            SqlCommand komut = new SqlCommand(komutString, _connection);
            komut.Parameters.AddWithValue("@YeniBakiye", yeniBakiye);
            komut.Parameters.AddWithValue("@KulAdimiz", isim);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            _connection.Close();
        }

   



    
    
    
    
    
    }



}
