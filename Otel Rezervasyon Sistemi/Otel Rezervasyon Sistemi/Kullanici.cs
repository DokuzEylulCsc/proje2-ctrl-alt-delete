using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    abstract class Kullanici
    {
        protected string id;
        protected string ad;
        protected string soyad;
        public string ID
        {
            get { return id; }      //Id set imkani yok , constructor da atanan deger kalicak sadece 
        }
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public Kullanici(string ID, string isim, string soyisim)
        {
            id = ID;
            ad = isim;
            soyad = soyisim;
        }
    }
}
