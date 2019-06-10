using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.ModelsAndBuffer
{
    [Serializable]
    public class Yonetici:Kullanici
    {
        public Yonetici()
        {
            // Xml islemleri icin gerekli bos yapıcı metot.
        }

        public Yonetici(string ID,string isim,string soyisim,string sifre) : base(ID,isim,soyisim,sifre)
        {
            // Implementasyona ihtiyac yok ana classtan alınacak veriler.
        }

        
    }
}
