namespace projek_PBOSQL.VIEWS
{
    partial class FormResi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResi));
            lblTanggal = new Label();
            lblMetode = new Label();
            lblTotal = new Label();
            lblBayar = new Label();
            lblKembalian = new Label();
            btnTutup = new Button();
            lstItemBelanja = new ListBox();
            SuspendLayout();
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(22, 229);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(33, 25);
            lblTanggal.TabIndex = 0;
            lblTanggal.Text = "tgl";
            // 
            // lblMetode
            // 
            lblMetode.AutoSize = true;
            lblMetode.Location = new Point(22, 281);
            lblMetode.Name = "lblMetode";
            lblMetode.Size = new Size(74, 25);
            lblMetode.TabIndex = 1;
            lblMetode.Text = "metode";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(157, 640);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(48, 25);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "total";
            // 
            // lblBayar
            // 
            lblBayar.AutoSize = true;
            lblBayar.Location = new Point(22, 684);
            lblBayar.Name = "lblBayar";
            lblBayar.Size = new Size(56, 25);
            lblBayar.TabIndex = 3;
            lblBayar.Text = "bayar";
            // 
            // lblKembalian
            // 
            lblKembalian.AutoSize = true;
            lblKembalian.Location = new Point(22, 731);
            lblKembalian.Name = "lblKembalian";
            lblKembalian.Size = new Size(93, 25);
            lblKembalian.TabIndex = 4;
            lblKembalian.Text = "kembalian";
            // 
            // btnTutup
            // 
            btnTutup.BackColor = Color.IndianRed;
            btnTutup.FlatAppearance.BorderColor = Color.IndianRed;
            btnTutup.FlatAppearance.BorderSize = 0;
            btnTutup.ForeColor = Color.WhiteSmoke;
            btnTutup.Location = new Point(337, 2);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(38, 31);
            btnTutup.TabIndex = 5;
            btnTutup.Text = "x";
            btnTutup.UseVisualStyleBackColor = false;
            // 
            // lstItemBelanja
            // 
            lstItemBelanja.FormattingEnabled = true;
            lstItemBelanja.Location = new Point(22, 353);
            lstItemBelanja.Name = "lstItemBelanja";
            lstItemBelanja.Size = new Size(343, 254);
            lstItemBelanja.TabIndex = 6;
            // 
            // FormResi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(387, 803);
            Controls.Add(lstItemBelanja);
            Controls.Add(btnTutup);
            Controls.Add(lblKembalian);
            Controls.Add(lblBayar);
            Controls.Add(lblTotal);
            Controls.Add(lblMetode);
            Controls.Add(lblTanggal);
            Name = "FormResi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormResi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTanggal;
        private Label lblMetode;
        private Label lblTotal;
        private Label lblBayar;
        private Label lblKembalian;
        private Button btnTutup;
        private ListBox lstItemBelanja;
    }
}