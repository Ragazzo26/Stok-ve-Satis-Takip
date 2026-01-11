using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPproje.Domain
{
    internal class Role
    {
        int roleid;
        string roleName;

        public Role (int roleid, string roleName)
        {
            this.roleid = roleid;
            this.roleName = roleName;
        }

        public int Roleid { get { return roleid; } set { roleid = value; } }
        public string RoleName { get { return roleName; } set {roleName = value; } }
    }
}
//UYGULANILMADI
