using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class UyeOl : Form
    {
        static VeritabaniSinifi connect = new VeritabaniSinifi();
        public static SqlConnection _connection = new SqlConnection(connect.BaglantiAdresi);

        public UyeOl()
        {
            InitializeComponent();
        }

        KullanicilarDatabase data = new KullanicilarDatabase();

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm girisEkrani = new LoginForm();
            girisEkrani.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblKayitOl_Click(object sender, EventArgs e)
        {
            data.KullaniciEkle(new Kullanici()
            {
                KulAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text,
                AdSoyad = txtAdSoyad.Text,
                Email = txtEmail.Text,
                Tc = Convert.ToInt64(txtTcNo.Text),
                TelefonNo = Convert.ToInt64(txtTelNo.Text),
                Adres = txtAdres.Text,
                KullaniciTuru = cmbKullaniciTuru.Text,
                MevcutBakiye = 0,
                BakiyeOnay = 0,
                BeklemedeBakiye = 0,
                BakiyeParaBirimi = "TRY"
            });

            MessageBox.Show("Sayın " + txtKullaniciAdi.Text + " Başarıyla üye oldunuz!");
            MessageBox.Show("Giriş ekranına yönlendiriliyorsunuz...");
            this.Hide();
            LoginForm girisEkrani = new LoginForm();
            girisEkrani.Show();
        }

        private void btnGeri_MouseHover(object sender, EventArgs e)
        {
            this.Opacity = 5;
        }

        private void btnGeri_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                this.Opacity = 0.5;
            }
        }
    }
}
