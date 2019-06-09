using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Otel_Rezervasyon_Sistemi.ModelsAndBuffer
{
    [XmlInclude(typeof(Yonetici))]
    [XmlInclude(typeof(Musteri))]
    [Serializable]
    abstract public class Kullanici
    {
        public Kullanici()
        {
            // Xml islemleri icin gereken bos yapıcı metot.
        }

        public Kullanici(string ID, string isim, string soyisim,string sifre)
        {
            id = ID;
            ad = isim;
            soyad = soyisim;
            this.sifre = sifre;          
        }

        [XmlElement("KullaniciID")]
        protected string id;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        [XmlElement("KullaniciAd")]
        protected string ad;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        [XmlElement("KullaniciSoyad")]
        protected string soyad;
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }

        [XmlElement("KullaniciSifre")]
        protected string sifre;
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
       
    }
}
