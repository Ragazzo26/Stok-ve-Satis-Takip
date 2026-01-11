using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPproje.Domain
{
    internal class Sales
    {
        int saleId, mId, pId, miktar, saleSayisi;
        double fiyat, toplam, indirim, maliyet, karZarar; 
        DateTime saleDate;

        
        public int SaleId { get { return saleId; } set { saleId = value; } }
        public int Mid { get { return mId; } set { mId = value; } }
        public int Pid { get { return pId; } set { pId = value; } }
        public int Miktar { get { return miktar; } set { miktar = value; } }
        public double Fiyat { get { return fiyat; } set { fiyat = value; } }
        public double Toplam { get { return toplam; } set { toplam = value; } }
        public double Indirim { get { return indirim; } set { indirim = value; } }
        public int SaleSayisi { get { return saleSayisi; } set { saleSayisi = value; } }
        public double Maliyet { get { return maliyet; } set { maliyet = value; } }
        public double KarZarar { get { return karZarar; } set { karZarar = value; } }   
        public DateTime SaleDate { get { return saleDate; } set { saleDate = value; } }

        public Customer Customer { get; set; }
    }
}
