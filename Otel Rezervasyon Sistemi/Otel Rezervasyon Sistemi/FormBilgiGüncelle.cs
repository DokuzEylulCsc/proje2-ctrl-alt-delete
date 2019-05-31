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

        private void FormBilgiGüncelle_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = txtid.Text;
            string ad = txta.Text;
            string soyad = txts.Text;
            MainController c = MainController.GetController();
          //  Kullanici k = new Kullanici(ID, ad, soyad);
          ,//  c.user.ChangeInformationRequest(k,Convert.ToString( listBox1.SelectedItem), txtgüncel.Text);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormMusteriRez m = new FormMusteriRez();
            m.Show();
            this.Close();

        }
    }
}
