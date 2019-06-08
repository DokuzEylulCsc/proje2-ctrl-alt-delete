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
    public partial class FormSifreDegistir : Form
    {
        public FormSifreDegistir()
        {
            InitializeComponent();
        }

        private void btnGERİ_Click(object sender, EventArgs e)
        {
            FormLogin L = new FormLogin();
            L.Show();
            this.Close();

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            MainController controller = MainController.GetController();
            string ad = txtsdAd.Text;
            string soyad = txtsdSoyad.Text;
            string ID = mskID.Text;
            string sifre = mskSifre.Text;
            string sifretekrari = mskSifreTekrari.Text;
            try
            {
                //Kullanici k = new Kullanici(ID,ad,soyad);
                //controller.user.ChangePasswordRequest(k, sifre, sifretekrari);
            }
            catch(Exception a) 
            {
                MessageBox.Show(a.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }

        
    }
}
