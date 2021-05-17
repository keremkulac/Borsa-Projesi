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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm girisEkrani = new LoginForm();
            girisEkrani.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      

        private void label11_Click(object sender, EventArgs e)
        {
            data.KullaniciEkle(new kullanici()
            {
                kulAdi = guna2TextBox1.Text,
                sifre = guna2TextBox2.Text,
                adSoyad = guna2TextBox3.Text,
                eMail = guna2TextBox4.Text,
                Tc = int.Parse(guna2TextBox5.Text),
                telefonNo = int.Parse(guna2TextBox6.Text),
                Adres = guna2TextBox7.Text,
                KullaniciTuru = guna2ComboBox1.Text,
                mevcutBakiye = 0,
                bakiyeOnay = 0,
                beklemedeBakiye=0,

            }) ;

            MessageBox.Show("Sayın " + guna2TextBox1.Text + " Başarıyla üye oldunuz!");
            MessageBox.Show("Giriş ekranına yönlendiriliyorsunuz...");
            this.Hide();
            LoginForm girisEkrani = new LoginForm();
            girisEkrani.Show();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            this.Opacity = 5;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {

            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                this.Opacity = 0.5;
            }
        }
    }
}
