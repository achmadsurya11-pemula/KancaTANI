namespace projek_PBOSQL.VIEWS
{
    partial class PETANI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PETANI));
            panel1 = new Panel();
            btnHistory = new Button();
            btnTransaksi = new Button();
            btnAnalisa = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnLanjutTransaksi = new Button();
            lblTotalBiaya = new Label();
            dgvRekomendasi = new DataGridView();
            btnHitung = new Button();
            txtLuasLahan = new TextBox();
            cmbFase = new ComboBox();
            cmbTanaman = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRekomendasi).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnTransaksi);
            panel1.Controls.Add(btnAnalisa);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1144);
            panel1.TabIndex = 0;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.Black;
            btnHistory.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(24, 484);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(255, 78);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "History ";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = Color.Black;
            btnTransaksi.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransaksi.ForeColor = Color.Transparent;
            btnTransaksi.Location = new Point(24, 381);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(255, 78);
            btnTransaksi.TabIndex = 2;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.UseVisualStyleBackColor = false;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // btnAnalisa
            // 
            btnAnalisa.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnalisa.Location = new Point(24, 276);
            btnAnalisa.Name = "btnAnalisa";
            btnAnalisa.Size = new Size(255, 78);
            btnAnalisa.TabIndex = 1;
            btnAnalisa.Text = "Analisa";
            btnAnalisa.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_dan_teks_pojok;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(btnLanjutTransaksi);
            panel2.Controls.Add(lblTotalBiaya);
            panel2.Controls.Add(dgvRekomendasi);
            panel2.Controls.Add(btnHitung);
            panel2.Controls.Add(txtLuasLahan);
            panel2.Controls.Add(cmbFase);
            panel2.Controls.Add(cmbTanaman);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1598, 1144);
            panel2.TabIndex = 1;
            // 
            // btnLanjutTransaksi
            // 
            btnLanjutTransaksi.BackColor = Color.Black;
            btnLanjutTransaksi.ForeColor = Color.White;
            btnLanjutTransaksi.Location = new Point(1340, 1018);
            btnLanjutTransaksi.Name = "btnLanjutTransaksi";
            btnLanjutTransaksi.Size = new Size(235, 59);
            btnLanjutTransaksi.TabIndex = 6;
            btnLanjutTransaksi.Text = "Lanjut Transaksi";
            btnLanjutTransaksi.UseVisualStyleBackColor = false;
            btnLanjutTransaksi.Click += btnLanjutTransaksi_Click;
            // 
            // lblTotalBiaya
            // 
            lblTotalBiaya.AutoSize = true;
            lblTotalBiaya.BackColor = Color.Transparent;
            lblTotalBiaya.Font = new Font("Helvetica", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBiaya.Location = new Point(26, 1039);
            lblTotalBiaya.Name = "lblTotalBiaya";
            lblTotalBiaya.Size = new Size(100, 38);
            lblTotalBiaya.TabIndex = 5;
            lblTotalBiaya.Text = "Total:";
            // 
            // dgvRekomendasi
            // 
            dgvRekomendasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRekomendasi.BackgroundColor = Color.WhiteSmoke;
            dgvRekomendasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRekomendasi.Location = new Point(26, 554);
            dgvRekomendasi.Name = "dgvRekomendasi";
            dgvRekomendasi.RowHeadersWidth = 62;
            dgvRekomendasi.Size = new Size(1549, 448);
            dgvRekomendasi.TabIndex = 4;
            // 
            // btnHitung
            // 
            btnHitung.BackColor = Color.Black;
            btnHitung.FlatAppearance.BorderSize = 0;
            btnHitung.FlatStyle = FlatStyle.Flat;
            btnHitung.ForeColor = SystemColors.ControlLightLight;
            btnHitung.Location = new Point(1323, 411);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(232, 60);
            btnHitung.TabIndex = 3;
            btnHitung.Text = "HITUNG";
            btnHitung.UseVisualStyleBackColor = false;
            btnHitung.Click += btnHitung_Click;
            // 
            // txtLuasLahan
            // 
            txtLuasLahan.Location = new Point(825, 331);
            txtLuasLahan.Name = "txtLuasLahan";
            txtLuasLahan.Size = new Size(679, 31);
            txtLuasLahan.TabIndex = 2;
            // 
            // cmbFase
            // 
            cmbFase.FormattingEnabled = true;
            cmbFase.Items.AddRange(new object[] { "Semua Fase", "Pemupukan Dasar", "Pemupukan Susulan I", "Pemupukan Susulan II" });
            cmbFase.Location = new Point(62, 426);
            cmbFase.Name = "cmbFase";
            cmbFase.Size = new Size(720, 33);
            cmbFase.TabIndex = 1;
            // 
            // cmbTanaman
            // 
            cmbTanaman.FormattingEnabled = true;
            cmbTanaman.Location = new Point(62, 331);
            cmbTanaman.Name = "cmbTanaman";
            cmbTanaman.Size = new Size(720, 33);
            cmbTanaman.TabIndex = 0;
            // 
            // PETANI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1144);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "PETANI";
            Text = "KancaTani";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRekomendasi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnHistory;
        private Button btnTransaksi;
        private Button btnAnalisa;
        private TextBox txtLuasLahan;
        private ComboBox cmbFase;
        private ComboBox cmbTanaman;
        private Button btnHitung;
        private DataGridView dgvRekomendasi;
        private Label lblTotalBiaya;
        private Button btnLanjutTransaksi;
    }
}