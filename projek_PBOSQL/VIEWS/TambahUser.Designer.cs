namespace projek_PBOSQL.VIEWS
{
    partial class TambahUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahUser));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtNoTelp = new TextBox();
            Simpan = new Button();
            RbAdmin = new RadioButton();
            RbPetani = new RadioButton();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(425, 131);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(190, 24);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(425, 218);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(190, 24);
            txtPassword.TabIndex = 1;
            // 
            // txtNoTelp
            // 
            txtNoTelp.BackColor = Color.White;
            txtNoTelp.BorderStyle = BorderStyle.None;
            txtNoTelp.Location = new Point(425, 302);
            txtNoTelp.Margin = new Padding(4);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.Size = new Size(190, 24);
            txtNoTelp.TabIndex = 2;
            // 
            // Simpan
            // 
            Simpan.BackColor = Color.Transparent;
            Simpan.FlatAppearance.BorderSize = 0;
            Simpan.FlatStyle = FlatStyle.Flat;
            Simpan.Location = new Point(328, 434);
            Simpan.Margin = new Padding(4);
            Simpan.Name = "Simpan";
            Simpan.Size = new Size(196, 38);
            Simpan.TabIndex = 3;
            Simpan.UseVisualStyleBackColor = false;
            Simpan.Click += Simpan_Click;
            // 
            // RbAdmin
            // 
            RbAdmin.AutoSize = true;
            RbAdmin.BackColor = Color.Transparent;
            RbAdmin.Location = new Point(425, 374);
            RbAdmin.Margin = new Padding(4);
            RbAdmin.Name = "RbAdmin";
            RbAdmin.Size = new Size(90, 29);
            RbAdmin.TabIndex = 4;
            RbAdmin.TabStop = true;
            RbAdmin.Text = "Admin";
            RbAdmin.UseVisualStyleBackColor = false;
            // 
            // RbPetani
            // 
            RbPetani.AutoSize = true;
            RbPetani.BackColor = Color.Transparent;
            RbPetani.Location = new Point(571, 374);
            RbPetani.Margin = new Padding(4);
            RbPetani.Name = "RbPetani";
            RbPetani.Size = new Size(84, 29);
            RbPetani.TabIndex = 5;
            RbPetani.TabStop = true;
            RbPetani.Text = "Petani";
            RbPetani.UseVisualStyleBackColor = false;
            // 
            // TambahUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tambah_Akun2;
            ClientSize = new Size(777, 502);
            Controls.Add(RbPetani);
            Controls.Add(RbAdmin);
            Controls.Add(Simpan);
            Controls.Add(txtNoTelp);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "TambahUser";
            Text = "TambahUser";
            Load += TambahUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtNoTelp;
        private Button Simpan;
        private RadioButton RbAdmin;
        private RadioButton RbPetani;
    }
}