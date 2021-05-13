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
        ItemlerDatabase itemlerData = new ItemlerDatabase();

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
            "Insert into itemler values(@ItemAdi,@ItemMiktari,@ItemFiyat,@itemSahibi,@itemOnay)", _connection);
            command.Parameters.AddWithValue("@ItemAdi", urunObjesi.itemAdi);
            command.Parameters.AddWithValue("@ItemMiktari", urunObjesi.itemMiktari);
            command.Parameters.AddWithValue("@ItemFiyat", urunObjesi.itemFiyat);
            command.Parameters.AddWithValue("@itemSahibi", urunObjesi.itemSahibi);
            command.Parameters.AddWithValue("@itemOnay", urunObjesi.itemOnay);
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
                itemSahibi = isim,
                itemOnay = 1
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
            MessageBox.Show("isim "+isim);
            DataRow dt = data.kullaniciDegerleri(isim);
            label7.Text = dt["kullaniciBakiye"].ToString();
            label10.Text = dt["beklemedeBakiye"].ToString();


        }

     
      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        void LoadItemler(string itemAdi)
        {
            DataSet ds = itemlerData.ItemleriCekByItemAdi(itemAdi);
            urunlerDGV.DataSource = ds.Tables[0];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            Console.WriteLine(comboBox2.Text);
            LoadItemler(comboBox2.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        // >> beklemedeOlanBakiye & bakiyeOnay 
        private void button3_Click(object sender, EventArgs e)
        {
        int bakiyeEkle = Convert.ToInt32(Math.Round(bakiyeMiktar.Value, 0));
   
          DataRow dt = data.kullaniciDegerleri(isim);

            baglanti.BeklemeyeBakiyeYolla(isim, bakiyeEkle);
            int oncekiBakiye = int.Parse(dt["beklemedeBakiye"].ToString()) + bakiyeEkle;
            label10.Text = oncekiBakiye.ToString();
        
          
        }
    }
}
