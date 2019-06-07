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
    public partial class FormBilgiGüncelle : Form
    {
        public FormBilgiGüncelle()
        {
            InitializeComponent();
        }

        
      


      


        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormMusteriRez m = new FormMusteriRez();
            m.Show();
            this.Close();

        }

        private void btnDeğiştir_Click(object sender, EventArgs e)
        {
            
            string ID = mskID .Text;
            string SIFRE = mskSIFRE.Text;
            string GUNCEL = txtgüncel.Text;
            MainController c = MainController.GetController();
            try
            {
                if (checkAd.Checked == true)
                {
                    c.user.ChangeInformationRequest(ID, SIFRE, checkAd.Text, GUNCEL);
                }
                if (checkSoyad.Checked == true)
                {
                    c.user.ChangeInformationRequest(ID, SIFRE, checkSoyad.Text, GUNCEL);
                }

            }
            catch
            {
                MessageBox.Show("Girilen Bilgiler Uygun Değil TEKRAR DENEYİNİZ!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
               

        }
    }
}
