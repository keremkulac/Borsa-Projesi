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
using System.Xml;
using System.Globalization;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace WindowsFormsApp4
{
    public partial class UrunAlSat : Form
    {
        string paraBirimi;
        string isim; // giriş yapan kullanıcının adı
        static VeritabaniSinifi connect = new VeritabaniSinifi();
        public static SqlConnection _connection = new SqlConnection(connect.BaglantiAdresi);
        KullanicilarDatabase baglanti = new KullanicilarDatabase();
        ItemlerDatabase itemlerData = new ItemlerDatabase();
        public string dovizGlobal; //global bakiye değeri



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
            "Insert into Itemler values(@ItemAdi,@ItemMiktari,@ItemFiyat,@ItemSahibi,@ItemOnay)", _connection);
            command.Parameters.AddWithValue("@ItemAdi", urunObjesi.ItemAdi);
            command.Parameters.AddWithValue("@ItemMiktari", urunObjesi.ItemMiktari);
            command.Parameters.AddWithValue("@ItemFiyat", urunObjesi.ItemFiyat);
            command.Parameters.AddWithValue("@ItemSahibi", urunObjesi.ItemSahibi);
            command.Parameters.AddWithValue("@ItemOnay", urunObjesi.ItemOnay);
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
            lblBakiye.Text = dt["KullaniciBakiye"].ToString();
            OnaylanmisUrunleriComboboxaDoldur();
        }

        public void OnaylanmisUrunleriComboboxaDoldur()
        {
            DataSet ds = itemlerData.ItemComboboxFill(0); // item onay  0 olanları çekicek
            cmbUrunSecimi.DataSource = ds.Tables[0];
            cmbUrunSecimi.DisplayMember = "ItemAdi";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        void LoadItemler(string itemAdi, string islemTur)
        {
            DataSet ds = itemlerData.ItemleriCekByItemAdi(itemAdi, isim, islemTur);
            dgvUrunler.DataSource = ds.Tables[0];
        }
        // >> beklemedeOlanBakiye & bakiyeOnay 

        private void btnUrunSat_Click(object sender, EventArgs e)
        {
            //ConnectionControl();
            //UrunEkle(new Item()
            //{
            //    ItemAdi = txtUrunAd.Text,
            //    ItemFiyat = int.Parse(txtUrunSatFiyat.Text),
            //    ItemMiktari = int.Parse(txtUrunSatMiktar.Text),
            //    ItemSahibi = isim,
            //    ItemOnay = 1
            //});
            //MessageBox.Show("Ürün admin onayına gönderildi. Admin onayından sonra borsa pazarında ürününüzü görüntüleyebileceksiniz.");
            //_connection.Close();
            string ItemAdi = txtUrunAd.Text;
            double ItemFiyat = Convert.ToDouble(txtUrunSatFiyat.Text);
            int ItemMiktar = int.Parse(txtUrunSatMiktar.Text);
            string ItemSahibi = isim;
            int ItemOnay = 1;
            string islemTuru = "Satış";
            string islemTarihi = DateTime.UtcNow.ToString("dd-MM-yyyy");
            string alici = "";
            itemlerData.islemKaydiEkle(ItemAdi, ItemFiyat, ItemMiktar, ItemSahibi, alici, islemTarihi, islemTuru, ItemOnay);
            MessageBox.Show("Ürün admin onayına gönderildi. Admin onayından sonra borsa pazarında ürününüzü görüntüleyebileceksiniz.");
        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadItemler(cmbUrunSecimi.Text, "Satış");
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        private void btnUrunAl_Click(object sender, EventArgs e)
        {
            DataSet muhasebeciVerileri = data.MuhasebeciVerileriniCek();
            string muhasebeciKullaniciAdi = muhasebeciVerileri.Tables[0].Rows[0]["KullaniciAdi"].ToString();
            double muhasebeciBakiyeMiktari = Convert.ToDouble(muhasebeciVerileri.Tables[0].Rows[0]["KullaniciBakiye"].ToString());

            int alinanMiktar = int.Parse(txtUrunAlMiktar.Text); // datagrid 1 
            DataRow dt = data.kullaniciDegerleri(isim);

            double bizimBakiyemiz = Convert.ToDouble(dt["KullaniciBakiye"].ToString());
            string seciliUrun = cmbUrunSecimi.Text; // datagrid 0 
            double bakiyedenDusulecekFiyat;
            int datagridSayac = dgvUrunler.RowCount - 1; // - 1 deme sebebimiz en üstteki kullanıcı adı ile başlayan satırı da alıyor. o satırı almaması gerekiyor.
            List<object> urunler = new List<object>();

            foreach (DataGridViewRow Datarow in dgvUrunler.Rows) // ürün miktarlarını ve fiyatlarını, sahiplerini bir diziye aktardık
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null)
                {
                    var obj = new
                    {
                        urunAdi = Datarow.Cells[0].Value.ToString(),
                        urunFiyati = Convert.ToDouble(Datarow.Cells[1].Value.ToString()),
                        urunMiktari = Convert.ToInt32(Datarow.Cells[2].Value.ToString()),
                        satici = Datarow.Cells[3].Value.ToString(),
                        islemID = Convert.ToInt32(Datarow.Cells[4].Value.ToString())
                    };
                    urunler.Add(obj);
                }
            }

            if (string.IsNullOrWhiteSpace(txtUrunAlFiyat.Text))
            {
                if (alinanMiktar <= 0 || string.IsNullOrWhiteSpace(cmbUrunSecimi.Text))
                {
                    MessageBox.Show("Lütfen miktar için pozitif bir değer giriniz ve satın alacağınız ürünü seçiniz");
                }
                else
                {
                    foreach (object item in urunler)
                    {
                        int islemID = (int)item.GetType().GetProperty("islemID").GetValue(item);
                        string satici = (string)item.GetType().GetProperty("satici").GetValue(item);
                        double urunFiyati = (double)item.GetType().GetProperty("urunFiyati").GetValue(item);
                        int urunMiktari = (int)item.GetType().GetProperty("urunMiktari").GetValue(item);
                        string itemAdi = (string)item.GetType().GetProperty("urunAdi").GetValue(item);
                        DataRow dtSatici = data.kullaniciDegerleri(satici);
                        double kacUrunAlabilirim = bizimBakiyemiz / urunFiyati;
                        bakiyedenDusulecekFiyat = alinanMiktar * urunFiyati;
                        double saticiBakiyesi = Convert.ToDouble(dtSatici["KullaniciBakiye"].ToString());
                        // komisyonlu fiyat hesapla
                        double komisyonluFiyat = bakiyedenDusulecekFiyat * 1 / 100;

                        if (bizimBakiyemiz > bakiyedenDusulecekFiyat)
                        {
                            if (alinanMiktar <= urunMiktari)
                            {
                                // ürün 100 lira, 1 lira muhasebeciye, 101 lira alıcıdan tahsil edilecek, satıcıya 100 lira gidecek

                                saticiBakiyesi = saticiBakiyesi + bakiyedenDusulecekFiyat;
                                saticiBakiyesi = Math.Round(saticiBakiyesi, 2);
                                bizimBakiyemiz = bizimBakiyemiz - bakiyedenDusulecekFiyat - komisyonluFiyat;
                                bizimBakiyemiz = Math.Round(bizimBakiyemiz, 2);
                                MessageBox.Show(String.Format("{0} adlı satıcıdan {1} kg {2} satın alındı", satici.Trim(), alinanMiktar, seciliUrun.Trim()), "Satın alım işlemi");
                                baglanti.KullaniciBakiyeDegistir(isim, bizimBakiyemiz);
                                baglanti.KullaniciBakiyeDegistir(satici, saticiBakiyesi);
                                double muhasebeciYeniBakiyeMiktari = muhasebeciBakiyeMiktari + komisyonluFiyat;
                                baglanti.KullaniciBakiyeDegistir(muhasebeciKullaniciAdi, muhasebeciYeniBakiyeMiktari);
                                MessageBox.Show("Ürünün fiyatına %1'lik değer eklenip alıcıdan tahsil edilmiştir. Tahsil edilen değer muhasebecinin bakiyesine eklenmiştir.");
                                int saticiYeniUrunMiktari = urunMiktari - alinanMiktar;
                                itemlerData.ItemlerUrunMiktariGuncelle(satici, saticiYeniUrunMiktari, islemID);
                                LoadItemler(cmbUrunSecimi.Text, "Satış");
                                string islemTarihi = DateTime.UtcNow.ToString("dd-MM-yyyy");
                                string islemTuru = "Alış";
                                int itemOnay = 0;
                                itemlerData.islemKaydiEkle(itemAdi, urunFiyati, alinanMiktar, satici, isim, islemTarihi, islemTuru, itemOnay);
                                alinanMiktar = alinanMiktar - urunMiktari;
                                // string itemAdi, int urunFiyati, int urunMiktari, string aliciAdi, string saticiAdi,string alimTarihi,string islemTuru
                                // alicinin odeyecegi tutara %1 ekleyip bunu alicidan kes ve muhasebeciye ekle
                                break;
                            }
                            else if (alinanMiktar > urunMiktari)
                            {
                                alinanMiktar = alinanMiktar - urunMiktari;
                                MessageBox.Show(String.Format("{0} adlı satıcıdan {1} kg {2} satın alındı", satici.Trim(), alinanMiktar, seciliUrun.Trim()), "Satın alım işlemi");
                                saticiBakiyesi = saticiBakiyesi + bakiyedenDusulecekFiyat;
                                saticiBakiyesi = Math.Round(saticiBakiyesi, 2);
                                bizimBakiyemiz = bizimBakiyemiz - bakiyedenDusulecekFiyat - komisyonluFiyat;

                                double muhasebeciYeniBakiyeMiktari = muhasebeciBakiyeMiktari + komisyonluFiyat;
                                baglanti.KullaniciBakiyeDegistir(muhasebeciKullaniciAdi, muhasebeciYeniBakiyeMiktari);
                                MessageBox.Show("Ürünün fiyatına %1'lik değer eklenip alıcıdan tahsil edilmiştir. Tahsil edilen değer muhasebecinin bakiyesine eklenmiştir.");

                                bizimBakiyemiz = Math.Round(bizimBakiyemiz, 2);
                                baglanti.KullaniciBakiyeDegistir(isim, bizimBakiyemiz);
                                baglanti.KullaniciBakiyeDegistir(satici, saticiBakiyesi);
                                // O ürünün tamamı satın alındı
                                urunMiktari = 0;
                                itemlerData.ItemlerUrunMiktariGuncelle(satici, urunMiktari, islemID);
                                LoadItemler(cmbUrunSecimi.Text, "Satış");
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
                double istenilenFiyat;
                object bulunanItem;
                istenilenFiyat = Convert.ToDouble(txtUrunAlFiyat.Text);
                bulunanItem = urunler.Find(urun => (double)urun.GetType().GetProperty("urunFiyati").GetValue(urun) == istenilenFiyat);
                foreach (object item in urunler)
                {
                    string satici;
                    int urunMiktari;
                    double urunFiyati;
                    int islemID;
                    if (bulunanItem == null)
                    {
                        SatinAlimEmriVer(isim, seciliUrun, alinanMiktar, istenilenFiyat);
                        MessageBox.Show("item bulunamadi");
                        break;

                    }
                    else
                    {
                        string itemAdi = (string)item.GetType().GetProperty("urunAdi").GetValue(item);
                        islemID = (int)bulunanItem.GetType().GetProperty("islemID").GetValue(bulunanItem);
                        satici = (string)bulunanItem.GetType().GetProperty("satici").GetValue(bulunanItem);
                        urunFiyati = (double)bulunanItem.GetType().GetProperty("urunFiyati").GetValue(bulunanItem);
                        urunMiktari = (int)bulunanItem.GetType().GetProperty("urunMiktari").GetValue(bulunanItem);
                        DataRow dtSatici = data.kullaniciDegerleri(satici);
                        double kacUrunAlabilirim = bizimBakiyemiz / urunFiyati;
                        bakiyedenDusulecekFiyat = alinanMiktar * urunFiyati;
                        double saticiBakiyesi = Convert.ToDouble(dtSatici["KullaniciBakiye"].ToString());
                        double komisyonluFiyat = bakiyedenDusulecekFiyat * 1 / 100;

                        if (bizimBakiyemiz > bakiyedenDusulecekFiyat)
                        {
                            if (alinanMiktar <= urunMiktari)
                            {
                                saticiBakiyesi = saticiBakiyesi + bakiyedenDusulecekFiyat;
                                saticiBakiyesi = Math.Round(saticiBakiyesi, 2);
                                bizimBakiyemiz = bizimBakiyemiz - bakiyedenDusulecekFiyat - komisyonluFiyat;

                                double muhasebeciYeniBakiyeMiktari = muhasebeciBakiyeMiktari + komisyonluFiyat;
                                baglanti.KullaniciBakiyeDegistir(muhasebeciKullaniciAdi, muhasebeciYeniBakiyeMiktari);
                                MessageBox.Show("Ürünün fiyatına %1'lik değer eklenip alıcıdan tahsil edilmiştir. Tahsil edilen değer muhasebecinin bakiyesine eklenmiştir.");

                                bizimBakiyemiz = Math.Round(bizimBakiyemiz, 2);
                                MessageBox.Show(String.Format("{0} adlı satıcıdan {1} kg {2} satın alındı", satici.Trim(), alinanMiktar, seciliUrun.Trim()), "Satın alım işlemi");
                                baglanti.KullaniciBakiyeDegistir(isim, bizimBakiyemiz);
                                baglanti.KullaniciBakiyeDegistir(satici, saticiBakiyesi);
                                int saticiYeniUrunMiktari = urunMiktari - alinanMiktar;
                                itemlerData.ItemlerUrunMiktariGuncelle(satici, saticiYeniUrunMiktari, islemID);
                                LoadItemler(cmbUrunSecimi.Text, "Satış");
                                string islemTarihi = DateTime.UtcNow.ToString("dd-MM-yyyy");
                                string islemTuru = "Alış";
                                int itemOnay = 0;
                                itemlerData.islemKaydiEkle(itemAdi, urunFiyati, alinanMiktar, satici, isim, islemTarihi, islemTuru, itemOnay);
                                alinanMiktar = alinanMiktar - urunMiktari;
                                break;
                            }
                            else if (alinanMiktar > urunMiktari)
                            {
                                alinanMiktar = alinanMiktar - urunMiktari;
                                MessageBox.Show(String.Format("{0} adlı satıcıdan {1} kg {2} satın alındı", satici.Trim(), alinanMiktar, seciliUrun.Trim()), "Satın alım işlemi");
                                saticiBakiyesi = saticiBakiyesi + bakiyedenDusulecekFiyat;
                                saticiBakiyesi = Math.Round(saticiBakiyesi, 2);
                                bizimBakiyemiz = bizimBakiyemiz - bakiyedenDusulecekFiyat - komisyonluFiyat;
                                double muhasebeciYeniBakiyeMiktari = muhasebeciBakiyeMiktari + komisyonluFiyat;
                                baglanti.KullaniciBakiyeDegistir(muhasebeciKullaniciAdi, muhasebeciYeniBakiyeMiktari);
                                MessageBox.Show("Ürünün fiyatına %1'lik değer eklenip alıcıdan tahsil edilmiştir. Tahsil edilen değer muhasebecinin bakiyesine eklenmiştir.");

                                bizimBakiyemiz = Math.Round(bizimBakiyemiz, 2);
                                baglanti.KullaniciBakiyeDegistir(isim, bizimBakiyemiz);
                                baglanti.KullaniciBakiyeDegistir(satici, saticiBakiyesi);
                                // O ürünün tamamı satın alındı
                                urunMiktari = 0;
                                itemlerData.ItemlerUrunMiktariGuncelle(satici, urunMiktari, islemID);
                                LoadItemler(cmbUrunSecimi.Text, "Satış");
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
        }

        public void SatinAlimEmriVer(string kulAdi, string itemAdi, int miktar, double fiyat)
        {
            SatinAlmaEmri satisEmriObjesi = new SatinAlmaEmri();
            SatinAlmaEmriDatabase SatinAlmaDatabase = new SatinAlmaEmriDatabase();
            satisEmriObjesi.emirSahibi = kulAdi;
            satisEmriObjesi.alinacakItem = itemAdi;
            satisEmriObjesi.miktar = miktar;
            satisEmriObjesi.fiyat = fiyat;
            SatinAlmaDatabase.VeritabaninaEmirVer(satisEmriObjesi);



        }



        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        public void bakiyeEkle()
        {
            paraBirimi = cmbParaBirimi.Text;
            double bakiyeTLDegeri = Convert.ToDouble(txtBakiyeMiktar.Text);

            bakiyeTLDegeri = Math.Round(bakiyeTLDegeri, 2);
            DataRow dt = data.kullaniciDegerleri(isim);
            baglanti.BeklemeyeBakiyeYolla(isim, bakiyeTLDegeri, paraBirimi);

            double bakiye = Convert.ToDouble(dt["KullaniciBakiye"].ToString());
            lblBakiye.Text = bakiye.ToString();
            Console.WriteLine(bakiyeTLDegeri);


        }

        private void btnBakiyeYukle_Click(object sender, EventArgs e)
        {

            bakiyeEkle();
            MessageBox.Show("Bakiye yükleme istediğiniz işleme alınmıştır. Admin tarafından onaylandıktan sonra bakiyeniz güncellenecektir.");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            //select* from ItemIslemKaydi where ItemAdi = 'Erik' and ItemIslemTarih between '17-06-2021' and '19-06-2021'
            raporTarihBaslangic.Format = DateTimePickerFormat.Custom;
            raporTarihBaslangic.CustomFormat = "dd-MM-yyyy";
            raporTarihBitis.Format = DateTimePickerFormat.Custom;
            raporTarihBitis.CustomFormat = "dd-MM-yyyy";
            string raporBaslangic = raporTarihBaslangic.Text;
            string raporBitis = raporTarihBitis.Text;
            string itemAd = txtItemAd.Text;
            DataSet ds = itemlerData.ItemKaydiCek(itemAd, raporBaslangic, raporBitis, isim, isim);
            dgvIslemKaydi.DataSource = ds.Tables[0];
        }

        private void btnRaporAl_Click_1(object sender, EventArgs e)
        {
            raporTarihBaslangic.Format = DateTimePickerFormat.Custom;
            raporTarihBaslangic.CustomFormat = "dd-MM-yyyy";
            raporTarihBitis.Format = DateTimePickerFormat.Custom;
            raporTarihBitis.CustomFormat = "dd-MM-yyyy";
            string raporBaslangic = raporTarihBaslangic.Text;
            string raporBitis = raporTarihBitis.Text;
            string itemAd = txtItemAd.Text;
            DataSet ds = itemlerData.ItemKaydiCek(itemAd, raporBaslangic, raporBitis, isim, isim);
            dgvIslemKaydi.DataSource = ds.Tables[0];
            //string urunAdi = dgvIslemKaydi.Rows[dgvIslemKaydi.CurrentRow.Index].Cells[0].Value.ToString();
            //int urunFiyat = Convert.ToInt32(dgvIslemKaydi.Rows[dgvIslemKaydi.CurrentRow.Index].Cells[1].Value.ToString());
            //int urunMiktar = Convert.ToInt32(dgvIslemKaydi.Rows[dgvIslemKaydi.CurrentRow.Index].Cells[2].Value.ToString());
            //string saticiAdi = dgvIslemKaydi.Rows[dgvIslemKaydi.CurrentRow.Index].Cells[3].Value.ToString();
            //string aliciAdi = dgvIslemKaydi.Rows[dgvIslemKaydi.CurrentRow.Index].Cells[4].Value.ToString();
            //string tarih = dgvIslemKaydi.Rows[dgvIslemKaydi.CurrentRow.Index].Cells[5].Value.ToString();
            //string islemTur = dgvIslemKaydi.Rows[dgvIslemKaydi.CurrentRow.Index].Cells[6].Value.ToString();

            Rapor rapor = new Rapor();
            switch (cmbRaporTuru.Text)
            {
                case "CSV":
                    rapor.CSVCiktisiAl(dgvIslemKaydi);
                    break;
                case "XLSX":
                    rapor.ExcelCiktisiAl(dgvIslemKaydi);
                    break;
                case "DAT":
                    rapor.DATCiktisiAl(dgvIslemKaydi);
                    break;
                case "PDF":
                    rapor.PDFCiktisiAl(dgvIslemKaydi);
                    break;
            }
        }

        private void cmbParaBirimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            paraBirimi = cmbParaBirimi.Text;
        }
    }
}



