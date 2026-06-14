namespace projek_PBOSQL.VIEWS
{
    partial class TambahStock
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
            cbPupuk = new ComboBox();
            cbSupplier = new ComboBox();
            txtJumlah = new TextBox();
            txtHarga = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // cbPupuk
            // 
            cbPupuk.BackColor = Color.LightGray;
            cbPupuk.FormattingEnabled = true;
            cbPupuk.Location = new Point(88, 150);
            cbPupuk.Name = "cbPupuk";
            cbPupuk.Size = new Size(206, 33);
            cbPupuk.TabIndex = 0;
            // 
            // cbSupplier
            // 
            cbSupplier.BackColor = Color.LightGray;
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(495, 150);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(203, 33);
            cbSupplier.TabIndex = 1;
            // 
            // txtJumlah
            // 
            txtJumlah.BackColor = Color.LightGray;
            txtJumlah.Location = new Point(287, 245);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(219, 31);
            txtJumlah.TabIndex = 2;
            // 
            // txtHarga
            // 
            txtHarga.BackColor = Color.LightGray;
            txtHarga.Location = new Point(287, 338);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(219, 31);
            txtHarga.TabIndex = 3;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Location = new Point(580, 418);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(108, 34);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Transparent;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Location = new Point(123, 418);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(112, 34);
            btnBatal.TabIndex = 7;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // TambahStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = Properties.Resources.Tambah_Stock;
            ClientSize = new Size(779, 498);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtHarga);
            Controls.Add(txtJumlah);
            Controls.Add(cbSupplier);
            Controls.Add(cbPupuk);
            Name = "TambahStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TambahStock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbPupuk;
        private ComboBox cbSupplier;
        private TextBox txtJumlah;
        private TextBox txtHarga;
        private Button btnSimpan;
        private Button btnBatal;
    }
}