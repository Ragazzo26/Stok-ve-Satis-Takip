using MySql.Data.MySqlClient;
using NYPproje.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPproje.DAL
{
    internal class ReportDAO
    {
        public Sales aylikSatis (Sales s)
        {
            Sales rapor = new Sales();
           
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID= 26_132330123; Password=İnif123.;");
            baglanti.Open();
            string sql = "SELECT " +
                     "IFNULL(SUM(miktar),0) AS ToplamSatis, " +
                     "IFNULL(SUM(toplam + indirim),0) AS Ciro, " +
                     "IFNULL(SUM(indirim),0) AS Indirim " +
                     "FROM Sale " +
                     "WHERE MONTH(saleDate) = " + s.SaleDate.Month +
                     " AND YEAR(saleDate) = " + s.SaleDate.Year;
            MySqlCommand cmd = new MySqlCommand(sql, baglanti);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                rapor.Miktar = reader["ToplamSatis"] != DBNull.Value? Convert.ToInt32(reader["ToplamSatis"]):0;

                rapor.Toplam = reader["Ciro"] != DBNull.Value? Convert.ToDouble(reader["Ciro"]):0;

                rapor.Indirim = reader["Indirim"] != DBNull.Value ? Convert.ToDouble(reader["Indirim"]) : 0;
            }
            baglanti.Close();
            return rapor;
        }
        internal List<Sales> encokSatilan(DateTime tarih)
        {
            List<Sales> liste = new List<Sales>();

            MySqlConnection baglanti =
                new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID=26_132330123;Password=İnif123.;");

            baglanti.Open();

            string sql =
                "SELECT s.pId, SUM(s.miktar) AS ToplamMiktar " +
                "FROM Sale s " +
                "JOIN Product p ON s.pId = p.urunId " +
                "WHERE MONTH(s.saleDate) = " + tarih.Month + " " +
                "AND YEAR(s.saleDate) = " + tarih.Year + " " +
                "GROUP BY s.pId " +
                "ORDER BY ToplamMiktar DESC";


            MySqlCommand cmd = new MySqlCommand(sql, baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Sales s = new Sales();
                s.Pid = Convert.ToInt32(reader["pId"]);
                s.Miktar = Convert.ToInt32(reader["ToplamMiktar"]);

                liste.Add(s);
            }

            baglanti.Close();
            return liste;
        }

        internal List<Sales> cokMusteri(DateTime tarih)
        {
            List<Sales> liste = new List<Sales>();

            MySqlConnection baglanti =
                new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID=26_132330123;Password=İnif123.;");

            baglanti.Open();

            string sql =
                "SELECT s.mId, c.musteriAdi, c.musteriType, " +
                "COUNT(*) AS ToplamSale, " +
                "SUM(s.miktar) AS ToplamMiktar, " +
                "SUM(s.toplam) AS Ciro " +
                "FROM Sale s " +
                "JOIN Musteri c ON s.mId = c.musteriId " +
                "WHERE MONTH(s.saleDate) = " + tarih.Month + " " +
                "AND YEAR(s.saleDate) = " + tarih.Year + " " +
                "GROUP BY s.mId, c.musteriAdi, c.musteriType " +
                "ORDER BY Ciro DESC";

            MySqlCommand cmd = new MySqlCommand(sql, baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Sales s = new Sales();
                Customer c = new Customer();
                s.Mid = Convert.ToInt32(reader["mId"]);
                c.MusteriAdi = reader["musteriAdi"].ToString();
                string typeStr = reader["musteriType"].ToString();
                MusteriType type;

                if (typeStr.Equals("Toptan", StringComparison.OrdinalIgnoreCase))
                {
                    type = MusteriType.Toptan;
                }
                else
                {
                    type = MusteriType.Perakende;
                }

                c.MusteriType = type;
                s.Miktar = Convert.ToInt32(reader["ToplamMiktar"]);      
                s.Toplam = Convert.ToDouble(reader["Ciro"]);              
                s.SaleSayisi = Convert.ToInt32(reader["ToplamSale"]);

                s.Customer = c;
                
                liste.Add(s);
            }

            baglanti.Close();
            return liste;
        }

        
        internal Sales karZarar(DateTime tarih)
        {
            Sales rapor = new Sales();

            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID=26_132330123;Password=İnif123.;");
            baglanti.Open();

            string sql =
                "SELECT SUM(s.toplam) AS Ciro, SUM(p.urunMaliyet * s.miktar) AS Maliyet " +
                "FROM Sale s " +
                "JOIN Product p ON s.pId = p.urunId " +
                "WHERE MONTH(s.saleDate) = " + tarih.Month +
                " AND YEAR(s.saleDate) = " + tarih.Year;

            MySqlCommand cmd = new MySqlCommand(sql, baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                rapor.Toplam = reader["Ciro"] != DBNull.Value ? Convert.ToDouble(reader["Ciro"]) : 0;
                rapor.Maliyet = reader["Maliyet"] != DBNull.Value ? Convert.ToDouble(reader["Maliyet"]) : 0;
                rapor.KarZarar = rapor.Toplam - rapor.Maliyet;
            }

            baglanti.Close();
            return rapor;
        }

        internal List<Product> minimumStok()
        {
            List<Product> liste = new List<Product>();

            MySqlConnection baglanti = new MySqlConnection(
                "Server=172.21.54.253;Database=26_132330123;User ID=26_132330123;Password=İnif123.;");
            baglanti.Open();

            string sql = "SELECT urunAdi, urunAdet AS MevcutStock, minStok " +
                         "FROM Product " +
                         "WHERE urunAdet < minStok";

            MySqlCommand cmd = new MySqlCommand(sql, baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Product p = new Product();
                p.UrunAdi = reader["urunAdi"].ToString();
                p.UrunAdet = Convert.ToInt32(reader["MevcutStock"]);
                p.MinStock = Convert.ToInt32(reader["minStok"]);

                liste.Add(p);
            }

            baglanti.Close();
            return liste;
        }

    }
}
