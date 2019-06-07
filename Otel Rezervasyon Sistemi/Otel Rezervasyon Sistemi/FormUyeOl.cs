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
    public partial class FormUyeOl : Form
    {
        public FormUyeOl()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormLogin Fl = new FormLogin();
            Fl.Show();
            this.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            
            try
            {
                MainController controller = MainController.GetController();
                string gecici = mskıd.Text;
                string ad = TXTAD.Text;
                string soyad = TXTSOYAD.Text;
                string sifre = msksifre.Text;
                string sifre2 = msksifre2.Text;


                controller.user.CreateAccountRequest(gecici, sifre, sifre2, ad, soyad);
                
                
            }
            catch
            {
                MessageBox.Show("Kayıt Edilmek İstenen Kullanicinin Bilgileri Uygun Değildir!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
