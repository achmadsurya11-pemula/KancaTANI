namespace projek_PBOSQL.VIEWS
{
    partial class TambahPupuk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahPupuk));
            txtNamaPupuk = new TextBox();
            txtHarga = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // txtNamaPupuk
            // 
            txtNamaPupuk.Location = new Point(197, 122);
            txtNamaPupuk.Margin = new Padding(2, 2, 2, 2);
            txtNamaPupuk.Multiline = true;
            txtNamaPupuk.Name = "txtNamaPupuk";
            txtNamaPupuk.Size = new Size(190, 29);
            txtNamaPupuk.TabIndex = 0;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(197, 176);
            txtHarga.Margin = new Padding(2, 2, 2, 2);
            txtHarga.Multiline = true;
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(190, 29);
            txtHarga.TabIndex = 1;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.DodgerBlue;
            btnSimpan.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = SystemColors.ButtonHighlight;
            btnSimpan.Location = new Point(307, 225);
            btnSimpan.Margin = new Padding(2, 2, 2, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(78, 20);
            btnSimpan.TabIndex = 2;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = SystemColors.ButtonHighlight;
            btnBatal.Location = new Point(197, 225);
            btnBatal.Margin = new Padding(2, 2, 2, 2);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(78, 20);
            btnBatal.TabIndex = 3;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // TambahPupuk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.formAddPupuk;
            ClientSize = new Size(560, 304);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtHarga);
            Controls.Add(txtNamaPupuk);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "TambahPupuk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TambahPupuk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNamaPupuk;
        private TextBox txtHarga;
        private Button btnSimpan;
        private Button btnBatal;
    }
}