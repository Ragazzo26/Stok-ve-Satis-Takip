using MySql.Data.MySqlClient;
using NYPproje.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPproje.DAL
{
    internal class SalesDAO
    {
        
        internal void satisEkle(Sales s)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID= 26_132330123; Password=İnif123.;");
            baglanti.Open();
            new MySqlCommand("insert into Sale (mId, pId, miktar, fiyat, toplam, indirim , saleDate) values ("+s.Mid+", "+s.Pid+ ", "+s.Miktar+", "+s.Fiyat+", "+s.Toplam+", "+s.Indirim+" , '"+s.SaleDate.ToString("yyyy-MM-dd HH:mm:ss") +"')", baglanti).ExecuteNonQuery();
            baglanti.Close();
        }
        
    }
}
