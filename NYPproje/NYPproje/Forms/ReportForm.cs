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
using System.Windows.Forms.DataVisualization.Charting;

namespace NYPproje.Forms
{
    public partial class ReportForm : Form
    {
        
        public ReportForm()
        {
            InitializeComponent();
        }

        private ReportService service = new ReportService();
        private ProductService ps = new ProductService();

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void aylikBtn_Click(object sender, EventArgs e)
        {
            DateTime secilenTarih = dateTimePicker1.Value;

           
            service.aylikSatis(secilenTarih);

            Sales rapor = service.aylikSatis(secilenTarih);

            dataGridView1.DataSource = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("Toplam Satis", typeof(string));
            dt.Columns.Add("Ciro", typeof(string));
            dt.Columns.Add("Indirim", typeof(string));

            dt.Rows.Add(rapor.Miktar + " Adet", rapor.Toplam + " TL", rapor.Indirim + " TL");

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;

            chart1.Series.Clear();
            var series = chart1.Series.Add("Aylik Satis");
            series.ChartType = SeriesChartType.RangeColumn;
            series.Points.AddXY("Toplam Satis", rapor.Miktar);
            series.Points.AddXY("Ciro", rapor.Toplam);
            series.Points.AddXY("Indirim", rapor.Indirim);

            
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }

        private void encokBtn_Click(object sender, EventArgs e)
        {
            DateTime secilenTarih = dateTimePicker1.Value;

            var liste = service.encokSatilan(secilenTarih);

            dataGridView1.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("Urun Adi", typeof(string));
            dt.Columns.Add("Miktar", typeof(string));
            

            foreach (var s in liste)
            {
                string urunAdi = ps.urunAdiGetir(s.Pid);
                dt.Rows.Add(urunAdi, s.Miktar);
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;

            chart1.Series.Clear();

            var series = new Series("En Çok Satılan");
            series.ChartType = SeriesChartType.RangeColumn;

            foreach (var s in liste)
            {
                string urunAdi = ps.urunAdiGetir(s.Pid);
                series.Points.AddXY(urunAdi, s.Miktar);
            }

            chart1.Series.Add(series);
        }

        private void musteriBtn_Click(object sender, EventArgs e)
        {
            DateTime secilenTarih = dateTimePicker1.Value;

            var liste = service.cokMusteri(secilenTarih);

            dataGridView1.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("Müşteri", typeof(string));
            dt.Columns.Add("Sales", typeof(int));
            dt.Columns.Add("Toplam Miktar", typeof(int));
            dt.Columns.Add("Ciro", typeof(double));

            foreach (var s in liste)
            {
                string musteriInfo = $"{s.Customer.MusteriAdi} ({s.Customer.MusteriType})";
                dt.Rows.Add(musteriInfo, s.SaleSayisi, s.Miktar, s.Toplam);
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;

           
            chart1.Series.Clear();
            var series = new Series("Müşteri Bazlı Ciro");
            series.ChartType = SeriesChartType.Column;

            foreach (var s in liste)
            {
                series.Points.AddXY(s.Customer.MusteriAdi, s.Toplam);
            }

            chart1.Series.Add(series);
        }

        private void karBtn_Click(object sender, EventArgs e)
        {
            DateTime secilenTarih = dateTimePicker1.Value;

            Sales rapor = service.karZarar(secilenTarih);

            
            dataGridView1.DataSource = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("Ciro (TL)", typeof(string));
            dt.Columns.Add("Maliyet (TL)", typeof(string));
            dt.Columns.Add("Kâr/Zarar (TL)", typeof(string));

            dt.Rows.Add(rapor.Toplam + " TL", rapor.Maliyet + " TL", rapor.KarZarar + " TL");

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;

          
            chart1.Series.Clear();
            var series = new Series("Kâr/Zarar");
            series.ChartType = SeriesChartType.Column;
            series.Points.AddXY("Kâr/Zarar", rapor.KarZarar);
            chart1.Series.Add(series);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            mainForm d = new mainForm();
            d.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var liste = service.minimumStok();

            dataGridView1.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("Urun Adi", typeof(string));
            dt.Columns.Add("Mevcut Stok", typeof(int));
            dt.Columns.Add("Min Stok", typeof(int));

            foreach (var p in liste)
            {
                dt.Rows.Add(p.UrunAdi, p.UrunAdet, p.MinStock);
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;

            chart1.Series.Clear();
            var series = new Series("Stok");
            series.ChartType = SeriesChartType.Column;

            foreach (var p in liste)
            {
                series.Points.AddXY(p.UrunAdi, p.UrunAdet);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Interval = 1;
        }
    }
}
