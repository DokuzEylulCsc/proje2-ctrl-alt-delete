using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    abstract class Oda
    {
        public Oda(int fiyat,int kisikapasite,int odanumarasi,bool klima,bool wifi,bool minibar,bool televizyon )
        {
            odafiyati = fiyat;
            kisikapasitesi = kisikapasite;
            odano = odanumarasi;
            klimali = klima;
            wifili = wifi;
            minibarli = minibar;
            televizyonlu = televizyon;
        }
        struct Rezervasyon
        {
            DateTime rezbaslangic;
            DateTime rezbitis;
            DateTime RezBaslangic
            {
                get { return rezbaslangic; }
                set { rezbaslangic = value; }
            }
            DateTime RezBitis
            {
                get { return rezbitis; }
                set { rezbitis = value; }
            }
        }
        
        public int odano;
        public int kisikapasitesi;
        public int odafiyati;
        public bool klimali;
        public bool minibarli;
        public bool televizyonlu;
        public bool wifili;
    }
}
