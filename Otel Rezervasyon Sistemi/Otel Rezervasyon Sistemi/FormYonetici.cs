﻿using System;
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
    public partial class FormYonetici : Form
    {
        public FormYonetici()
        {
            InitializeComponent();
        }

       

        private void btnTemizle_Click(object sender, EventArgs e)
        {
           
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

        private void FormYonetici_Load(object sender, EventArgs e)
        {

        }
    }
}
