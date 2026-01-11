using NYPproje.DAL;
using NYPproje.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPproje.Service
{
    internal class ReportService
    {
        ReportDAO dao = new ReportDAO();
        Sales sTarih = new Sales();

        public Sales aylikSatis(DateTime secilenTarih)
        {
            sTarih.SaleDate = secilenTarih;

            return dao.aylikSatis(sTarih);
        }


        internal List<Sales> encokSatilan(DateTime tarih)
        {
            return dao.encokSatilan(tarih);
        }
        internal List<Sales> cokMusteri(DateTime tarih)
        {
            return dao.cokMusteri(tarih);
        }

        internal Sales karZarar(DateTime tarih)
        {
            return dao.karZarar(tarih);
        }
        internal List<Product> minimumStok()
        {
            return dao.minimumStok();
        }
    }
}
