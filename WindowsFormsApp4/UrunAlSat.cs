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

        public void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        private void UrunAlSat_Load(object sender, EventArgs e)
        {
            LoginForm isimAl = new LoginForm();
            DataRow dt = data.kullaniciDegerleri(isim);
            label7.Text = dt["kullaniciBakiye"].ToString();
            label10.Text = dt["beklemedeBakiye"].ToString();
            OnaylanmisUrunleriComboboxaDoldur();
        }


        public void OnaylanmisUrunleriComboboxaDoldur()
        {
            DataSet ds = itemlerData.ItemComboboxFill(0); // item onay  0 olanları çekicek
            guna2ComboBox1.DataSource = ds.Tables[0];
            guna2ComboBox1.DisplayMember = "ItemAdi";
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
        // >> beklemedeOlanBakiye & bakiyeOnay 


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ConnectionControl();

            UrunEkle(new Item()
            {
                itemAdi = guna2TextBox1.Text,
                itemFiyat = int.Parse(guna2TextBox2.Text),
                itemMiktari = int.Parse(guna2TextBox3.Text),
                itemSahibi = isim,
                itemOnay = 1
            });
            MessageBox.Show("Ürün admin onayına gönderildi. Admin onayından sonra borsa pazarında ürününüzü görüntüleyebileceksiniz.");
            _connection.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadItemler(guna2ComboBox1.Text);
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int miktarKg = int.Parse(guna2TextBox4.Text); // datagrid 1 

            DataRow dt = data.kullaniciDegerleri(isim);

            int bizimBakiyemiz = Convert.ToInt32(dt["kullaniciBakiye"].ToString());


            string seciliUrun = guna2ComboBox1.Text; // datagrid 0 
            int bakiyedenDusulecekFiyat;
            int datagridSayac = urunlerDGV.RowCount - 1; // - 1 deme sebebimiz en üstteki kullanıcı adı ile başlayan satırı da alıyor. o satırı almaması gerekiyor.
            List<object> urunler = new List<object>();

            foreach (DataGridViewRow Datarow in urunlerDGV.Rows) // ürün miktarlarını ve fiyatlarını, sahiplerini bir diziye aktardık
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null)
                {
                    var obj = new
                    {
                        urunAdi = Datarow.Cells[0].Value.ToString(),
                        urunMiktari = Convert.ToInt32(Datarow.Cells[1].Value.ToString()),
                        urunFiyati = Convert.ToInt32(Datarow.Cells[2].Value.ToString()),
                        satici = Datarow.Cells[3].Value.ToString(),
                        itemId = Convert.ToInt32(Datarow.Cells[5].Value.ToString())
                    };

                    urunler.Add(obj);
                }

            }

            if (string.IsNullOrWhiteSpace(fiyatTextBox.Text))
            {
                if (miktarKg <= 0 || string.IsNullOrWhiteSpace(guna2ComboBox1.Text))
                {
                    MessageBox.Show("Lütfen miktar için pozitif bir değer giriniz ve satın alacağınız ürünü seçiniz");
                }
                else
                {

                    foreach (object item in urunler)
                    {
                        int itemId = (int)item.GetType().GetProperty("itemId").GetValue(item);
                        string satici = (string)item.GetType().GetProperty("satici").GetValue(item);
                        int urunFiyati = (int)item.GetType().GetProperty("urunFiyati").GetValue(item);
                        int urunMiktari = (int)item.GetType().GetProperty("urunMiktari").GetValue(item);
                        string itemAdi = (string)item.GetType().GetProperty("urunAdi").GetValue(item);

                        DataRow dtSatici = data.kullaniciDegerleri(satici);
                        int kacUrunAlabilirim = bizimBakiyemiz / urunFiyati;
                        bakiyedenDusulecekFiyat = miktarKg * urunFiyati;

                        int saticiBakiyesi = Convert.ToInt32(dtSatici["kullaniciBakiye"].ToString());

                        if (bizimBakiyemiz > bakiyedenDusulecekFiyat)
                        {

                            if (miktarKg <= urunMiktari)
                            {

                                saticiBakiyesi = saticiBakiyesi + bakiyedenDusulecekFiyat;
                                bizimBakiyemiz = bizimBakiyemiz - bakiyedenDusulecekFiyat;

                                MessageBox.Show(String.Format("satici {0} kullanıcısından {1} kg {2} satın alındı", satici, miktarKg, seciliUrun), "Satın alım işlemi");
                                baglanti.KullaniciBakiyeDegistir(isim, bizimBakiyemiz);
                                baglanti.KullaniciBakiyeDegistir(satici, saticiBakiyesi);
                                int saticiYeniUrunMiktari = urunMiktari - miktarKg;
                                itemlerData.ItemlerUrunMiktariGuncelle(satici, saticiYeniUrunMiktari, itemId);
                                LoadItemler(guna2ComboBox1.Text);
                                miktarKg = miktarKg - urunMiktari;

                                string alimTarihi = DateTime.UtcNow.ToString("dd-MM-yyyy");

                                itemlerData.ItemKaydiEkle(itemAdi, itemId, satici, urunFiyati, urunMiktari, alimTarihi, isim);
                                // alicinin odeyecegi tutara %1 ekleyip bunu alicidan kes ve muhasebeciye ekle
                                break;
                            }
                            else if (miktarKg > urunMiktari)
                            {

                                miktarKg = miktarKg - urunMiktari;

                                MessageBox.Show(String.Format("satici {0} kullanıcısından {1} kg {2} satın alındı", satici, miktarKg, seciliUrun), "Satın alım işlemi");
                                saticiBakiyesi = saticiBakiyesi + bakiyedenDusulecekFiyat;
                                bizimBakiyemiz = bizimBakiyemiz - bakiyedenDusulecekFiyat;
                                baglanti.KullaniciBakiyeDegistir(isim, bizimBakiyemiz);
                                baglanti.KullaniciBakiyeDegistir(satici, saticiBakiyesi);
                                // O ürünün tamamı satın alındı
                                urunMiktari = 0;
                                itemlerData.ItemlerUrunMiktariGuncelle(satici, urunMiktari, itemId);
                                LoadItemler(guna2ComboBox1.Text);
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
            }
            else
            {

                int istenilenFiyat;
                object bulunanItem;

                istenilenFiyat = int.Parse(fiyatTextBox.Text);
                bulunanItem = urunler.Find(urun => (int)urun.GetType().GetProperty("urunFiyati").GetValue(urun) == istenilenFiyat);


                foreach (object item in urunler)
                {
                    string satici;
                    int urunMiktari;
                    int urunFiyati;
                    int itemId;

                    if (bulunanItem == null)
                    {
                        // veritabanina kaydet ve admin her item onayi verdiginde kontrol et
                        MessageBox.Show("item bulunamadi");
                        
                    }
                    else
                    {
                        itemId = (int)bulunanItem.GetType().GetProperty("itemId").GetValue(bulunanItem);
                        satici = (string)bulunanItem.GetType().GetProperty("satici").GetValue(bulunanItem);
                        urunFiyati = (int)bulunanItem.GetType().GetProperty("urunFiyati").GetValue(bulunanItem);
                        urunMiktari = (int)bulunanItem.GetType().GetProperty("urunMiktari").GetValue(bulunanItem);



                        DataRow dtSatici = data.kullaniciDegerleri(satici);
                        int kacUrunAlabilirim = bizimBakiyemiz / urunFiyati;
                        bakiyedenDusulecekFiyat = miktarKg * urunFiyati;

                        int saticiBakiyesi = Convert.ToInt32(dtSatici["kullaniciBakiye"].ToString());

                        if (bizimBakiyemiz > bakiyedenDusulecekFiyat)
                        {

                            if (miktarKg <= urunMiktari)
                            {


                                saticiBakiyesi = saticiBakiyesi + bakiyedenDusulecekFiyat;
                                bizimBakiyemiz = bizimBakiyemiz - bakiyedenDusulecekFiyat;

                                MessageBox.Show(String.Format("satici {0} kullanıcısından {1} kg {2} satın alındı", satici, miktarKg, seciliUrun), "Satın alım işlemi");
                                baglanti.KullaniciBakiyeDegistir(isim, bizimBakiyemiz);
                                baglanti.KullaniciBakiyeDegistir(satici, saticiBakiyesi);
                                int saticiYeniUrunMiktari = urunMiktari - miktarKg;
                                itemlerData.ItemlerUrunMiktariGuncelle(satici, saticiYeniUrunMiktari, itemId);
                                LoadItemler(guna2ComboBox1.Text);
                                miktarKg = miktarKg - urunMiktari;

                                break;
                            }
                            else if (miktarKg > urunMiktari)
                            {

                                miktarKg = miktarKg - urunMiktari;

                                MessageBox.Show(String.Format("satici {0} kullanıcısından {1} kg {2} satın alındı", satici, miktarKg, seciliUrun), "Satın alım işlemi");
                                saticiBakiyesi = saticiBakiyesi + bakiyedenDusulecekFiyat;
                                bizimBakiyemiz = bizimBakiyemiz - bakiyedenDusulecekFiyat;
                                baglanti.KullaniciBakiyeDegistir(isim, bizimBakiyemiz);
                                baglanti.KullaniciBakiyeDegistir(satici, saticiBakiyesi);
                                // O ürünün tamamı satın alındı
                                urunMiktari = 0;
                                itemlerData.ItemlerUrunMiktariGuncelle(satici, urunMiktari, itemId);
                                LoadItemler(guna2ComboBox1.Text);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bakiyeniz yetersiz");
                            break;
                        }
                    }


                }

                label7.Text = bizimBakiyemiz.ToString();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int bakiyeEkle = Convert.ToInt32(Math.Round(guna2NumericUpDown1.Value, 0));

            DataRow dt = data.kullaniciDegerleri(isim);

            baglanti.BeklemeyeBakiyeYolla(isim, bakiyeEkle);
            int oncekiBakiye = int.Parse(dt["beklemedeBakiye"].ToString()) + bakiyeEkle;
            label10.Text = oncekiBakiye.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnCiktiAl_Click(object sender, EventArgs e)
        {

            string raporBaslangic = raporTarihBaslangic.Text;
            string raporBitis = raporTarihBitis.Text;
            Rapor rapor = new Rapor(raporBaslangic, raporBitis);

            string raporTuru = comboRaporTuru.Text;
            switch (raporTuru)
            {
                case "XSLX":
                    rapor.ExcelCiktisiAl();
                    break;
                case "CSV":
                    rapor.CSVCiktisiAl();
                    break;
                case "PDF":
                    rapor.PDFCiktisiAl();
                    break;
                case "DAT":
                    rapor.DATCiktisiAl();
                    break;

            }
           

        }
    }
}
