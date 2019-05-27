using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    class Musteri:Kullanici,IGoruntuleyebilir
    {
        public Musteri(string ID,string ad,string soyad) : base(ID,ad,soyad)
        {
            // Bilgiler base classtan alınacagı ıcın ımplementasyona gerek yok.
        }

        public void Goruntule()
        {
            //Yoneticiye uygun ımplementasyonlar controller tarafından yapılacak.
        }
    }
}
