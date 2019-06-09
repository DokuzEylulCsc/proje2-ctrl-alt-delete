using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.ModelsAndBuffer
{
    [Serializable]
    public class Yonetici:Kullanici,IGoruntuleyebilir,IYonetebilir
    {
        public Yonetici()
        {
            // Xml islemleri icin gerekli bos yapıcı metot.
        }

        public Yonetici(string ID,string isim,string soyisim,string sifre) : base(ID,isim,soyisim,sifre)
        {
            // Implementasyona ihtiyac yok ana classtan alınacak veriler.
        }

        public void Goruntule()
        {

            // icerik konusmasi yapilip kesin kararlar verildikten sonra buranin implementasyonu belirlenicektir
            //Yoneticiye uygun ımplementasyonlar controller tarafından yapılacak.
        }

        public void YoneticiOdaSilme()
        {
            //Yoneticiye uygun ımplementasyonlar controller tarafından yapılacak.
        }

        public void YoneticiOdaEkleme()
        {
            //Yoneticiye uygun ımplementasyonlar controller tarafından yapılacak.
        }

        public void YoneticiOtelEkleme()
        {
            //Yoneticiye uygun ımplementasyonlar controller tarafından yapılacak.
        }

        public void YoneticiOtelSil()
        {
            //Yoneticiye uygun ımplementasyonlar controller tarafından yapılacak.
        }
    }
}
