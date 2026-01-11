using NYPproje.DAL;
using NYPproje.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace NYPproje.Service
{
    internal class ProductService
    {
        ProductDAO dao = new ProductDAO();
        internal void kaydet(string gAd, int gAdet, double gFiyat,double gMaliyet, int gStock)
        {
            dao.kaydet(new Product(gAd, gAdet, gFiyat, gMaliyet, gStock));
        }

        public List<Product> urunGetir()
        {
            return dao.urunGetir();
        }

        internal void urunDuzelt (int id, string gAd, int gAdet, double gFiyat, double gMaliyet, int gStock)
        {
            Product p = new Product(gAd, gAdet, gFiyat, gMaliyet, gStock);
            p.UrunId = id;

            dao.urunDuzelt(p);
        }

        internal void urunSil(int selectedUrunId)
        {
            dao.urunSil(selectedUrunId);
        }


        internal bool CheckStockWarning(int urunId, int adet)
        {
            var info = dao.GetStockInfo(urunId);
            if (info.adet - adet <= 0)  //URUN 0 DUSMESIN
            {
                MessageBox.Show(
                   "UYARI: STOK : " + info.adet,
                   "Stock Warning",
                   
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
                return false;
            }

            if (info.adet - adet <= info.minStock )
            {
                MessageBox.Show(
                    "UYARI: STOK BITECEK!",
                    "Stock Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            return true;
        }
        internal string urunAdiGetir( int urunId )
        {
            return dao.urunAdiGetir( urunId );
        }
    }
}
