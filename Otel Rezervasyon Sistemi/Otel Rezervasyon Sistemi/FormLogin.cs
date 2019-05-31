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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtSifre.Clear();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
           
            try
            {
                MainController controller = MainController.GetController();
                Kullanici a = controller.user.AccountVerification(txtID.Text, txtSifre.Text);
                if(a is Musteri)
                {
                    FormMusteriRez F = new FormMusteriRez();
                    F.Show();
                    this.Close();

                }
                else
                {
                    FormYonetici y = new FormYonetici();
                    y.Show();
                    this.Close();
                    
                }
               

            }
            catch
            {
                MessageBox.Show("Kullanıcı Bulunamadı!!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUyeOl f = new FormUyeOl();
            f.Show();
            this.Close();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        
    }
}
