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
        string secilmisItem = null;

        public AdminPaneli()
        {
            InitializeComponent();
        }
        KullanicilarDatabase data = new KullanicilarDatabase();
        ItemlerDatabase itemlerData = new ItemlerDatabase();


        void LoadKullanicilar()
        {
            DataSet ds = data.KullanicilariCek();
            dataGridView1.DataSource = ds.Tables[0];

        }

        void LoadItemler()
        {
            DataSet ds = itemlerData.ItemleriCekByItemOnay();
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {
            LoadKullanicilar();
            LoadItemler();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                secilmisItem = row.Cells[0].Value.ToString();
                //...
            }
        }

        private void onaylaBtn_Click(object sender, EventArgs e)
        {
            _connection.Open();
            string itemId = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].Value.ToString();

            string komutString = String.Format("UPDATE itemler SET itemOnay=@itemOnay WHERE itemId = {0}", Int32.Parse(itemId));

            SqlCommand komut = new SqlCommand(komutString, _connection);
            komut.Parameters.AddWithValue("@itemOnay", 0);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();

            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            _connection.Close();
            MessageBox.Show("Item onay bilgisi Güncellendi.");

            LoadItemler();
         
        }
    }
}
