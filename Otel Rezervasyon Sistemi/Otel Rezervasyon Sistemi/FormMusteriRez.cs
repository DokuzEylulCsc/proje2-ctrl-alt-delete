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
            listBoxUygunOteller.Items.Clear();
            MainController c = MainController.GetController();

             try
            {
                listBoxUygunOteller.Items.AddRange(c.filter.HotelFilter(cmboteltip.SelectedItem.ToString(), cmbodatip.SelectedItem.ToString(), Convert.ToInt32(cmbyıldız.SelectedItem), Convert.ToInt32(txtminfiyat.Text), Convert.ToInt32(txtmaxfiyat.Text), chcwifi.Checked, chcminibar.Checked, chcklima.Checked, chcTv.Checked, mcbaslangic.SelectionRange.Start.Date, mcbitis.SelectionRange.Start.Date).ToArray());
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void bilgileriGüncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBilgiGüncelle f = new FormBilgiGüncelle();
            this.Hide();
            f.Show();
           

        }

        private void sifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSifreDegistir s = new FormSifreDegistir();
            this.Hide();
            s.Show();
           

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
                MainController.GetController().SerializeAtEnd();
                Application.Exit();
            }
        }

        private void btnRezSil_Click(object sender, EventArgs e)
        {
            MainController m = MainController.GetController();
            try
            {
                if(m.user.DeleteActiveReservation(lbluserid.Text, listBox1.SelectedItem.ToString()))
                {
                    MessageBox.Show("Rezervasyon Basari ile silindi");
                }
            }catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
            
         }
        private void FormMusteriRez_Load(object sender, EventArgs e)
        {

            lbluserid.Text = FormLogin.kullaniciID;
        }

        private void btnRezYap_Click(object sender, EventArgs e)
        {
            MainController m = MainController.GetController();
            try
            {
                if (m.ReservationController.ReserveRoom(FormLogin.kullaniciID,listBoxUygunOteller.SelectedItem.ToString() ,mcbaslangic.SelectionStart, mcbitis.SelectionStart))
                {
                    MessageBox.Show("Rezervasyon Basarili", "Tebrikler");
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnRezListele_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            MainController m = MainController.GetController();
            try
            {
                listBox1.Items.AddRange(m.user.ShowActiveReservationsOfCustomer(lbluserid.Text).ToArray());
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainController m = MainController.GetController();
            m.user.ShowOldReservationsOfCustomer(lbluserid.Text);
        }
    }
}

