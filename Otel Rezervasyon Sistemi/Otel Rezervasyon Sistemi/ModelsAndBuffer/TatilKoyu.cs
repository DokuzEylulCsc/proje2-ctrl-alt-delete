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
    public class TatilKoyu:Otel
    {
        private TatilKoyu()
        {
            // Serialize islemi icin bos bir yapıcı metoda ihtiyac var bu nedenle kullanıldı.
        }
        public TatilKoyu(int temizlik, int konum, int hizmet, int odasayisi, string otelid, string otelad) : base(temizlik, hizmet, konum, odasayisi, otelid, otelad)
        {
            // Bu ozellikler her otel tipinde var ve otel yaratılırken baseden alınacagı icin bir implementasyon yapılmadı.
        }

        // Assagıdaki ozellikler her tatil koyunde kendiliginden bulunan ozellikler isterse degistirilebilir ancak tatil koyunu 
        // diger otel tiplerinden ayiran ozellikler olarak belirlendi.

        [XmlElement("Disco")]
        private bool disco = true;
        public bool Disco
        {
            get { return disco; }
            set { disco = value; }
        }

        [XmlElement("OtoPark")]
        private bool otopark = true;
        public bool OtoPark
        {
            get { return otopark; }
            set { otopark = value; }
        }

        [XmlElement("Vale")]
        private bool vale = true;
        public bool Vale
        {
            get { return vale; }
            set { vale = value; }
        }

        [XmlElement("Kahvalti")]
        private bool kahvalti = true;
        public bool Kahvalti
        {
            get { return kahvalti; }
            set { kahvalti = value; }
        }

        [XmlElement("OglenYemegi")]
        private bool oglenyemegi = true;
        public bool OglenYemegi
        {
            get { return oglenyemegi; }
            set { oglenyemegi = value; }
        }

        [XmlElement("AksamYemegi")]
        private bool aksamyemegi = true;
        public bool AksamYemegi
        {
            get { return aksamyemegi; }
            set { aksamyemegi = value; }
        }


    }
}
