using NYPproje.Domain;
using NYPproje.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYPproje
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            ApplyRole();
        }

        private void ApplyRole()
        {
            
            switch (User.Rid)
            {
                case 1:
                    break;
                case 2:
                    productBtn.Enabled = false;
                    reportBtn.Enabled = false;
                    break;
                case 3:
                    stockBtn.Enabled = false;
                    saleBtn.Enabled = false;
                    reportBtn.Enabled = false;
                    break;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
           
        }

        public void productBtn_Click(object sender, EventArgs e)
        {
            ProductForm d = new ProductForm();
            d.Show();
            this.Hide();
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            CustomerForm d = new CustomerForm();
            d.Show();
            this.Hide();
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            SalesForm d = new SalesForm();
            d.Show();
            this.Hide();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            ReportForm d = new ReportForm();
            d.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm d = new LoginForm();
            d.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
