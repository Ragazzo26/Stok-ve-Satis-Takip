using MySql.Data.MySqlClient;
using NYPproje.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYPproje.DAL
{
    internal class CustomerDAO
    {
        internal List<Customer> GetMusteriler()
        {
            List<Customer> list = new List<Customer>();
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID=26_132330123;Password=İnif123.;");
            baglanti.Open();

            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM Musteri",
                baglanti
            );

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Customer c = new Customer();
                c.MusteriId = dr.GetInt32("musteriId");
                c.MusteriAdi = dr.GetString("musteriAdi");
                c.MusteriType = (MusteriType)Enum.Parse(typeof(MusteriType), dr.GetString("musteriType"), true);
 
                 list.Add(c);
            }

            baglanti.Close();
            return list;
        }


        internal void musteriKaydet(string ad, string items)
        {

            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID= 26_132330123; Password=İnif123.;");
            baglanti.Open();
            new MySqlCommand("insert into Musteri(musteriAdi, musteriType) value ('" + ad + "', '" + items + "')", baglanti).ExecuteNonQuery();
            baglanti.Close();
        }

        internal void musteriSil(int mustId)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID= 26_132330123; Password=İnif123.;");
            baglanti.Open();
            new MySqlCommand("delete from Musteri where musteriId=" + mustId + "", baglanti).ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
