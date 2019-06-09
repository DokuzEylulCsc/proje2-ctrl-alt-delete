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
            this.Hide();
            m.Show();
           

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
                   if( c.user.ChangeInformationRequest(ID, SIFRE, checkAd.Text, GUNCEL))
                    {
                        MessageBox.Show("Ad Bilginiz Güncellendi", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (checkSoyad.Checked == true)
                {
                   if( c.user.ChangeInformationRequest(ID, SIFRE, checkSoyad.Text, GUNCEL))
                    {
                        MessageBox.Show("Soyad Bilginiz Güncellendi", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Girilen Bilgiler Uygun Değil TEKRAR DENEYİNİZ!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
               

        }

    

       
    }
}
