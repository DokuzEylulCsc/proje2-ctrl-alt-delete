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
    public class Pansiyon:Otel
    {
        public Pansiyon()
        {
            // Xml islemleri icin gerekli bos yapıcı metot.
        }
        public Pansiyon(int temizlik,int konum,int hizmet,string otelid,string otelad):base(temizlik,hizmet,konum,otelid,otelad)
        {
            // Gerekli tum bilgiler ana classtan alınacagi icin implementasyona gerek yok.
        }

        [XmlElement("Kahvalti")]
        private bool kahvalti = true;
        public bool Kahvalti
        {
            get { return kahvalti; }
            set { kahvalti = value; }
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
