using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPproje.Domain
{
    public class User
    {
        int userId, rId;
        string username, password;

   

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public User(string username, string password, int rId)
        {
            
            this.username = username;
            this.password = password;
            this.rId = rId;
        }
        public int UserId { get { return userId; } set { userId = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public static int Rid { get; set; }
    }
}
