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
            MainController controller = MainController.GetController();
            try
            {

                controller.user.CreateAccountRequest(mID.Text, mSIFRE.Text, mSIFRET.Text,TXTAD.Text,TXTSOYAD.Text);
               
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
