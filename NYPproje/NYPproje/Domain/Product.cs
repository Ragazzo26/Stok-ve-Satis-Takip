using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPproje.Domain
{
    internal class Product
    {
        public Product (string gAd, int gAdet, double gFiyat, double gMaliyet , int gStock)
        {
            this.urunAdi = gAd;
            this.urunAdet = gAdet;
            this.urunFiyat = gFiyat;
            this.urunMaliyet = gMaliyet;
            this.minStock = gStock;
        }
        public Product()
        {
            
        }


        int urunId;
        string urunAdi;
        int urunAdet, minStock;
        double urunFiyat, urunMaliyet;

        public int UrunId { get { return urunId; } set { urunId = value; } }
        public string UrunAdi { get {  return urunAdi; } set { urunAdi = value; } }
        public int UrunAdet { get { return urunAdet; } set { urunAdet = value; } }
        public double UrunFiyat { get { return urunFiyat; } set { urunFiyat = value; } }
        public double UrunMaliyet { get { return urunMaliyet; } set {  urunMaliyet = value; } }
        public int MinStock { get { return minStock; } set { minStock = value; } }
    }
}
