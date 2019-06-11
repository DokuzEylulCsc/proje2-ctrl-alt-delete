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
        public Rezervasyon()
        {
            // Xml serilestirme islemi yapabilmek icin bir adet bos yapıcı metot gerekli.
        }

        

        [XmlElement("RezervasyonID")]
        private int rezID;
        public int RezID
        {
            get { return rezID; }
            set { rezID = value; }
        }

        public Rezervasyon(DateTime rezbaslangic,DateTime rezbitis,string whichotelid,int whichroomnumber)
        {
            Random r = new Random();
            this.rezbaslangic = rezbaslangic;
            this.rezbitis = rezbitis;
            this.RezID = r.Next(0, 10) + r.Next(0, 10)*10 + r.Next(0, 10)*100 + r.Next(0, 10)*1000 + r.Next(0,10)*10000;
            this.rezotelid= whichotelid;
            this.rezodanumarasi = whichroomnumber;
        }

        [XmlElement("RezervasyonOteliID")]
        private string rezotelid;
        public string RezOtelID
        {
            get { return rezotelid; }
            set { rezotelid = value; }
        }

        [XmlElement("RezervasyonOdaNumarasi")]
        private int rezodanumarasi;
        public int RezOdaNumarasi
        {
            get { return rezodanumarasi; }
            set { rezodanumarasi = value; }
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
