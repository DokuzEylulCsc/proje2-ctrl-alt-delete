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

        
<<<<<<< HEAD

<<<<<<< HEAD

        }



        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = txtid.Text;
            string ad = txta.Text;
            string soyad = txts.Text;
            MainController c = MainController.GetController();
          //  Kullanici k = new Kullanici(ID, ad, soyad);
          //  c.user.ChangeInformationRequest(k,Convert.ToString( listBox1.SelectedItem), txtgüncel.Text);
        }
=======
      
>>>>>>> parent of ab87a31... Formlarda Değişiklikler Yapıldı
=======

      
>>>>>>> parent of ab87a31... Formlarda Değişiklikler Yapıldı

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormMusteriRez m = new FormMusteriRez();
            m.Show();
            this.Close();

        }

        private void btnDeğiştir_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD


            string ID =  MSKıd.Text;
            string Sifre = mskSifre.Text;
            string Güncel = txtgüncel.Text;

            MainController c = MainController.GetController();
            try
            {
                if (chcAd.Checked == true)
                {
                    c.user.ChangeInformationRequest(ID, Sifre, chcAd.Text, Güncel);
                }
                if (chcSoyad.Checked == true)
                {
                    c.user.ChangeInformationRequest(ID, Sifre, chcSoyad.Text, Güncel);
                }
            }
            catch
            {

                MessageBox.Show("Bilgilerde Hata Var", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           






=======
            string ID = txtid.Text;
            string ad = txta.Text;
            string soyad = txts.Text;
            MainController c = MainController.GetController();
            //  Kullanici k = new Kullanici(ID, ad, soyad);
            //  c.user.ChangeInformationRequest(k,Convert.ToString( listBox1.SelectedItem), txtgüncel.Text);
>>>>>>> parent of ab87a31... Formlarda Değişiklikler Yapıldı
=======
            string ID = txtid.Text;
            string ad = txta.Text;
            string soyad = txts.Text;
            MainController c = MainController.GetController();
            //  Kullanici k = new Kullanici(ID, ad, soyad);
            //  c.user.ChangeInformationRequest(k,Convert.ToString( listBox1.SelectedItem), txtgüncel.Text);
>>>>>>> parent of ab87a31... Formlarda Değişiklikler Yapıldı
        }
    }
}
