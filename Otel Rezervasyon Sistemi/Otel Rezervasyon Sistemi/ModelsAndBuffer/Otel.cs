using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Otel_Rezervasyon_Sistemi.ModelsAndBuffer
{
    [XmlInclude(typeof(Pansiyon))]
    [XmlInclude(typeof(ButikOtel))]
    [XmlInclude(typeof(TatilKoyu))]
    [Serializable]
    abstract public class Otel
    {
        protected Otel()
        {
            // Parametresiz otel yaratılmasını istemiyoruz ancak serilestirme islemi icin gerekli bu nedenle de parametresiz yaratmanin onune gecmek icin
            // protected tanımlı bir bos yapıcı metodu var.
        }
        public Otel(int temizlikpuani, int hizmetpuani, int konumpuani, string otelid,string oteladi)
        {
            temizlik = temizlikpuani;
            hizmet = temizlikpuani;
            konum = konumpuani;
            id = otelid;
            this.oteladi = oteladi;

        }

        [XmlElement("Odalar")]
        public List<Oda> Odalar = new List<Oda>();

        [XmlElement("TemizlikPuani")]
        private int temizlik; // Yoneticinin otel kayıt sırasında oylayacagı ve otelin yıldızını belırleyecek degıskenler
        public int Temizlik
        {
            get { return temizlik; }
            set { temizlik = value; }
        }

        [XmlElement("HizmetPuani")]
        private int hizmet; // Yoneticinin otel kayıt sırasında oylayacagı ve otelin yıldızını belırleyecek degıskenler
        public int Hizmet
        {
            get { return hizmet; }
            set { hizmet = value; }
        }

        [XmlElement("KonumPuani")]
        private int konum; // Yoneticinin otel kayıt sırasında oylayacagı ve otelin yıldızını belırleyecek degıskenler
        public int Konum
        {
            get { return konum; }
            set { konum = value; }
        }

        [XmlElement("OtelID")]
        private string id;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        [XmlElement("OtelAd")]
        private string oteladi;
        public string OtelAdi
        {
            get { return oteladi; }
            set { oteladi = value; }
        }

    }
}
