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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
