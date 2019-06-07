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
    public partial class FormYonetici : Form
    {
        public FormYonetici()
        {
            InitializeComponent();
        }

       

      
        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            FormOdaEkle F = new FormOdaEkle();
            F.Show();
            this.Close();
        }

        private void rezervasyonListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRezOzet r = new FormRezOzet();
            r.Show();
            this.Close();
        }

        

        private void btnOtelEkle_Click(object sender, EventArgs e)
        {
            MainController m = MainController.GetController();
            try
            {
                m.otel.AddHotel(tbID.Text, tbAd.Text, cmbTİP.SelectedItem.ToString());
            }
            catch
            {
                 MessageBox.Show("Otel Zaten Kayıtlı Veya Bilgilerde Yanlışlık Var!", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
         
            
            
        }

        private void cıkısToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void odaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOdaEkle f = new FormOdaEkle();
            f.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormOdaEkle f = new FormOdaEkle();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainController m = MainController.GetController();
          
            try
            {
                m.otel.DeleteHotel(txtSilID.Text);
            }
            catch
            {
                MessageBox.Show("ID Gecersiz!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bilgileriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBilgiGüncelle b = new FormBilgiGüncelle();
            b.Show();
            this.Close();
        }

        private void sifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSifreDegistir s = new FormSifreDegistir();
            s.Show();
            this.Close();
        }
    }
}
