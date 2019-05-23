using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    class Kullanici
    {
        int id;
        string ad;
        string soyad;
        int ID
        {
            get { return id; }
            set { id = value; }
        }
        string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public Kullanici(int ID, string isim, string soyisim)
        {
            id = ID;
            ad = isim;
            soyad = soyisim;
        }
    }
}
