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
    public partial class AdminPaneli : Form
    {

        static VeritabaniSinifi connect = new VeritabaniSinifi();
        public static SqlConnection _connection = new SqlConnection(connect.BaglantiAdresi);


        // string secilmisItem = null;
        public void LoginFormDon()
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        public AdminPaneli()
        {
            InitializeComponent();
        }
        KullanicilarDatabase data = new KullanicilarDatabase();
        ItemlerDatabase itemlerData = new ItemlerDatabase();
        SatinAlmaEmriDatabase emirDt = new SatinAlmaEmriDatabase();

        void LoadKullanicilar()
        {
            DataSet ds = data.KullanicilariCek();
            dgvMevcutUye.DataSource = ds.Tables[0];
        }

        void OnaylanmamisBakiyeKullanicilari()
        {
            DataSet ds = data.BakiyeleriOnaylanmamisKullanicilar();
            dgvBeklemedeBakiye.DataSource = ds.Tables[0];
        }

        void LoadItemler()
        {
            DataSet ds = itemlerData.ItemleriCekByItemOnay(1); // itemOnay 1 olanları çekicek
            dgvUrunOnay.DataSource = ds.Tables[0];
        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {
            LoadKullanicilar();
            LoadItemler();
            OnaylanmamisBakiyeKullanicilari();
            string bugun = DateTime.UtcNow.ToString("dd-MM-yyyy");
            lblTarih.Text = bugun.ToString();
        }

        //private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        //{
        //    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
        //    {
        //        secilmisItem = row.Cells[0].Value.ToString();
        //        //...

        //    }
        //}

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnUrunOnay_Click(object sender, EventArgs e)
        {
            _connection.Open();
            string islemID = dgvUrunOnay.Rows[dgvUrunOnay.CurrentRow.Index].Cells[0].Value.ToString();
            string komutString = String.Format("UPDATE ItemIslemKaydi SET ItemOnay=@ItemOnay WHERE IslemID = {0}", Int32.Parse(islemID));
            SqlCommand komut = new SqlCommand(komutString, _connection);
            komut.Parameters.AddWithValue("@ItemOnay", 0);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            _connection.Close();

            EmirKontrol();



            MessageBox.Show("Ürün satışı onaylandı ve item onay bilgisi Güncellendi.");
            LoadItemler();
        }

        private void btnBeklemedeBakiyeOnay_Click(object sender, EventArgs e)
        {
            _connection.Open();
            string kulAdi = dgvBeklemedeBakiye.Rows[dgvBeklemedeBakiye.CurrentRow.Index].Cells[0].Value.ToString();

            string paraBirimi = dgvBeklemedeBakiye.Rows[dgvBeklemedeBakiye.CurrentRow.Index].Cells[4].Value.ToString();
            string dovizKur;

            if (paraBirimi == "TRY")
            {
                dovizKur = "1";
            }
            else
            {
                DovizKuru dovizObjesi = new DovizKuru();
                dovizKur = dovizObjesi.DovizKuruStr(paraBirimi);
                dovizKur = dovizKur.Replace('.', ',');
            }

            double beklemedekiBakiye = Convert.ToDouble(dovizKur) * Convert.ToDouble(dgvBeklemedeBakiye.Rows[dgvBeklemedeBakiye.CurrentRow.Index].Cells[3].Value.ToString());

            MessageBox.Show(String.Format("Kullanıcının {0} para birimli döviz kuru eklenmiş bakiyesi: {1}", paraBirimi, beklemedekiBakiye));
            data.BakiyeEkle(kulAdi, beklemedekiBakiye);
            OnaylanmamisBakiyeKullanicilari();
            LoadKullanicilar();


            MessageBox.Show("Bakiye onaylandı ve kullanıcının bakiye bilgisi güncellendi.");
            _connection.Close();
        }

        public void EmirKontrol()
        {
            string urunAdi = dgvUrunOnay.Rows[dgvUrunOnay.CurrentRow.Index].Cells[1].Value.ToString();
            double urunFiyat = Convert.ToDouble(dgvUrunOnay.Rows[dgvUrunOnay.CurrentRow.Index].Cells[2].Value.ToString());
            string urunSaticiIsim = dgvUrunOnay.Rows[dgvUrunOnay.CurrentRow.Index].Cells[4].Value.ToString();
            int urunMiktar = Convert.ToInt32(dgvUrunOnay.Rows[dgvUrunOnay.CurrentRow.Index].Cells[3].Value.ToString());

            DataSet muhasebeciVerileri = data.MuhasebeciVerileriniCek();
            string muhasebeciKullaniciAdi = muhasebeciVerileri.Tables[0].Rows[0]["KullaniciAdi"].ToString();
            double muhasebeciBakiyeMiktari = Convert.ToDouble(muhasebeciVerileri.Tables[0].Rows[0]["KullaniciBakiye"].ToString());

            DataSet dt = emirDt.EmirleriCek(urunAdi, urunFiyat);

            if (dt.Tables[0].Rows.Count != 0)
            {
                string satisEmriniVeren = dt.Tables[0].Rows[0]["Alici"].ToString();
                MessageBox.Show("satisEmriniVeren" + satisEmriniVeren);
                string gelenUrunAdi = dt.Tables[0].Rows[0]["Urun_Adi"].ToString();
                double gelenUrunFiyat = Convert.ToDouble(dt.Tables[0].Rows[0]["Urun_Fiyat"].ToString());
                int gelenUrunMiktar = int.Parse(dt.Tables[0].Rows[0]["Urun_Miktar"].ToString());
                int emirID = int.Parse(dt.Tables[0].Rows[0]["Emir_ID"].ToString());
                int islemID = Convert.ToInt32(dgvUrunOnay.Rows[dgvUrunOnay.CurrentRow.Index].Cells[0].Value.ToString());

                MessageBox.Show("Ürün adı:" + gelenUrunAdi + "Ürün fiyat:" + gelenUrunFiyat + "Urun miktar: " + gelenUrunMiktar);
                if (gelenUrunFiyat == urunFiyat) // kullanıcı 3 tlden almak istiyor ve satıcı da 3 tlden satıyorsa
                {

                    DataRow kullaniciAliciData = data.kullaniciDegerleri(satisEmriniVeren); // alış emrini veren kişinin verileri - cihan
                    DataRow kullaniciSaticiData = data.kullaniciDegerleri(urunSaticiIsim); // ürünü satan kişinin verileri- ali

                    double kullaniciAliciBakiye = Convert.ToDouble(kullaniciAliciData["KullaniciBakiye"].ToString());
                    double kullaniciSaticiBakiye = Convert.ToDouble(kullaniciSaticiData["KullaniciBakiye"].ToString());

                    string kullaniciAliciIsim = Convert.ToString(kullaniciAliciData["KullaniciAdi"].ToString());
                    int aliciAlinacakUrunMiktari = Convert.ToInt32(dt.Tables[0].Rows[0]["Urun_Miktar"].ToString());

                    if (gelenUrunMiktar <= urunMiktar) //biz x tane almak istiyosak ve satıcıda x veya daha fazla varsa
                    {
                        double maliyet = gelenUrunMiktar * urunFiyat;
                        double komisyonluFiyat = maliyet * 1 / 100;
                        if (kullaniciAliciBakiye >= maliyet) //bakiye yeterli ise
                        {
                            // Otomatik alım satım işlemini gerçekleştir
                            kullaniciSaticiBakiye = kullaniciSaticiBakiye + maliyet;
                            kullaniciSaticiBakiye = Math.Round(kullaniciSaticiBakiye, 2);
                            kullaniciAliciBakiye = kullaniciAliciBakiye - maliyet - komisyonluFiyat;
                            kullaniciAliciBakiye = Math.Round(kullaniciAliciBakiye, 2);
                            // Muhasebeciye komisyonlu fiyat üzerinden bakiyesine ekleme yap
                            double muhasebeciYeniBakiyeMiktari = muhasebeciBakiyeMiktari + komisyonluFiyat;
                            // Hem alıcının hem de satıcının bakiyelerini güncelle
                            data.KullaniciBakiyeDegistir(kullaniciAliciIsim, kullaniciAliciBakiye);
                            data.KullaniciBakiyeDegistir(urunSaticiIsim, kullaniciSaticiBakiye);
                            data.KullaniciBakiyeDegistir(muhasebeciKullaniciAdi, muhasebeciYeniBakiyeMiktari);
                            MessageBox.Show("Ürünün fiyatına %1'lik değer eklenip alıcıdan tahsil edilmiştir. Tahsil edilen değer muhasebecinin bakiyesine eklenmiştir.");
                            int saticiYeniUrunMiktari = gelenUrunMiktar - aliciAlinacakUrunMiktari;
                            itemlerData.ItemlerUrunMiktariGuncelle(urunSaticiIsim, saticiYeniUrunMiktari, islemID);
                            string islemTarihi = DateTime.UtcNow.ToString("dd-MM-yyyy");
                            string islemTuru = "Alış";
                            int itemOnay = 0;

                            // Emiri sil ve işlem kaydını ekle
                            emirDt.EmiriSil(emirID);
                            itemlerData.islemKaydiEkle(gelenUrunAdi, gelenUrunFiyat, gelenUrunMiktar, urunSaticiIsim, kullaniciAliciIsim, islemTarihi, islemTuru, itemOnay);
                        }

                        else
                        {
                            MessageBox.Show("Satış emri mevcuttu fakat yetersiz bakiyeden dolayı emir gerçekleşmedi.");
                        }

                    }


                }
            }
            else
            {
                MessageBox.Show("Seçili ürü");
            }



        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
