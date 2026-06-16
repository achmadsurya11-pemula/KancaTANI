namespace projek_PBOSQL.VIEWS
{
    partial class KelolaStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaStock));
            dgvPupuk = new DataGridView();
            btnTambah = new Button();
            btnDetail = new Button();
            lblTotalStock = new Label();
            lblPeringatan = new Label();
            panel2 = new Panel();
            label1 = new Label();
            txtCariStok = new TextBox();
            btnDashboard = new Button();
            btnKelolaUser = new Button();
            btnKelPupuk = new Button();
            btnKelolaStock = new Button();
            btnTahapan = new Button();
            btnHistory = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            btnKelTah = new Button();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            btnKelStok = new Button();
            btnKelPuk = new Button();
            btnKel = new Button();
            btndash = new Button();
            pictureBox6 = new PictureBox();
            button11 = new Button();
            pictureBox7 = new PictureBox();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPupuk).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // dgvPupuk
            // 
            dgvPupuk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPupuk.BackgroundColor = Color.White;
            dgvPupuk.BorderStyle = BorderStyle.Fixed3D;
            dgvPupuk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPupuk.Location = new Point(65, 373);
            dgvPupuk.Name = "dgvPupuk";
            dgvPupuk.RowHeadersWidth = 62;
            dgvPupuk.Size = new Size(1474, 458);
            dgvPupuk.TabIndex = 0;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = SystemColors.ActiveCaptionText;
            btnTambah.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = SystemColors.Control;
            btnTambah.Location = new Point(1254, 296);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(270, 67);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "+ Tambah Stock";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnDetail
            // 
            btnDetail.BackColor = SystemColors.ActiveCaptionText;
            btnDetail.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetail.ForeColor = SystemColors.ButtonFace;
            btnDetail.Location = new Point(1224, 154);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(154, 65);
            btnDetail.TabIndex = 2;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // lblTotalStock
            // 
            lblTotalStock.AutoSize = true;
            lblTotalStock.BackColor = Color.White;
            lblTotalStock.Font = new Font("Arial", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStock.Location = new Point(92, 153);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(46, 51);
            lblTotalStock.TabIndex = 3;
            lblTotalStock.Text = "0";
            // 
            // lblPeringatan
            // 
            lblPeringatan.AutoSize = true;
            lblPeringatan.BackColor = Color.White;
            lblPeringatan.Font = new Font("Arial", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeringatan.Location = new Point(590, 144);
            lblPeringatan.Name = "lblPeringatan";
            lblPeringatan.Size = new Size(46, 51);
            lblPeringatan.TabIndex = 4;
            lblPeringatan.Text = "0";
            lblPeringatan.Click += lblPeringatan_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Ukuran_kelola_stock_Pupuk;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtCariStok);
            panel2.Controls.Add(lblPeringatan);
            panel2.Controls.Add(lblTotalStock);
            panel2.Controls.Add(btnDetail);
            panel2.Controls.Add(btnTambah);
            panel2.Controls.Add(dgvPupuk);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(320, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1604, 1170);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(967, 42);
            label1.Name = "label1";
            label1.Size = new Size(138, 29);
            label1.TabIndex = 6;
            label1.Text = "Pencarian:";
            // 
            // txtCariStok
            // 
            txtCariStok.BorderStyle = BorderStyle.FixedSingle;
            txtCariStok.Location = new Point(1111, 32);
            txtCariStok.Multiline = true;
            txtCariStok.Name = "txtCariStok";
            txtCariStok.Size = new Size(389, 49);
            txtCariStok.TabIndex = 5;
            txtCariStok.TextChanged += txtCariStok_TextChanged;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Black;
            btnDashboard.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(41, 272);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(214, 67);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnKelolaUser
            // 
            btnKelolaUser.BackColor = Color.Black;
            btnKelolaUser.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaUser.ForeColor = Color.White;
            btnKelolaUser.Location = new Point(41, 373);
            btnKelolaUser.Name = "btnKelolaUser";
            btnKelolaUser.Size = new Size(214, 67);
            btnKelolaUser.TabIndex = 2;
            btnKelolaUser.Text = "Kelola User";
            btnKelolaUser.UseVisualStyleBackColor = false;
            // 
            // btnKelPupuk
            // 
            btnKelPupuk.BackColor = Color.Black;
            btnKelPupuk.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelPupuk.ForeColor = Color.White;
            btnKelPupuk.Location = new Point(41, 468);
            btnKelPupuk.Name = "btnKelPupuk";
            btnKelPupuk.Size = new Size(214, 67);
            btnKelPupuk.TabIndex = 3;
            btnKelPupuk.Text = "Kelola Pupuk";
            btnKelPupuk.UseVisualStyleBackColor = false;
            // 
            // btnKelolaStock
            // 
            btnKelolaStock.BackColor = Color.White;
            btnKelolaStock.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaStock.Location = new Point(41, 575);
            btnKelolaStock.Name = "btnKelolaStock";
            btnKelolaStock.Size = new Size(214, 67);
            btnKelolaStock.TabIndex = 4;
            btnKelolaStock.Text = "Kelola Stock";
            btnKelolaStock.UseVisualStyleBackColor = false;
            // 
            // btnTahapan
            // 
            btnTahapan.BackColor = Color.Black;
            btnTahapan.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTahapan.ForeColor = Color.White;
            btnTahapan.Location = new Point(41, 668);
            btnTahapan.Name = "btnTahapan";
            btnTahapan.Size = new Size(214, 67);
            btnTahapan.TabIndex = 1;
            btnTahapan.Text = "Kelola Tahapan";
            btnTahapan.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.Location = new Point(41, 763);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(214, 67);
            btnHistory.TabIndex = 5;
            btnHistory.Text = "History Transaksi";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(129, 1037);
            button1.Name = "button1";
            button1.Size = new Size(91, 37);
            button1.TabIndex = 6;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logout;
            pictureBox1.Location = new Point(60, 1037);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnTahapan);
            panel1.Controls.Add(btnKelolaStock);
            panel1.Controls.Add(btnKelPupuk);
            panel1.Controls.Add(btnKelolaUser);
            panel1.Controls.Add(btnDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 1170);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(panel3);
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(button11);
            panel6.Controls.Add(pictureBox7);
            panel6.Controls.Add(button12);
            panel6.Controls.Add(button13);
            panel6.Controls.Add(button14);
            panel6.Controls.Add(button15);
            panel6.Controls.Add(button16);
            panel6.Location = new Point(6, 5);
            panel6.Margin = new Padding(1, 2, 1, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 1442);
            panel6.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(btnKelTah);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(btnKelStok);
            panel3.Controls.Add(btnKelPuk);
            panel3.Controls.Add(btnKel);
            panel3.Controls.Add(btndash);
            panel3.Location = new Point(10, 10);
            panel3.Margin = new Padding(1, 2, 1, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 1442);
            panel3.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_dan_teks_pojok;
            pictureBox2.Location = new Point(14, 27);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(269, 233);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // btnKelTah
            // 
            btnKelTah.BackColor = Color.Black;
            btnKelTah.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelTah.ForeColor = Color.White;
            btnKelTah.Location = new Point(14, 645);
            btnKelTah.Margin = new Padding(1, 2, 1, 2);
            btnKelTah.Name = "btnKelTah";
            btnKelTah.Size = new Size(271, 72);
            btnKelTah.TabIndex = 8;
            btnKelTah.Text = "Kelola Tahapan";
            btnKelTah.UseVisualStyleBackColor = false;
            btnKelTah.Click += btnKelTah_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logout;
            pictureBox3.Location = new Point(37, 1037);
            pictureBox3.Margin = new Padding(1, 2, 1, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(96, 1033);
            button3.Margin = new Padding(1, 2, 1, 2);
            button3.Name = "button3";
            button3.Size = new Size(154, 50);
            button3.TabIndex = 6;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnKelStok
            // 
            btnKelStok.BackColor = Color.White;
            btnKelStok.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelStok.ForeColor = Color.Black;
            btnKelStok.Location = new Point(14, 548);
            btnKelStok.Margin = new Padding(1, 2, 1, 2);
            btnKelStok.Name = "btnKelStok";
            btnKelStok.Size = new Size(271, 72);
            btnKelStok.TabIndex = 4;
            btnKelStok.Text = "Kelola Stock";
            btnKelStok.UseVisualStyleBackColor = false;
            // 
            // btnKelPuk
            // 
            btnKelPuk.BackColor = Color.Black;
            btnKelPuk.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelPuk.ForeColor = Color.White;
            btnKelPuk.Location = new Point(14, 452);
            btnKelPuk.Margin = new Padding(1, 2, 1, 2);
            btnKelPuk.Name = "btnKelPuk";
            btnKelPuk.Size = new Size(271, 72);
            btnKelPuk.TabIndex = 3;
            btnKelPuk.Text = "Kelola Pupuk";
            btnKelPuk.UseVisualStyleBackColor = false;
            btnKelPuk.Click += btnKelPuk_Click;
            // 
            // btnKel
            // 
            btnKel.BackColor = Color.Black;
            btnKel.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKel.ForeColor = Color.White;
            btnKel.Location = new Point(14, 358);
            btnKel.Margin = new Padding(1, 2, 1, 2);
            btnKel.Name = "btnKel";
            btnKel.Size = new Size(271, 72);
            btnKel.TabIndex = 2;
            btnKel.Text = "Kelola User";
            btnKel.UseVisualStyleBackColor = false;
            btnKel.Click += btnKel_Click;
            // 
            // btndash
            // 
            btndash.BackColor = Color.Black;
            btndash.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndash.ForeColor = Color.White;
            btndash.Location = new Point(14, 265);
            btndash.Margin = new Padding(1, 2, 1, 2);
            btndash.Name = "btndash";
            btndash.Size = new Size(271, 72);
            btndash.TabIndex = 1;
            btndash.Text = "Dashboard";
            btndash.UseVisualStyleBackColor = false;
            btndash.Click += btndash_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.logo_dan_teks_pojok;
            pictureBox6.Location = new Point(14, 27);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(269, 233);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // button11
            // 
            button11.BackColor = Color.Black;
            button11.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.White;
            button11.Location = new Point(14, 645);
            button11.Margin = new Padding(1, 2, 1, 2);
            button11.Name = "button11";
            button11.Size = new Size(271, 72);
            button11.TabIndex = 8;
            button11.Text = "Kelola Tahapan";
            button11.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.logout;
            pictureBox7.Location = new Point(37, 1037);
            pictureBox7.Margin = new Padding(1, 2, 1, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(51, 42);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(192, 0, 0);
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Location = new Point(96, 1033);
            button12.Margin = new Padding(1, 2, 1, 2);
            button12.Name = "button12";
            button12.Size = new Size(154, 50);
            button12.TabIndex = 6;
            button12.Text = "Logout";
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.Black;
            button13.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.White;
            button13.Location = new Point(14, 548);
            button13.Margin = new Padding(1, 2, 1, 2);
            button13.Name = "button13";
            button13.Size = new Size(271, 72);
            button13.TabIndex = 4;
            button13.Text = "Kelola Stock";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.Black;
            button14.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.ForeColor = Color.White;
            button14.Location = new Point(14, 452);
            button14.Margin = new Padding(1, 2, 1, 2);
            button14.Name = "button14";
            button14.Size = new Size(271, 72);
            button14.TabIndex = 3;
            button14.Text = "Kelola Pupuk";
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = Color.Black;
            button15.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.ForeColor = Color.White;
            button15.Location = new Point(14, 358);
            button15.Margin = new Padding(1, 2, 1, 2);
            button15.Name = "button15";
            button15.Size = new Size(271, 72);
            button15.TabIndex = 2;
            button15.Text = "Kelola User";
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.White;
            button16.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.ForeColor = Color.Black;
            button16.Location = new Point(14, 265);
            button16.Margin = new Padding(1, 2, 1, 2);
            button16.Name = "button16";
            button16.Size = new Size(271, 72);
            button16.TabIndex = 1;
            button16.Text = "Dashboard";
            button16.UseVisualStyleBackColor = false;
            // 
            // KelolaStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1170);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KelolaStock";
            Text = "KancaTani";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvPupuk).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPupuk;
        private Button btnTambah;
        private Button btnDetail;
        private Label lblTotalStock;
        private Label lblPeringatan;
        private Panel panel2;
        private Button btnDashboard;
        private Button btnKelolaUser;
        private Button btnKelPupuk;
        private Button btnKelolaStock;
        private Button btnTahapan;
        private Button btnHistory;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel6;
        private PictureBox pictureBox6;
        private Button button11;
        private PictureBox pictureBox7;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button btnKelTah;
        private PictureBox pictureBox3;
        private Button button3;
        private Button btnKelStok;
        private Button btnKelPuk;
        private Button btnKel;
        private Button btndash;
        private TextBox txtCariStok;
        private Label label1;
    }
}