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
    public partial class FormOdaEkle : Form
    {
        public FormOdaEkle()
        {
            InitializeComponent();
        }

        private void checkIslemde_CheckedChanged(object sender, EventArgs e)
        {
            panelIslemde.Visible = true;
            panelKayitli.Visible = false;
        }

        private void checkKayitli_CheckedChanged(object sender, EventArgs e)
        {
            panelIslemde.Visible = false;
            panelKayitli.Visible = true;

        }

        private void panelKayitli_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void otelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOdaEkle O = new FormOdaEkle();
            O.Show();
            this.Close();
        }

        private void rezervasyonListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbOdaEkleID.Clear();
            tbFiyat.Clear();
            tbOdaEkleAd.Clear();
            cmbOdano.Clear();
            
        }
    }
}
