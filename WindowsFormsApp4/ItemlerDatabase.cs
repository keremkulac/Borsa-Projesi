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


        public DataSet ItemleriCekByItemOnay(int itemOnay) 
        {
            ConnectionControl();
            string sorgu = "SELECT* FROM itemler WHERE itemOnay = '" +itemOnay+"'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public DataSet ItemComboboxFill(int itemOnay)
        {
            ConnectionControl();
            string sorgu = "SELECT DISTINCT ItemAdi FROM itemler WHERE itemOnay = '" + itemOnay + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public DataSet ItemleriCekByItemAdi(string itemAdi, string kulAdi)
        {
            ConnectionControl();
            //string sorgu = String.Format("SELECT* FROM itemler WHERE ItemAdi = '{0}'  AND itemSahibi != '{1}' ORDERBY ItemFiyat ASC", itemAdi, kulAdi); 
         
            string sorgu = String.Format("SELECT* FROM itemler where ItemAdi ='" + itemAdi + "' AND itemSahibi != '" + kulAdi + "'  ORDER BY ItemFiyat ASC", itemAdi,kulAdi);
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
