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
    public class ManzaraliOda:Oda
    {
        public ManzaraliOda()
        {
            // Serilestirme islemi icin gereken bos bir yapıcı metot.
        }

        public ManzaraliOda(int fiyat, int kisikapasite, int odanumarasi, bool klima, bool wifi, bool minibar, bool televizyon):base(fiyat,kisikapasite,odanumarasi,klima,wifi,minibar,televizyon)
        {
            // Herhangi bir implementasyon yapılmadı cunku oda yaratılırken gereklı ozellıkler baseden alınıcak. 
        }
        
        // Asagida yer alan fieldlar manzarali odayı diger odalardan ayiran ve her daim manzarali oda cesidinde bulunan ozellikler.

        [XmlElement("Manzara")]
        private bool manzara = true;
        public bool Manzara
        {
            get { return manzara; }
            set { manzara = value; }
        }
        [XmlElement("OdaServisi")]
        private bool odaservisi = true;
        public bool OdaServisi
        {
            get { return odaservisi; }
            set { odaservisi = value; }
        }
        [XmlElement("Kuvet")]
        private bool kuvet = true;
        public bool Kuvet
        {
            get { return kuvet; }
            set { kuvet = value; }
        }
    }
}
