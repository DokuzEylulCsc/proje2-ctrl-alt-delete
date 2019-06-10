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

             try
            {
                listBoxUygunOteller.Items.AddRange(c.filter.HotelFilter(cmboteltip.SelectedItem.ToString(), cmbodatip.SelectedItem.ToString(), Convert.ToInt32(cmbyıldız.SelectedItem), Convert.ToInt32(txtminfiyat.Text), Convert.ToInt32(txtmaxfiyat.Text), chcwifi.Checked, chcminibar.Checked, chcklima.Checked, chcTv.Checked, mcbaslangic.SelectionRange.Start.Date, mcbitis.SelectionRange.Start.Date).ToArray());
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            listBoxUygunOteller.Items.Clear();
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
            m.user.DeleteActiveReservation(lbluserid.Text, listBox1.SelectedItem.ToString());
         }
        private void FormMusteriRez_Load(object sender, EventArgs e)
        {

            lbluserid.Text = FormLogin.kullaniciID;
        }

        private void btnRezYap_Click(object sender, EventArgs e)
        {
            MainController m = MainController.GetController();
            int reservationID = Convert.ToInt32(((listBoxUygunOteller.SelectedItem.ToString().Split('-'))[0].Split(':'))[1]);
            string otelID = (((listBoxUygunOteller.SelectedItem.ToString() .Split('-'))[1]).Split(':'))[1];
            int odaNo = Convert.ToInt32((((listBoxUygunOteller.SelectedItem.ToString().Split('-'))[2]).Split(':'))[1]);
            try
            {
                if (m.ReservationController.CheckReservationDateAvailabilty(otelID, odaNo, mcbaslangic.SelectionRange.Start.Date, mcbitis.SelectionRange.End.Date))
                {
                    m.ReservationController.ReserveRoom(lbluserid.Text, otelID, odaNo, mcbaslangic.SelectionRange.Start.Date, mcbitis.SelectionRange.End.Date);
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnRezListele_Click(object sender, EventArgs e)
        {
            MainController m = MainController.GetController();
            m.user.ShowActiveReservationsOfCustomer(lbluserid.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainController m = MainController.GetController();
            m.user.ShowOldReservationsOfCustomer(lbluserid.Text);
        }
    }
}

