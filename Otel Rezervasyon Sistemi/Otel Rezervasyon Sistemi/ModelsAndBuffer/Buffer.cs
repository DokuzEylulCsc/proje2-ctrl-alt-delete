using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;

namespace Otel_Rezervasyon_Sistemi.ModelsAndBuffer
{
    class Buffer
    {
        List<Otel> Oteller = new List<Otel>();
        List<Kullanici> Kullanicilar = new List<Kullanici>();
        XmlSerializer xs = new XmlSerializer(typeof(List<Otel>));
        XmlSerializer xs2 = new XmlSerializer(typeof(List<Kullanici>));

        private Buffer()
        {
            // Singleton tasarım deseni icin bos bir yapıcı metot gerekiyor.
        }

        private static Buffer buf;
        public static Buffer BUF
        {
            get
            {
                if (buf == null)
                {
                    buf = new Buffer();
                }
                return buf;
            }
        } // Singleton tamamlandi.

        public void Serialization()
        {
            Otel o = new TatilKoyu(1, 1, 1,"123456789", "SimTatilKoyu");
            o.Odalar.Add(new ManzaraliOda(400, 2, 9789, true, false, true, false));
            o.Odalar.Add(new KralDairesi(1000, 2, 3214, true, true, true, true));
            Otel o2 = new Pansiyon(2, 2, 2,"9789", "BulutPansiyon");
            o2.Odalar.Add(new ManzaraliOda(400, 2, 9789, true, false, true, false));
            Oteller.Add(o);
            Oteller.Add(o2);
            Kullanici k = new Musteri("13579", "Emir", "Bulut","sananee1");
            Kullanici k2 = new Yonetici("Em456Bu", "Simge", "Yavas","sananee2");
            Kullanicilar.Add(k);
            Kullanicilar.Add(k2);

            using (StreamWriter sw = new StreamWriter(@"../Otel.xml")) 
            {
                xs.Serialize(sw,Oteller);
            }
            using(StreamWriter sw2 = new StreamWriter(@"../Kullanici.xml"))
            {
                xs2.Serialize(sw2, Kullanicilar);
            }
        }
        public void Deserialization()
        {
            using (StreamReader sr = new StreamReader(@"../Otel.xml"))
            {
                Oteller = (List<Otel>)xs.Deserialize(sr);
            }
            using(StreamReader sr2 = new StreamReader(@"../Kullanici.xml"))
            {
                Kullanicilar = (List<Kullanici>)xs2.Deserialize(sr2);
            }
        }



    }
}
