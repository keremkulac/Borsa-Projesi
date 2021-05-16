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

    

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            data.KullaniciEkle(new kullanici()
            {
                kulAdi = textBox1.Text,
                sifre = textBox2.Text,
                adSoyad = textBox3.Text,
                eMail = textBox4.Text,
                Tc  = int.Parse(textBox5.Text),
                telefonNo = int.Parse(textBox6.Text),
                Adres = textBox7.Text,
                KullaniciTuru = comboBox1.Text            
                
            });
           

            MessageBox.Show("Sayın " +textBox1.Text+ " Başarıyla üye oldunuz!");
            MessageBox.Show("Giriş ekranına yönlendiriliyorsunuz...");
            this.Hide();
            LoginForm girisEkrani = new LoginForm();
            girisEkrani.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm girisEkrani = new LoginForm();
            girisEkrani.Show();
        }
    }
}
