using MySql.Data.MySqlClient;
using NYPproje.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYPproje.DAL
{
    internal class ProductDAO
    {
        internal void kaydet(Product gProduct)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID= 26_132330123; Password=İnif123.;");
            baglanti.Open();
            new MySqlCommand("insert into Product (urunAdi, urunAdet, urunFiyat, urunMaliyet, minStok) value ('" + gProduct.UrunAdi + "', " + gProduct.UrunAdet + ", " + gProduct.UrunFiyat + ", "+gProduct.UrunMaliyet+" , " + gProduct.MinStock + ")", baglanti).ExecuteNonQuery();
            baglanti.Close();
        }

        internal void urunDuzelt(Product gProduct)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID= 26_132330123; Password=İnif123.;");
            baglanti.Open();
            new MySqlCommand("update Product set urunAdi='" + gProduct.UrunAdi + "', urunAdet=" + gProduct.UrunAdet + ", urunFiyat=" + gProduct.UrunFiyat + ", urunMaliyet="+gProduct.UrunMaliyet+" , minStok=" + gProduct.MinStock + " where urunId=" + gProduct.UrunId + "", baglanti).ExecuteNonQuery();
            baglanti.Close();
        }

        internal List<Product> urunGetir()
        {
            MySqlConnection conn = new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID= 26_132330123; Password=İnif123.;");

            List<Product> list = new List<Product>();

            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Product", conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Add(new Product
                {
                    UrunId = Convert.ToInt32(dr["urunId"]),
                    UrunAdi = dr["urunAdi"].ToString(),
                    UrunAdet = Convert.ToInt32(dr["urunAdet"]),
                    UrunFiyat = Convert.ToDouble(dr["urunFiyat"]),
                    UrunMaliyet = Convert.ToDouble(dr["urunMaliyet"]),
                    MinStock = Convert.ToInt32(dr["minStok"]),
                });
            }

            conn.Close();
            return list;

        }

        internal void urunSil(int selectedUrunId)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID= 26_132330123; Password=İnif123.;");
            baglanti.Open();
            new MySqlCommand("delete from Product where urunId=" + selectedUrunId + "", baglanti).ExecuteNonQuery();
            baglanti.Close();
        }

        internal void adetKaydet(int selectedUrunId, int adet)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID= 26_132330123; Password=İnif123.;");
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("Update Product set urunAdet = urunAdet + " + adet + " where urunId=" + selectedUrunId + "", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        internal void adetEksi(int selectedUrunId, int adet)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID= 26_132330123; Password=İnif123.;");
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("Update Product set urunAdet = urunAdet - " + adet + " where urunId=" + selectedUrunId + "", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        internal (int adet, int minStock) GetStockInfo(int urunId)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID= 26_132330123; Password=İnif123.;");
            baglanti.Open();

            MySqlCommand cmd = new MySqlCommand(
                "SELECT urunAdet, minStok FROM Product WHERE urunId = @id",
                baglanti
            );
            cmd.Parameters.AddWithValue("@id", urunId);

            MySqlDataReader dr = cmd.ExecuteReader();
            int adet = 0;
            int minStok = 0;

            if (dr.Read())
            {
                adet = dr.GetInt32("urunAdet");
                minStok = dr.GetInt32("minStok");
            }

            baglanti.Close();
            return (adet, minStok);
        }

        public string urunAdiGetir(int urunId)
        {
            string urunAdi = "";

            MySqlConnection baglanti =
                new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID=26_132330123;Password=İnif123.;");

            baglanti.Open();

            string sql = "SELECT urunAdi FROM Product WHERE urunId = " + urunId;
            MySqlCommand cmd = new MySqlCommand(sql, baglanti);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                urunAdi = reader["urunAdi"].ToString();
            }

            baglanti.Close();
            return urunAdi;
        }


    }
}
