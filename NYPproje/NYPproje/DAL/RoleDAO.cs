using NYPproje.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace NYPproje.DAL
{
    internal class RoleDAO
    {
        public void login(Role gRole)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430021;User ID= 26_132430021; Password=İnif123.;");
            baglanti.Open();
            //UYGULANILMADI
        }
    }
}
