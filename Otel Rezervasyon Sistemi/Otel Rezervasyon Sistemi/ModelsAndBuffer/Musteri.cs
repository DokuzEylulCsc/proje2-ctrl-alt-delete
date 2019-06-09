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
    public class Musteri:Kullanici,IGoruntuleyebilir
    {
        public Musteri()
        {
            // Xml islemleri icin gereken bos yapıcı metot.
        }

        [XmlElement("MusteriRezervasyonu")]
        private List<Rezervasyon> reservationofCostumer = new List<Rezervasyon>();
        public List<Rezervasyon> ReservationofCostumer
        {
            get { return reservationofCostumer; }
            set { reservationofCostumer = value; }
        }

        public Musteri(string ID,string ad,string soyad,string sifre) : base(ID,ad,soyad,sifre)
        {
            // Bilgiler base classtan alınacagı ıcın ımplementasyona gerek yok.
        }

        public void Goruntule()
        {
            // icerik konusmasi yapilip kesin kararlar verildikten sonra buranin implementasyonu belirlenicektir
            //Yoneticiye uygun ımplementasyonlar controller tarafından yapılacak.
        }
    }
}
