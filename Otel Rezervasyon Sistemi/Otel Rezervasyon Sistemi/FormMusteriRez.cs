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
    public partial class FormMusteriRez : Form
    {
        public FormMusteriRez()
        {
            InitializeComponent();
        }

        private void BtnRezAra_Click(object sender, EventArgs e)
        {
            MainController c = MainController.GetController();
          //  c.reservation.
          
        }

        private void bilgileriGüncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBilgiGüncelle f = new FormBilgiGüncelle();
            f.Show();
            this.Close();

        }

        private void sifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSifreDegistir s = new FormSifreDegistir();
            s.Show();
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

