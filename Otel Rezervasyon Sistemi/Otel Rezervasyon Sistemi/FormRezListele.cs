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
    public partial class FormRezOzet : Form
    {
        public FormRezOzet()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormYonetici y = new FormYonetici();
            this.Hide();
            y.Show();
           

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

    }
}

