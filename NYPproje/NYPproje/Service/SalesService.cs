using NYPproje.DAL;
using NYPproje.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace NYPproje.Service
{
    internal class SalesService
    {
        private List<Sales> cart = new List<Sales>();
        private double toplam = 0; 
        private DateTime? saleDate = null;
        ProductService ps = new ProductService();
        SalesDAO sDao = new SalesDAO();
        ProductDAO pDao = new ProductDAO();

        internal bool TryAddToCart(ProductService ps, Customer c, Product p, int miktar, DateTime date, out double itemToplam)
        {
            itemToplam = 0;
            int mevcutItem = 0;
            Sales mevcut = null;
            double indirimOrani = 0;
            
            foreach (Sales x in cart)
            {
                if (x.Pid  == p.UrunId)
                {
                    mevcutItem += x.Miktar;
                    mevcut = x;
                }
            }

            double eskiToplam = 0;
            if (mevcut != null)
            {
                eskiToplam = mevcut.Toplam;
            }

            int toplamMiktar = mevcutItem + miktar;
            if (c.MusteriType == MusteriType.Toptan && toplamMiktar >= 100)
            {
                    indirimOrani = 0.10;
            }

            if (c.MusteriType == MusteriType.Perakende && toplamMiktar >= 200)
            {
                indirimOrani = 0.10;
            }

            if (!ps.CheckStockWarning(p.UrunId, mevcutItem + miktar))
                return false;

            /*itemToplam = miktar * p.UrunFiyat;
            double indirim = itemToplam * indirimOrani;
            double netToplam = itemToplam - indirim;
            */
            double brutToplam = toplamMiktar * p.UrunFiyat;
            double indirimToplam = brutToplam * indirimOrani;
            double netToplam = brutToplam - indirimToplam;

            if (mevcut != null)
            {
                //mevcut.Miktar += miktar;
                //mevcut.Indirim += indirim;
                //mevcut.Toplam = (mevcut.Miktar * mevcut.Fiyat) - mevcut.Indirim;
                mevcut.Miktar = toplamMiktar;
                mevcut.Indirim = indirimToplam;
                mevcut.Toplam = netToplam;

            }
            else
            {
                Sales s = new Sales();
                s.Mid = c.MusteriId;     // FK Customer
                s.Pid = p.UrunId;        // FK Product
                s.Miktar = miktar;
                s.Fiyat = p.UrunFiyat;
                s.Indirim = indirimToplam;
                s.Toplam = netToplam;
                if (saleDate == null)
                {
                    saleDate = date;
                }


                cart.Add(s);
                
            }
            toplam += netToplam - eskiToplam;
            return true;
        }

        internal void satisEkle()
        {

            foreach (Sales s in cart)
            {
                if (!ps.CheckStockWarning(s.Pid, s.Miktar))

                    return;
                if (cart.Contains(s))
                {
                    s.SaleDate = saleDate.Value;
                    sDao.satisEkle(s);
                    pDao.adetEksi(s.Pid, s.Miktar);
                }
                else
                {
                    MessageBox.Show("Urunuz seciniz!");
                }
            }

            cart.Clear();
            toplam = 0;
        }
        internal double toplamAl()
        {
            return toplam;
        }

        internal void sepetSil()
        {
            cart.Clear();
            toplam = 0;
        }
    }
}
