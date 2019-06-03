using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Otel_Rezervasyon_Sistemi
{
    [Serializable]
    public class KralDairesi:Oda
    {
        private KralDairesi()
        {
            // Serilestirme islemleri icin gerektiginden bos bir yapıcı metot tanımlandı.
        }

        public KralDairesi(int fiyat, int kisikapasite, int odanumarasi, bool klima, bool wifi, bool minibar, bool televizyon): base(fiyat, kisikapasite, odanumarasi, klima, wifi, minibar, televizyon)
        {
            // Bir implementasyona ihtiyac yok. Cunku zaten degerler oda yaratılırken base classtan alınacak.
        }

        // Asagida yer alan ozellikler kral dairesini diger oda tiplerinden ayiran ozellikler.
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

        [XmlElement("OyunKonsolu")]
        private bool oyunkonsolu = true;
        public bool OyunKonsolu
        {
            get { return oyunkonsolu; }
            set { oyunkonsolu = value; }
        }

        [XmlElement("Jakuzi")]
        private bool jakuzi = true;
        public bool Jakuzi
        {
            get { return jakuzi; }
            set { jakuzi = value; }
        }

    }
}
