using NYPproje.Domain;
using NYPproje.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NYPproje
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        UserService s = new UserService();
        private void loginBtn_Click(object sender, EventArgs e)
        {
            int role = s.login(usernametxt.Text.ToString(), passwordtxt.Text);
            User.Rid = role;
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
