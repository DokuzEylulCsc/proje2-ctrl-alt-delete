using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    class Yonetici:Kullanici,IGoruntuleyebilir,IYonetebilir
    {
        public Yonetici(int ID,string isim,string soyisim) : base(ID,isim,soyisim)
        {
            // Implementasyona ihtiyac yok ana classtan alınacak veriler.
        }

        public void Goruntule()
        {
            //Yoneticiye uygun ımplementasyonlar controller tarafından yapılacak.
        }

        public void YoneticiOdaSilme()
        {
            //Yoneticiye uygun ımplementasyonlar controller tarafından yapılacak.
        }

        public void YoneticiOdeEkleme()
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
