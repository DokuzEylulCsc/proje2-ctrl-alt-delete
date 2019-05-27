using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    class Oda
    {
        public int odafiyati;
        public int odanumarasi;
        public int kisikapasitesi;
        public bool klimali;
        public bool wifili;
        public bool televizyonlu;
        public bool minibarli;

        public int OdaFiyati
        {
            get { return odafiyati; }
            set { odafiyati = value; }
        }
        public int OdaNumarasi
        {
            get { return odanumarasi; }
            set { odanumarasi = value; }
        }
        public int KisiKapasitesi
        {
            get { return kisikapasitesi; }
            set { kisikapasitesi= value; }
        }
        public bool Klimali 
        {
            get { return klimali; }
            set { klimali = value; }
        }
        public bool Wifili
        {
            get { return wifili; }
            set { wifili = value; }
        }
        public bool Minibarli
        {
            get { return minibarli; }
            set { minibarli = value; }
        }
        public bool Televizyonlu
        {
            get { return televizyonlu; }
            set { televizyonlu = value; }
        }


        public Oda(int OdaFiyat,int OdaNo,int Kapasite,bool klima,bool wifi,bool tv,bool minibar)
        {
            odafiyati = OdaFiyat;
            odanumarasi = OdaNo;
            kisikapasitesi = Kapasite;
            klimali = klima;
            wifili = wifi;
            televizyonlu = tv;
            minibarli = minibar;
        }



    }
}
