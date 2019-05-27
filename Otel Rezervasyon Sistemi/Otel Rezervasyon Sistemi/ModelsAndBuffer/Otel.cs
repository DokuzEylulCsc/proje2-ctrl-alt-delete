using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    abstract class Otel
    {
        public Otel(int temizlikpuani, int hizmetpuani, int konumpuani, string otelid,string oteladi)
        {
            temizlik = temizlikpuani;
            hizmet = temizlikpuani;
            konum = konumpuani;
            id = otelid;
            this.oteladi = oteladi;
        }

        List<Oda> Odalar = new List<Oda>();
        public int temizlik; // Yoneticinin otel kayıt sırasında oylayacagı ve otelin yıldızını belırleyecek degıskenler
        public int hizmet; // Yoneticinin otel kayıt sırasında oylayacagı ve otelin yıldızını belırleyecek degıskenler
        public int konum; // Yoneticinin otel kayıt sırasında oylayacagı ve otelin yıldızını belırleyecek degıskenler
        public string id;
        public string oteladi;

        public int Temizlik
        {
            get { return temizlik; }
            set { temizlik = value; }
        }
        public int Hizmet
        {
            get { return hizmet; }
            set { hizmet = value; }
        }
        public int Konum
        {
            get { return konum; }
            set { konum = value; }
        }
        public string ID
        {
            get { return id; } //Idlerin hicbirisinde set imkani olmicak , sadece constructor ile uretilen degerlen kullanilicak ! 
        }
        public string OtelAdi
        {
            get { return oteladi; }
            set { oteladi = value; }
        }
    }
}
