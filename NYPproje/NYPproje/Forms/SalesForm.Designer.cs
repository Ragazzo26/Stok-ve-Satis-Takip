namespace NYPproje
{
    partial class SalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.urunListBox = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saleOnayla = new System.Windows.Forms.Button();
            this.saleEkle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toplamLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urunListBox
            // 
            this.urunListBox.FormattingEnabled = true;
            this.urunListBox.ItemHeight = 25;
            this.urunListBox.Location = new System.Drawing.Point(91, 143);
            this.urunListBox.Name = "urunListBox";
            this.urunListBox.Size = new System.Drawing.Size(229, 229);
            this.urunListBox.TabIndex = 1;
            this.urunListBox.SelectedIndexChanged += new System.EventHandler(this.urunListBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteri,
            this.urun,
            this.fiyat,
            this.miktar,
            this.toplam});
            this.dataGridView1.Location = new System.Drawing.Point(441, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(518, 347);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // musteri
            // 
            this.musteri.HeaderText = "Musteri";
            this.musteri.MinimumWidth = 10;
            this.musteri.Name = "musteri";
            this.musteri.Width = 70;
            // 
            // urun
            // 
            this.urun.HeaderText = "Urun";
            this.urun.MinimumWidth = 10;
            this.urun.Name = "urun";
            this.urun.Width = 55;
            // 
            // fiyat
            // 
            this.fiyat.HeaderText = "Fiyat";
            this.fiyat.MinimumWidth = 10;
            this.fiyat.Name = "fiyat";
            this.fiyat.Width = 35;
            // 
            // miktar
            // 
            this.miktar.HeaderText = "Qty";
            this.miktar.MinimumWidth = 10;
            this.miktar.Name = "miktar";
            this.miktar.Width = 35;
            // 
            // toplam
            // 
            this.toplam.HeaderText = "Toplam";
            this.toplam.MinimumWidth = 10;
            this.toplam.Name = "toplam";
            this.toplam.Width = 60;
            // 
            // miktarBox
            // 
            this.miktarBox.Location = new System.Drawing.Point(174, 401);
            this.miktarBox.Name = "miktarBox";
            this.miktarBox.Size = new System.Drawing.Size(118, 31);
            this.miktarBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Miktar :";
            // 
            // saleOnayla
            // 
            this.saleOnayla.BackColor = System.Drawing.Color.SteelBlue;
            this.saleOnayla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleOnayla.ForeColor = System.Drawing.Color.White;
            this.saleOnayla.Location = new System.Drawing.Point(843, 444);
            this.saleOnayla.Name = "saleOnayla";
            this.saleOnayla.Size = new System.Drawing.Size(116, 48);
            this.saleOnayla.TabIndex = 5;
            this.saleOnayla.Text = "Onayla";
            this.saleOnayla.UseVisualStyleBackColor = false;
            this.saleOnayla.Click += new System.EventHandler(this.saleOnayla_Click);
            // 
            // saleEkle
            // 
            this.saleEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.saleEkle.ForeColor = System.Drawing.Color.White;
            this.saleEkle.Location = new System.Drawing.Point(174, 449);
            this.saleEkle.Name = "saleEkle";
            this.saleEkle.Size = new System.Drawing.Size(118, 53);
            this.saleEkle.TabIndex = 6;
            this.saleEkle.Text = "Ekle";
            this.saleEkle.UseVisualStyleBackColor = false;
            this.saleEkle.Click += new System.EventHandler(this.saleEkle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 33);
            this.comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Toplam :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // toplamLbl
            // 
            this.toplamLbl.AutoSize = true;
            this.toplamLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toplamLbl.Location = new System.Drawing.Point(557, 452);
            this.toplamLbl.Name = "toplamLbl";
            this.toplamLbl.Size = new System.Drawing.Size(25, 25);
            this.toplamLbl.TabIndex = 9;
            this.toplamLbl.Text = "0";
            this.toplamLbl.Click += new System.EventHandler(this.toplamLbl_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(364, 31);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(441, 543);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(91, 40);
            this.backbtn.TabIndex = 11;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(965, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 61);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.MaximumSize = new System.Drawing.Size(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1042, 60);
            this.panel3.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SteelBlue;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(365, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 50);
            this.label11.TabIndex = 7;
            this.label11.Text = "SALES MENU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.urunListBox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.miktarBox);
            this.panel1.Controls.Add(this.saleEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 545);
            this.panel1.TabIndex = 30;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.toplamLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saleOnayla);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesForm";
            this.Tag = "";
            this.Text = "Raga Kırtasiye";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox urunListBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox miktarBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saleOnayla;
        private System.Windows.Forms.Button saleEkle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label toplamLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
    }
}