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
    public partial class LoginForm : Form
    {
        
        static VeritabaniSinifi connect = new VeritabaniSinifi();
        public static SqlConnection _connection = new SqlConnection(connect.BaglantiAdresi);
        public string user;
        public LoginForm()
        {
        
            InitializeComponent();
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            
             user = textBox1.Text;
            string pass = textBox2.Text;
            _connection.Open();
            ///  SqlCommand _sqlCommand = new SqlCommand("Select * From GirisBilgileri", _connection);
            SqlDataAdapter komut = new SqlDataAdapter("select * from kullanicilar where kullaniciAdi = '" + user + "' and sifre='" + pass + "'", _connection);
            DataTable dt = new System.Data.DataTable();
            komut.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                switch (dt.Rows[0]["kullaniciTuru"] as string)
                {
                    case "admin":
                        {
                            MessageBox.Show("Admin girdi");
                           this.Hide();
                            AdminPaneli adminForm = new AdminPaneli();
                            adminForm.Show();     
                            break;
                        }

                    case "Alıcı":
                        {

                            MessageBox.Show("Alıcı girdi");
                           
                            this.Hide();
                            UrunAlSat uas = new UrunAlSat(user);
                            uas.Show();
                            break;
                        }

                    case "Satıcı":
                        {
                            MessageBox.Show("Satıcı girdi");

                            //this.Hide();
                            ////MenuForm mf = new MenuForm();
                            ////mf.Show();
                            break;
                        }

                    default:
                        {
                            // ... handle unexpected roles here...
                            break;
                        }
                }
            }
            else
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");

            _connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeOl form1 = new UyeOl();
            form1.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
