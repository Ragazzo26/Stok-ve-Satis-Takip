using MySql.Data.MySqlClient;
using NYPproje.Domain;
using NYPproje.Service;
using System;
using System.Collections;
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
    public partial class ProductForm : Form
    {
        
        public ProductForm()
        {
            InitializeComponent();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            new ProductService().kaydet(adTxt.Text,Convert.ToInt32(adetTxt.Text),Convert.ToDouble(fiyatTxt.Text), Convert.ToDouble(maliyetTxt.Text),Convert.ToInt32(minstockTxt.Text));
            urunGetir();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            urunGetir();

        }
        int selectedUrunId = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void duzenleBtn_Click(object sender, EventArgs e)
        {
            new ProductService().urunDuzelt(selectedUrunId, adBox.Text, Convert.ToInt32(adetBox.Text), Convert.ToDouble(fiyatBox.Text), Convert.ToDouble(maliyetBox.Text), Convert.ToInt32(stockBox.Text));
            urunGetir();
        }
        public void urunGetir()
        {
            ProductService service = new ProductService();
            List<Product> list = service.urunGetir();

            dataGridView1.DataSource = list;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            new ProductService().urunSil(selectedUrunId);
            adBox.Text = null;
            adetBox.Text = null;
            fiyatBox.Text = null;
            maliyetBox.Text = null;
            stockBox.Text = null;
            urunGetir();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedUrunId = Convert.ToInt32(row.Cells["urunId"].Value);

                adBox.Text = row.Cells["UrunAdi"].Value.ToString();
                adetBox.Text = row.Cells["UrunAdet"].Value.ToString();
                fiyatBox.Text = row.Cells["UrunFiyat"].Value.ToString();
                maliyetBox.Text = row.Cells["UrunMaliyet"].Value.ToString();
                stockBox.Text = row.Cells["MinStock"].Value.ToString();
            }
        }

        

        private void backbtn_Click(object sender, EventArgs e)
        {
            mainForm d = new mainForm();
            d.Show();
            this.Close();
        }

        private void fiyatTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
