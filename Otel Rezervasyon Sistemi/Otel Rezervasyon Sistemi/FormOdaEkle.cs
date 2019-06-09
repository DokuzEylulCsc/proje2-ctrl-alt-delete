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

        private void otelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOdaEkle O = new FormOdaEkle();
            O.Show();
            this.Close();
        }

      
       

      
        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                MainController.GetController().SerializeAtEnd();
                this.Close();
                Application.Exit();
            }
        }

        private void FormOdaEkle_Load(object sender, EventArgs e)
        {
            FormYonetici y = new FormYonetici();
            lblyon.Text = y.lblyonid.Text;
            lblotelid.Text = y.tbID.Text;
       
        }

        private void BtnİslemdekiKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                MainController m = MainController.GetController();
              if(  m.room.AddRoomRequest(Convert.ToString(cmbislemdekit.SelectedIndex),Convert.ToInt32( txtislemdekifiyat.Text) ,lblyon.Text, lblotelid.Text, Convert.ToInt32(txtislemdekino.Text),
                Convert.ToInt32(cmbkisikapaislemdeki.SelectedItem),chcİklima.Checked,chcİtv.Checked,chcİminibar.Checked,chcİwifi.Checked))
                {
                    MessageBox.Show("Oda Kaydedildi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                   
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            


            
        }

       

        private void btnKayitliKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                MainController m = MainController.GetController();
                if (m.room.AddRoomRequest(Convert.ToString(cmbOdatipi.SelectedItem), Convert.ToInt32(tbFiyat.Text),
                    FormLogin.yoneticiID, tbOdaEkleID.Text, Convert.ToInt32(txtOdano.Text), Convert.ToInt32(CmbKisi.SelectedItem),chcklima.Checked,chcTv.Checked,chcminibar.Checked,chcwifi.Checked)) 
                {
                    MessageBox.Show("Oda Kaydedildi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormYonetici f = new FormYonetici();
            this.Hide();
            f.Show();
          
        }

       
    }
}
