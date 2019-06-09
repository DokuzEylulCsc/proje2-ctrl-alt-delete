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
    public class ButikOtel:Otel
    {
        public ButikOtel()
        {
            // Serilestirme islemi icin bos bir yapıcı metot bulunması gerekiyor.
        }
        public ButikOtel(int temizlik, int konum, int hizmet, string otelid, string otelad) : base(temizlik, hizmet, konum, otelid, otelad)
        {
            // Her otelde olacak olan ortak ozellıkler oldugu ıcın base classtan alınacak. Herhangi bir implementasyona ihtiyac yok.
        }

        // Asagıdaki ozellikler butik Oteli diger otel tiplerinden ayıracak olan ve daima true olarak gelen ozellikler.
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
