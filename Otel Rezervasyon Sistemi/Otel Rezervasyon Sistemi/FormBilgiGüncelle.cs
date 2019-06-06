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
            string ID = txtid.Text;
            string ad = txta.Text;
            string soyad = txts.Text;
          
            MainController c = MainController.GetController();
            if (chckad.Checked==true)
            {
                  c.user.ChangeInformationRequest(ID,txtSifre.Text,chckad.Text, txtgüncel.Text);
            }
            if(chcksoyad .Checked==true)
            {
                c.user.ChangeInformationRequest(ID, txtSifre.Text, chcksoyad.Text, txtgüncel.Text);
               
            }



        }
    }
}
