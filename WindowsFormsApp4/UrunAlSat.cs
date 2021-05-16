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



        string isim; // giriş yapan kullanıcının adı

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
                itemAdi = textBox4.Text,
                itemFiyat = int.Parse(textBox1.Text),
                itemMiktari = int.Parse(textBox2.Text),
                itemSahibi = isim,
                itemOnay = 1
            });
            MessageBox.Show("Ürün admin onayına gönderildi. Admin onayından sonra borsa pazarında ürününüzü görüntüleyebileceksiniz.");
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
            MessageBox.Show("isim " + isim);
            DataRow dt = data.kullaniciDegerleri(isim);
            label7.Text = dt["kullaniciBakiye"].ToString();
            label10.Text = dt["beklemedeBakiye"].ToString();
            OnaylanmisUrunleriComboboxaDoldur();


        }


        public void OnaylanmisUrunleriComboboxaDoldur()
        {

            DataSet ds = itemlerData.ItemComboboxFill(0); // item onay  0 olanları çekicek
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "ItemAdi";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        void LoadItemler(string itemAdi)
        {
            DataSet ds = itemlerData.ItemleriCekByItemAdi(itemAdi, isim);
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

        private void satinAlBtn_Click(object sender, EventArgs e)
        {

            int miktarKg = int.Parse(textBox3.Text); // datagrid 1 

            if (miktarKg <= 0 || string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Lütfen miktar için pozitif bir değer giriniz ve satın alacağınız ürünü seçiniz");
            }
            else
            {

                DataRow dt = data.kullaniciDegerleri(isim);

                int bizimBakiyemiz = Convert.ToInt32(dt["kullaniciBakiye"].ToString());


                string seciliUrun = comboBox2.Text; // datagrid 0 
                int bakiyedenDusulecekFiyat;
                int datagridSayac = urunlerDGV.RowCount - 1; // - 1 deme sebebimiz en üstteki kullanıcı adı ile başlayan satırı da alıyor. o satırı almaması gerekiyor.
                List<object> urunler = new List<object>();

                foreach (DataGridViewRow Datarow in urunlerDGV.Rows) // ürün miktarlarını ve fiyatlarını, sahiplerini bir diziye aktardık
                {
                    if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null)
                    {
                        var obj = new
                        {
                            urunMiktari = Convert.ToInt32(Datarow.Cells[1].Value.ToString()),
                            urunFiyati = Convert.ToInt32(Datarow.Cells[2].Value.ToString()),
                            satici = Datarow.Cells[3].Value.ToString(),
                            itemId = Convert.ToInt32(Datarow.Cells[5].Value.ToString())
                        };

                        urunler.Add(obj);
                    }

                }

                foreach (object item in urunler)
                {
                    string satici = (string)item.GetType().GetProperty("satici").GetValue(item);
                    int urunMiktari = (int)item.GetType().GetProperty("urunMiktari").GetValue(item);
                    int urunFiyati = (int)item.GetType().GetProperty("urunFiyati").GetValue(item);
                    int itemId = (int)item.GetType().GetProperty("itemId").GetValue(item);

                    Console.WriteLine(item.GetType().GetProperty("satici").GetValue(item));

                    DataRow dtSatici = data.kullaniciDegerleri(satici);
                    int kacUrunAlabilirim = bizimBakiyemiz / urunFiyati;
                    bakiyedenDusulecekFiyat = miktarKg * urunFiyati;


                    int saticiBakiyesi = Convert.ToInt32(dtSatici["kullaniciBakiye"].ToString());
                    //MessageBox.Show(String.Format("saticiBakiyesi: {0}, bizimBakiyemiz: {1}", saticiBakiyesi, bizimBakiyemiz));

                    if (bizimBakiyemiz > bakiyedenDusulecekFiyat)
                    {

                        if (miktarKg <= urunMiktari)
                        {


                            saticiBakiyesi = saticiBakiyesi + bakiyedenDusulecekFiyat;
                            bizimBakiyemiz = bizimBakiyemiz - bakiyedenDusulecekFiyat;

                            MessageBox.Show(satici + " kullanıcısından " + miktarKg + "kg" + seciliUrun + "satın alındı!");
                            baglanti.KullaniciBakiyeDegistir(isim, bizimBakiyemiz);
                            baglanti.KullaniciBakiyeDegistir(satici, saticiBakiyesi);
                            int saticiYeniUrunMiktari = urunMiktari - miktarKg;
                            itemlerData.ItemlerUrunMiktariGuncelle(satici, saticiYeniUrunMiktari, itemId);
                            LoadItemler(comboBox2.Text);
                            miktarKg = miktarKg - urunMiktari;
                            break;
                        }
                        else if (miktarKg > urunMiktari)
                        {

                            miktarKg = miktarKg - urunMiktari;
                            MessageBox.Show(satici + " kullanıcısından " + urunMiktari + "kg" + seciliUrun + "satın alındı!");
                            saticiBakiyesi = saticiBakiyesi + bakiyedenDusulecekFiyat;
                            bizimBakiyemiz = bizimBakiyemiz - bakiyedenDusulecekFiyat;
                            baglanti.KullaniciBakiyeDegistir(isim, bizimBakiyemiz);
                            baglanti.KullaniciBakiyeDegistir(satici, saticiBakiyesi);
                            // O ürünün tamamı satın alındı
                            urunMiktari = 0;
                            itemlerData.ItemlerUrunMiktariGuncelle(satici, urunMiktari, itemId);
                            LoadItemler(comboBox2.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bakiyeniz yetersiz");
                        break;
                    }

                }

                label7.Text = bizimBakiyemiz.ToString();
            }

            //Console.WriteLine(urunler);
        }
    }
}
