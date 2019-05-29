using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Rezervasyon_Sistemi
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
         
        private void lblkullaniciad_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        

        private void linklbluyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUyeOl F = new FormUyeOl();
            F.Show();
            this.Close();
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            txtID.Clear();
            txtSifree.Clear();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Controllers.UserController u = new Controllers.UserController();
            u.AccountVerification(txtID.Text,txtSifree.Text);
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
