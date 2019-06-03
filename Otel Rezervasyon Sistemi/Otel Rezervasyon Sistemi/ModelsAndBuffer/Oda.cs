using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Otel_Rezervasyon_Sistemi
{
    [XmlInclude(typeof(StandartOda))]
    [XmlInclude(typeof(ManzaraliOda))]
    [XmlInclude(typeof(KralDairesi))]
    [Serializable]
    abstract public class Oda
    {
        protected Oda()
        {

        }

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
        
        [XmlElement("OdaNumarasi")]
        protected int odano;
        public int OdaNo
        {
            get { return odano; }
            set { odano = value; }
        }

        [XmlElement("KisiKapasitesi")]
        protected int kisikapasitesi;
        public int KisiKapasitesi
        {
            get { return kisikapasitesi; }
            set { kisikapasitesi = value; }
        }

        [XmlElement("OdaFiyati")]
        protected int odafiyati;
        public int OdaFiyati
        {
            get { return odafiyati; }
            set { odafiyati = value; }
        }

        [XmlElement("Klimali")]
        protected bool klimali;
        public bool Klimali
        {
            get { return klimali; }
            set { klimali = value; }
        }

        [XmlElement("Minibarli")]
        protected bool minibarli;
        public bool Minibarli
        {
            get { return minibarli; }
            set { minibarli = value; }
        }

        [XmlElement("Televizyonlu")]
        protected bool televizyonlu;
        public bool Televizyonlu
        {
            get { return televizyonlu; }
            set { televizyonlu = value; }
        }

        [XmlElement("Wifili")]
        protected bool wifili;
        public bool Wifili
        {
            get { return wifili; }
            set { wifili = value; }
        }

    }
}
