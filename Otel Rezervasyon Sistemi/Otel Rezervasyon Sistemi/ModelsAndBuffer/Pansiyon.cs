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
        private Pansiyon()
        {

        }
        public Pansiyon(int temizlik,int konum,int hizmet,int odasayisi,string otelid,string otelad):base(temizlik,hizmet,konum,odasayisi,otelid,otelad)
        {

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
