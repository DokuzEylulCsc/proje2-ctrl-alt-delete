using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    [Serializable]
    public class Musteri:Kullanici,IGoruntuleyebilir
    {
        private Musteri()
        {
            // Serilestirme icin gerekli bos yapıcı metot.
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
