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
        protected struct Rezervasyon
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
        
        protected int odano;
        protected int kisikapasitesi;
        protected int odafiyati;
        protected bool klimali;
        protected bool minibarli;
        protected bool televizyonlu;
        protected bool wifili;
    }
}
