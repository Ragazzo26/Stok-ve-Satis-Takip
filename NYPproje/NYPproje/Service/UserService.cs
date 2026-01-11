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
    internal class UserService
    {
        UserDAO dao = new UserDAO();
        public int login(string username, string password)
        {
            int role = dao.login(username, password);
            return role;
        }
    }
}
