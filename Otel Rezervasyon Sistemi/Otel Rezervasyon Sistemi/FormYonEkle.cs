using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otel_Rezervasyon_Sistemi.Controllers;

namespace Otel_Rezervasyon_Sistemi
{
    public partial class FormYonEkle : Form
    {
        public FormYonEkle()
        {
            InitializeComponent();
        }

        private void FormYonEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormYonetici y = new FormYonetici();
            this.Hide();
            y.Show();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            MainController m = MainController.GetController();
            try
            {
                m.user.CreateAccountRequest(mID.Text, mSIFRE.Text, mSIFRET.Text, TXTAD.Text, TXTSOYAD.Text);
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void FormYonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainController.GetController().SerializeAtEnd();
            this.Close();
            Application.Exit();
        }
    }
}
