namespace projek_PBOSQL.VIEWS
{
    partial class UC_ItemPupuk
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ItemPupuk));
            pgGambar = new PictureBox();
            lblNama = new Label();
            lblHarga = new Label();
            lblStok = new Label();
            nudQty = new NumericUpDown();
            btnTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)pgGambar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQty).BeginInit();
            SuspendLayout();
            // 
            // pgGambar
            // 
            pgGambar.BackColor = Color.Transparent;
            pgGambar.Image = (Image)resources.GetObject("pgGambar.Image");
            pgGambar.Location = new Point(122, 42);
            pgGambar.Name = "pgGambar";
            pgGambar.Size = new Size(158, 167);
            pgGambar.SizeMode = PictureBoxSizeMode.StretchImage;
            pgGambar.TabIndex = 0;
            pgGambar.TabStop = false;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = Color.Transparent;
            lblNama.ForeColor = Color.White;
            lblNama.Location = new Point(172, 246);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(56, 25);
            lblNama.TabIndex = 1;
            lblNama.Text = "nama";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.BackColor = Color.Transparent;
            lblHarga.ForeColor = Color.White;
            lblHarga.Location = new Point(116, 301);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(57, 25);
            lblHarga.TabIndex = 2;
            lblHarga.Text = "harga";
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.BackColor = Color.Transparent;
            lblStok.ForeColor = Color.White;
            lblStok.Location = new Point(119, 357);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(54, 25);
            lblStok.TabIndex = 3;
            lblStok.Text = "stock";
            // 
            // nudQty
            // 
            nudQty.Location = new Point(321, 204);
            nudQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQty.Name = "nudQty";
            nudQty.Size = new Size(57, 31);
            nudQty.TabIndex = 4;
            nudQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Olive;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(336, 374);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(42, 57);
            btnTambah.TabIndex = 5;
            btnTambah.Text = "+ ";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // UC_ItemPupuk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btnTambah);
            Controls.Add(nudQty);
            Controls.Add(lblStok);
            Controls.Add(lblHarga);
            Controls.Add(lblNama);
            Controls.Add(pgGambar);
            Name = "UC_ItemPupuk";
            Size = new Size(400, 450);
            ((System.ComponentModel.ISupportInitialize)pgGambar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pgGambar;
        private Label lblNama;
        private Label lblHarga;
        private Label lblStok;
        private NumericUpDown nudQty;
        private Button btnTambah;
    }
}
