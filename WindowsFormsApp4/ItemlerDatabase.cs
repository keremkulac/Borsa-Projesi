using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class ItemlerDatabase
    {
        static VeritabaniSinifi connect = new VeritabaniSinifi();
        public static SqlConnection _connection = new SqlConnection(connect.BaglantiAdresi);


        public DataSet ItemleriCekByItemOnay()
        {
            ConnectionControl();
            string sorgu = "SELECT* FROM itemler WHERE itemOnay = 1";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public DataSet ItemleriCekByItemAdi(string itemAdi)
        {
            ConnectionControl();
            string sorgu = string.Format("SELECT * FROM itemler WHERE itemAdi = {0}", itemAdi);
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
    }

 
}
