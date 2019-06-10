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
            this.Hide();
            Fl.Show();
            ;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            MainController controller = MainController.GetController();
            try
            {

                
               if(controller.user.CreateAccountRequest(txtID.Text, mSIFRE.Text, mSIFRET.Text, TXTAD.Text, TXTSOYAD.Text))
                {
                    MessageBox.Show("Kayit Tamamlandi", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



       
    }
}
