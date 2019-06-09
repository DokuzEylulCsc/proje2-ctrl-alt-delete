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
           FormMusteriRez L = new FormMusteriRez();
            this.Hide();
            L.Show();
           

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            MainController controller = MainController.GetController();
           
            try
            {
                if( controller.user.ChangePasswordRequest(mskID.Text,mskEskiSifre.Text,mskYeniSifre.Text,mskSifreTekrari.Text))
                {
                    MessageBox.Show("Sifreniz Güncellendi", "TEBRİKLER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception a) 
            {
                MessageBox.Show(a.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }

      

        private void FormSifreDegistir_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

       

       
    }
}
