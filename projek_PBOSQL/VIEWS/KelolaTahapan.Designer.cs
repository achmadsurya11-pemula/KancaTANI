namespace projek_PBOSQL.VIEWS
{
    partial class KelolaTahapan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaTahapan));
            panelMainContent = new Panel();
            dgvTahapan = new DataGridView();
            id_fase = new DataGridViewTextBoxColumn();
            nama_fase = new DataGridViewTextBoxColumn();
            umur_min = new DataGridViewTextBoxColumn();
            umur_max = new DataGridViewTextBoxColumn();
            nama_tanaman = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnKelolaTahapan = new Button();
            pictureBox2 = new PictureBox();
            btnLogout = new Button();
            btnKelolaStock = new Button();
            btnKelolaPupuk = new Button();
            btnUser = new Button();
            btnDashboard = new Button();
            panelMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTahapan).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.White;
            panelMainContent.Controls.Add(dgvTahapan);
            panelMainContent.Location = new Point(309, 0);
            panelMainContent.Margin = new Padding(4, 5, 4, 5);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1726, 1248);
            panelMainContent.TabIndex = 2;
            panelMainContent.Paint += panelMainContent_Paint;
            // 
            // dgvTahapan
            // 
            dgvTahapan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTahapan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTahapan.Columns.AddRange(new DataGridViewColumn[] { id_fase, nama_fase, umur_min, umur_max, nama_tanaman });
            dgvTahapan.Location = new Point(56, 149);
            dgvTahapan.Margin = new Padding(4, 5, 4, 5);
            dgvTahapan.Name = "dgvTahapan";
            dgvTahapan.RowHeadersWidth = 51;
            dgvTahapan.Size = new Size(1278, 525);
            dgvTahapan.TabIndex = 0;
            dgvTahapan.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id_fase
            // 
            id_fase.HeaderText = "id_fase";
            id_fase.MinimumWidth = 6;
            id_fase.Name = "id_fase";
            // 
            // nama_fase
            // 
            nama_fase.HeaderText = "nama_fase";
            nama_fase.MinimumWidth = 6;
            nama_fase.Name = "nama_fase";
            // 
            // umur_min
            // 
            umur_min.HeaderText = "umur_min";
            umur_min.MinimumWidth = 6;
            umur_min.Name = "umur_min";
            // 
            // umur_max
            // 
            umur_max.HeaderText = "umur_max";
            umur_max.MinimumWidth = 6;
            umur_max.Name = "umur_max";
            // 
            // nama_tanaman
            // 
            nama_tanaman.HeaderText = "nama_tanaman";
            nama_tanaman.MinimumWidth = 6;
            nama_tanaman.Name = "nama_tanaman";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnKelolaTahapan);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnKelolaStock);
            panel1.Controls.Add(btnKelolaPupuk);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(1, 2, 1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1170);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_dan_teks_pojok;
            pictureBox1.Location = new Point(14, 27);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnKelolaTahapan
            // 
            btnKelolaTahapan.BackColor = Color.White;
            btnKelolaTahapan.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaTahapan.ForeColor = Color.Black;
            btnKelolaTahapan.Location = new Point(14, 645);
            btnKelolaTahapan.Margin = new Padding(1, 2, 1, 2);
            btnKelolaTahapan.Name = "btnKelolaTahapan";
            btnKelolaTahapan.Size = new Size(271, 72);
            btnKelolaTahapan.TabIndex = 8;
            btnKelolaTahapan.Text = "Kelola Tahapan";
            btnKelolaTahapan.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logout;
            pictureBox2.Location = new Point(37, 1037);
            pictureBox2.Margin = new Padding(1, 2, 1, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 0, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(96, 1033);
            btnLogout.Margin = new Padding(1, 2, 1, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(154, 50);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnKelolaStock
            // 
            btnKelolaStock.BackColor = Color.Black;
            btnKelolaStock.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaStock.ForeColor = Color.White;
            btnKelolaStock.Location = new Point(14, 548);
            btnKelolaStock.Margin = new Padding(1, 2, 1, 2);
            btnKelolaStock.Name = "btnKelolaStock";
            btnKelolaStock.Size = new Size(271, 72);
            btnKelolaStock.TabIndex = 4;
            btnKelolaStock.Text = "Kelola Stock";
            btnKelolaStock.UseVisualStyleBackColor = false;
            btnKelolaStock.Click += btnKelolaStock_Click_1;
            // 
            // btnKelolaPupuk
            // 
            btnKelolaPupuk.BackColor = Color.Black;
            btnKelolaPupuk.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaPupuk.ForeColor = Color.White;
            btnKelolaPupuk.Location = new Point(14, 452);
            btnKelolaPupuk.Margin = new Padding(1, 2, 1, 2);
            btnKelolaPupuk.Name = "btnKelolaPupuk";
            btnKelolaPupuk.Size = new Size(271, 72);
            btnKelolaPupuk.TabIndex = 3;
            btnKelolaPupuk.Text = "Kelola Pupuk";
            btnKelolaPupuk.UseVisualStyleBackColor = false;
            btnKelolaPupuk.Click += btnKelolaPupuk_Click_1;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.Black;
            btnUser.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.White;
            btnUser.Location = new Point(14, 358);
            btnUser.Margin = new Padding(1, 2, 1, 2);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(271, 72);
            btnUser.TabIndex = 2;
            btnUser.Text = "Kelola User";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Black;
            btnDashboard.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(14, 265);
            btnDashboard.Margin = new Padding(1, 2, 1, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(271, 72);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // KelolaTahapan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1170);
            Controls.Add(panel1);
            Controls.Add(panelMainContent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "KelolaTahapan";
            Text = "KancaTani";
            WindowState = FormWindowState.Maximized;
            Load += KelolaTahapan_Load;
            panelMainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTahapan).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMainContent;
        private DataGridView dgvTahapan;
        private DataGridViewTextBoxColumn id_fase;
        private DataGridViewTextBoxColumn nama_fase;
        private DataGridViewTextBoxColumn umur_min;
        private DataGridViewTextBoxColumn umur_max;
        private DataGridViewTextBoxColumn nama_tanaman;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnKelolaTahapan;
        private PictureBox pictureBox2;
        private Button btnLogout;
        private Button btnKelolaStock;
        private Button btnKelolaPupuk;
        private Button btnUser;
        private Button btnDashboard;
    }
}