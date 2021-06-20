using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApp4
{
    class DovizKuru
    {
        public string DovizKuruStr(string paraBirimi)
        {
            System.Windows.Forms.MessageBox.Show("Test:"+paraBirimi);

            string bugun = " http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            string dovizKur = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='" + paraBirimi + "']/BanknoteSelling").InnerXml;
            return dovizKur;
        }
    }
}
