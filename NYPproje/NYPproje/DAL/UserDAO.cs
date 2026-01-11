using MySql.Data.MySqlClient;
using NYPproje.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYPproje.DAL
{
    internal class UserDAO
    {
        public int login (string gUsername, string gPassword)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132330123;User ID= 26_132330123; Password=İnif123.;");
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("select rId from User where username='" + gUsername + "' and password='" + gPassword + "'", baglanti);
            object result = cmd.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int role))
                return role;
            int RoleId = Convert.ToInt32(result);
            return 0;
        }
    }
}
