namespace projek_PBOSQL.VIEWS
{
    partial class FormHistory
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
            panel1 = new Panel();
            button1 = new Button();
            btnHistory = new Button();
            btnTransaksi = new Button();
            btnAnalisa = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            dgvHistory = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 5;
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
            btnHistory.BackColor = Color.White;
            btnHistory.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.Black;
            btnHistory.Location = new Point(24, 484);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(255, 78);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "History ";
            btnHistory.UseVisualStyleBackColor = false;
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = Color.Black;
            btnTransaksi.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransaksi.ForeColor = Color.White;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1598, 77);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 22);
            label1.Name = "label1";
            label1.Size = new Size(283, 38);
            label1.TabIndex = 2;
            label1.Text = "History Transaksi";
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.History_transaksi;
            panel3.Controls.Add(dgvHistory);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(300, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(1598, 1067);
            panel3.TabIndex = 8;
            // 
            // dgvHistory
            // 
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.WhiteSmoke;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.GridColor = Color.WhiteSmoke;
            dgvHistory.Location = new Point(25, 199);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 62;
            dgvHistory.Size = new Size(1550, 633);
            dgvHistory.TabIndex = 0;
            // 
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1144);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormHistory";
            Text = "FormHistory";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button btnHistory;
        private Button btnTransaksi;
        private Button btnAnalisa;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private DataGridView dgvHistory;
    }
}