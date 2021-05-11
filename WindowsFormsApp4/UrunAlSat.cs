using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class UrunAlSat : Form
    {
        string isim;
        static VeritabaniSinifi connect = new VeritabaniSinifi();
        public static SqlConnection _connection = new SqlConnection(connect.BaglantiAdresi);
        KullanicilarDatabase baglanti = new KullanicilarDatabase();
        public UrunAlSat(string _user)
        {
            InitializeComponent();
            isim = _user;
        }
        KullanicilarDatabase data = new KullanicilarDatabase();
        void UrunEkle(Item urunObjesi)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
            "Insert into itemler values(@ItemAdi,@ItemMiktari,@ItemFiyat,@itemSahibi)", _connection);
            command.Parameters.AddWithValue("@ItemAdi", urunObjesi.itemAdi);
            command.Parameters.AddWithValue("@ItemMiktari", urunObjesi.itemMiktari);
            command.Parameters.AddWithValue("@ItemFiyat", urunObjesi.itemFiyat);
            command.Parameters.AddWithValue("@itemSahibi", urunObjesi.itemSahibi); 
            command.ExecuteNonQuery();

            _connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionControl();
           
            UrunEkle(new Item()
            {
                itemAdi = comboBox1.Text,
                itemFiyat = int.Parse(textBox1.Text),
                itemMiktari = int.Parse(textBox2.Text),
                 itemSahibi = "cihan"

            }) ;
            MessageBox.Show("Başarıyla ürün eklendi.");
            MessageBox.Show(isim);
            _connection.Close();
        }
        public void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        private void UrunAlSat_Load(object sender, EventArgs e)
        {
            string x;
            LoginForm isimAl = new LoginForm();
        }
    }
}
