namespace projek_PBOSQL.VIEWS
{
    partial class FormTransaksi
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
            panel2 = new Panel();
            label1 = new Label();
            lblTotalHarga = new Label();
            cmbToko = new ComboBox();
            flpKatalog = new FlowLayoutPanel();
            dgvKeranjang = new DataGridView();
            btnBayar = new Button();
            panel1 = new Panel();
            button1 = new Button();
            btnHistory = new Button();
            btnTransaksi = new Button();
            btnAnalisa = new Button();
            pictureBox1 = new PictureBox();
            cmbMetodePembayaran = new ComboBox();
            txtInputPembayaran = new TextBox();
            lblInput = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTotalHarga);
            panel2.Controls.Add(cmbToko);
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1598, 77);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 22);
            label1.Name = "label1";
            label1.Size = new Size(277, 38);
            label1.TabIndex = 2;
            label1.Text = "Katalog Produk ||";
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.Font = new Font("Helvetica", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalHarga.ForeColor = Color.White;
            lblTotalHarga.Location = new Point(298, 22);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(100, 38);
            lblTotalHarga.TabIndex = 1;
            lblTotalHarga.Text = "Total:";
            // 
            // cmbToko
            // 
            cmbToko.FormattingEnabled = true;
            cmbToko.Location = new Point(1037, 22);
            cmbToko.Name = "cmbToko";
            cmbToko.Size = new Size(535, 33);
            cmbToko.TabIndex = 0;
            // 
            // flpKatalog
            // 
            flpKatalog.AutoScroll = true;
            flpKatalog.BackColor = Color.WhiteSmoke;
            flpKatalog.Location = new Point(306, 83);
            flpKatalog.Name = "flpKatalog";
            flpKatalog.Size = new Size(1025, 1049);
            flpKatalog.TabIndex = 2;
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.BackgroundColor = Color.WhiteSmoke;
            dgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKeranjang.GridColor = Color.WhiteSmoke;
            dgvKeranjang.Location = new Point(1337, 83);
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.RowHeadersWidth = 62;
            dgvKeranjang.Size = new Size(549, 644);
            dgvKeranjang.TabIndex = 3;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.FromArgb(255, 128, 0);
            btnBayar.Font = new Font("Helvetica", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBayar.ForeColor = SystemColors.ControlLightLight;
            btnBayar.Location = new Point(1737, 742);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(149, 63);
            btnBayar.TabIndex = 2;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = false;
            btnBayar.Click += btnBayar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnTransaksi);
            panel1.Controls.Add(btnAnalisa);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1144);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.ForeColor = Color.White;
            button1.Location = new Point(90, 1073);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            btnTransaksi.BackColor = Color.White;
            btnTransaksi.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransaksi.ForeColor = Color.Black;
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
            btnAnalisa.BackColor = Color.Black;
            btnAnalisa.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnalisa.ForeColor = SystemColors.ButtonHighlight;
            btnAnalisa.Location = new Point(24, 276);
            btnAnalisa.Name = "btnAnalisa";
            btnAnalisa.Size = new Size(255, 78);
            btnAnalisa.TabIndex = 1;
            btnAnalisa.Text = "Analisa";
            btnAnalisa.UseVisualStyleBackColor = false;
            btnAnalisa.Click += btnAnalisa_Click;
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
            // cmbMetodePembayaran
            // 
            cmbMetodePembayaran.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodePembayaran.FormattingEnabled = true;
            cmbMetodePembayaran.Items.AddRange(new object[] { "Tunai", "Transfer" });
            cmbMetodePembayaran.Location = new Point(1337, 742);
            cmbMetodePembayaran.Name = "cmbMetodePembayaran";
            cmbMetodePembayaran.Size = new Size(182, 33);
            cmbMetodePembayaran.TabIndex = 5;
            // 
            // txtInputPembayaran
            // 
            txtInputPembayaran.Location = new Point(1337, 825);
            txtInputPembayaran.Name = "txtInputPembayaran";
            txtInputPembayaran.Size = new Size(182, 31);
            txtInputPembayaran.TabIndex = 6;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(1337, 797);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(119, 25);
            lblInput.TabIndex = 7;
            lblInput.Text = "Jumlah Uang ";
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1144);
            Controls.Add(lblInput);
            Controls.Add(txtInputPembayaran);
            Controls.Add(cmbMetodePembayaran);
            Controls.Add(panel1);
            Controls.Add(btnBayar);
            Controls.Add(dgvKeranjang);
            Controls.Add(flpKatalog);
            Controls.Add(panel2);
            Name = "FormTransaksi";
            Text = "FormTransaksi";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private FlowLayoutPanel flpKatalog;
        private Label lblTotalHarga;
        private ComboBox cmbToko;
        private DataGridView dgvKeranjang;
        private Button btnBayar;
        private Label label1;
        private Panel panel1;
        private Button btnHistory;
        private Button btnTransaksi;
        private Button btnAnalisa;
        private PictureBox pictureBox1;
        private ComboBox cmbMetodePembayaran;
        private TextBox txtInputPembayaran;
        private Label lblInput;
        private Button button1;
    }
}