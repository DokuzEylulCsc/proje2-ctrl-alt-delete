﻿using System;
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

            // c.filter.HotelFilter(cmboteltip.SelectedItem.ToString(),cmbodatip.SelectedItem.ToString(),Convert.ToInt32( cmbyıldız.SelectedItem), Convert.ToInt32(txtminfiyat.Text), Convert.ToInt32(txtmaxfiyat.Text),chcwifi.Checked,chcminibar.Checked,chcklima.Checked,chcTv.Checked,mcbaslangic.SelectionRange.Start,mcbitis.SelectionRange.End);
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

        
    }
}

