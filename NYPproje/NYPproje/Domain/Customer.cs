using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NYPproje.Domain
{
   public class Customer
    {
        int musteriId;
        string musteriAdi;
        MusteriType musteriType;

       

        public int MusteriId { get { return musteriId; } set { musteriId = value; } }
        public string MusteriAdi { get { return musteriAdi; } set { musteriAdi = value; } }  
        public MusteriType MusteriType { get; set; }

        public override string ToString()
        {
            return MusteriAdi + " (" + MusteriType + ")";
        }

    }
    public enum MusteriType
    {
        Perakende = 0,
        Toptan = 1   
    }

   
}
