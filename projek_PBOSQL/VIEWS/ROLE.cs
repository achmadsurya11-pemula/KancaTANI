using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class ROLE : Form
    {
        public ROLE()
        {
            InitializeComponent();
        }

        private void ROLE_Load(object sender, EventArgs e)
        {
            var koneksi = projek_PBOSQL.HELPERS.ConnectDB.GetConn();

            if (koneksi != null && koneksi.State == System.Data.ConnectionState.Open)
            {
                koneksi.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }
    }
}