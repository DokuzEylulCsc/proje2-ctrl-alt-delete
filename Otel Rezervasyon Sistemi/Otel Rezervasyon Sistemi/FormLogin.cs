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
using Otel_Rezervasyon_Sistemi.ModelsAndBuffer;
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
            mskID.Clear();
            MSKSİFRE.Clear();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
           
            try
            {
                MainController controller = MainController.GetController();
                Kullanici a = controller.user.AccountVerification(mskID.Text,MSKSİFRE.Text);
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
            catch(Exception a)
            {
                MessageBox.Show(a.Message,"UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUyeOl f = new FormUyeOl();
            f.Show();
            this.Hide();
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Otel_Rezervasyon_Sistemi.ModelsAndBuffer.Buffer b = Otel_Rezervasyon_Sistemi.ModelsAndBuffer.Buffer.BUF;
            b.Serialization();
            b.Deserialization();
        }
    }
}
