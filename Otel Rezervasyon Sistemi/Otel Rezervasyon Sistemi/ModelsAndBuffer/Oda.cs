using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Otel_Rezervasyon_Sistemi.ModelsAndBuffer
{
    [XmlInclude(typeof(StandartOda))]
    [XmlInclude(typeof(ManzaraliOda))]
    [XmlInclude(typeof(KralDairesi))]
    [Serializable]
    abstract public class Oda
    {
        public Oda()
        {
            // Xml islemleri icin bir bos yapıcı metoda ihtiyac duyuluyor bu yuzden tanımlandı. Ancak kullanıcının parametresiz oda yaratmasını engelleyebilmek
            // icin protected olarak tanımladık.
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

        [XmlElement("Rezervasyon")]
        private List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();      
        public List<Rezervasyon> Rezervasyonlar
        {
            get { return rezervasyonlar; }
            set { rezervasyonlar = value; }
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
