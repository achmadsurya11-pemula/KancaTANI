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
            pgGambar.Image = (Image)resources.GetObject("pgGambar.Image");
            pgGambar.Location = new Point(90, 15);
            pgGambar.Name = "pgGambar";
            pgGambar.Size = new Size(106, 95);
            pgGambar.SizeMode = PictureBoxSizeMode.StretchImage;
            pgGambar.TabIndex = 0;
            pgGambar.TabStop = false;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(118, 125);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(56, 25);
            lblNama.TabIndex = 1;
            lblNama.Text = "nama";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(22, 167);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(57, 25);
            lblHarga.TabIndex = 2;
            lblHarga.Text = "harga";
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Location = new Point(25, 226);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(54, 25);
            lblStok.TabIndex = 3;
            lblStok.Text = "stock";
            // 
            // nudQty
            // 
            nudQty.Location = new Point(216, 161);
            nudQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQty.Name = "nudQty";
            nudQty.Size = new Size(57, 31);
            nudQty.TabIndex = 4;
            nudQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.AntiqueWhite;
            btnTambah.Location = new Point(216, 255);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(57, 31);
            btnTambah.TabIndex = 5;
            btnTambah.Text = "+ ";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // UC_ItemPupuk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTambah);
            Controls.Add(nudQty);
            Controls.Add(lblStok);
            Controls.Add(lblHarga);
            Controls.Add(lblNama);
            Controls.Add(pgGambar);
            Name = "UC_ItemPupuk";
            Size = new Size(297, 311);
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
