using NYPproje.DAL;
using NYPproje.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYPproje.Service
{
    
    internal class CustomerService
    {
        CustomerDAO cDao = new CustomerDAO();
        internal List<Customer> GetMusteriler()
        {
            return cDao.GetMusteriler();
        }


        internal void musteriKaydet(string ad, string items)
        {
            cDao.musteriKaydet(ad, items);
        }

        internal void musteriSil(int mustId)
        {
            cDao.musteriSil(mustId);

        }
    }
}
