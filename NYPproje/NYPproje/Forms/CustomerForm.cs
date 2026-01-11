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

namespace NYPproje
{
    public partial class CustomerForm : Form
    {
       
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void musteriTipiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            musteriTipi();
            LoadMusteriler();
        }
        public void musteriTipi()
        {
            musteriTipiCbox.DataSource = Enum.GetValues(typeof(MusteriType));
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            if (musteriAdtxt.Text == null)
            {
                MessageBox.Show("Ad Giriniz");
            }
            else
            {
                new CustomerService().musteriKaydet(musteriAdtxt.Text, musteriTipiCbox.SelectedItem.ToString());
            }
            
            LoadMusteriler();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void LoadMusteriler()
        {
            var musteriler = new CustomerService().GetMusteriler();

            listBox1.DataSource = musteriler;
            
            
           
        }
        
        private void silBtn_Click(object sender, EventArgs e)
        {
            Customer c = (Customer)listBox1.SelectedItem;
            new CustomerService().musteriSil(c.MusteriId);
            LoadMusteriler();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            mainForm d = new mainForm();
            d.Show();
            this.Close();
        }
    }
}
