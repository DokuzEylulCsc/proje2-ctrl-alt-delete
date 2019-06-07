using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Otel_Rezervasyon_Sistemi.ModelsAndBuffer
{
    [Serializable]
    public class Rezervasyon
    {
        private Rezervasyon()
        {
            // Xml serilestirme islemi yapabilmek icin bir adet bos yapıcı metot gerekli.
        }

        public Rezervasyon(DateTime rezbaslangic,DateTime rezbitis)
        {
            this.rezbaslangic = rezbaslangic;
            this.rezbitis = rezbitis;
        }

        [XmlElement("RezervasyonBaslangic")]
        private DateTime rezbaslangic;
        public DateTime RezBaslangic
        {
            get { return rezbaslangic; }
            set { rezbaslangic = value; }
        }

        [XmlElement("RezervasyonBitis")]
        private DateTime rezbitis;
        public DateTime RezBitis
        {
            get { return rezbitis; }
            set { rezbitis = value; }
        }
    }
}
