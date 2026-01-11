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
using System.Xml.Serialization;

namespace NYPproje
{
    public partial class SalesForm : Form
    {
        private SalesService service = new SalesService();
        private ProductService ps = new ProductService();
        
        public SalesForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            
        }

       
        private void SalesForm_Load(object sender, EventArgs e)
        {
            MusteriGetir();
            UrunGetir();
            
        }
        public void MusteriGetir()
        {
            var musteriler = new CustomerService().GetMusteriler();
            comboBox1.DataSource = musteriler;
        }
        public void UrunGetir()
        {
            
            List<Product> list = ps.urunGetir();

            urunListBox.DataSource = list;
            urunListBox.DisplayMember = "urunAdi";
            urunListBox.ValueMember = "urunId";
        }

        private void urunListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        private void saleEkle_Click(object sender, EventArgs e)
        {
            
            Customer c = (Customer)comboBox1.SelectedItem;
            Product p = (Product)urunListBox.SelectedItem;
            int miktar = Convert.ToInt32(miktarBox.Text);
            DateTime date = dateTimePicker1.Value;
     
            if (!service.TryAddToCart(ps, c, p, miktar, date, out double toplam))
                return;

            if (dataGridView1.Rows.Count == 1)
            {
                comboBox1.Enabled = false;
            }

            DataGridViewRow mevcutRow = null;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (row.Cells[1].Value == null)
                    continue;

                if (row.Cells[1].Value.ToString() == p.UrunAdi)
                {
                    mevcutRow = row;
                    break;
                }
            }
            

            if (mevcutRow != null)
            {
                int gecenMiktar = Convert.ToInt32(mevcutRow.Cells[3].Value);
                mevcutRow.Cells[3].Value = gecenMiktar + miktar;

                int gecenToplam = Convert.ToInt32(mevcutRow.Cells[4].Value);
                mevcutRow.Cells[4].Value = gecenToplam + toplam;
            }

            else
            {
                dataGridView1.Rows.Add(

                        c.MusteriAdi,
                        p.UrunAdi,
                        p.UrunFiyat,
                        miktar,
                        toplam = p.UrunFiyat * miktar

                        );
            }
            
            toplamLbl.Text = service.toplamAl().ToString();

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            mainForm d = new mainForm();
            d.Show();
            this.Close();
        }
       

        private void saleOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                service.satisEkle();
                MessageBox.Show(
                    "Satış kaydedildi",
                    "YEAYYYYY",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                dataGridView1.Rows.Clear();
                toplamLbl.Text = "0";
                comboBox1.Enabled = true;
            }
            catch 
            {
                MessageBox.Show(
                "Urunuzu Seciniz!",
                "HATA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                    );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            service.sepetSil();
            dataGridView1.Rows.Clear();
            toplamLbl.Text = "0";
            comboBox1.Enabled = true;
        }

        private void toplamLbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
