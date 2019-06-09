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

        public static int IDGenerator = 0;

        [XmlElement("RezervasyonID")]
        private int rezID;
        public int RezID
        {
            get { return rezID; }
            set { rezID = value; }
        }

        public Rezervasyon(DateTime rezbaslangic,DateTime rezbitis,string whichotelid,int whichroomnumber)
        {
            this.rezbaslangic = rezbaslangic;
            this.rezbitis = rezbitis;
            Rezervasyon.IDGenerator++;
            this.RezID = Rezervasyon.IDGenerator;
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
