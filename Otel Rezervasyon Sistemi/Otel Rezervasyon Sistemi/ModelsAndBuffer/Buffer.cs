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
        public List<Otel> Oteller = new List<Otel>();
        public List<Kullanici> Kullanicilar = new List<Kullanici>();
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


        // Nesneleri serilestirip xml dosyasina yazan metot.
        public void Serialization()
        {
            Otel o = new TatilKoyu(1, 1, 1, "123456789", "BulutlardaTatil");
            o.Odalar.Add(new ManzaraliOda(400, 2, 9789, true, false, true, false));
            o.Odalar.Add(new StandartOda(100, 2, 789, true, false, false, true));
            Oteller.Add(o);
            Kullanici k = new Yonetici("Emdidka", "Emir", "Bulut", "sananee1");
            Kullanici k2 = new Musteri("SimSim", "Simge", "Yavas", "sananee2");
            Kullanicilar.Add(k);
            Kullanicilar.Add(k2);

            using (StreamWriter sr = new StreamWriter(@"../Otel.xml"))
            {
                xs.Serialize(sr, Oteller);
            }
            using (StreamWriter sr2 = new StreamWriter(@"../Kullanici.xml"))
            {
                xs2.Serialize(sr2, Kullanicilar);
            }
        }

        // Xml verilerini nesnelestiren metot.
        public void Deserialization()
        {
            using (StreamReader sr = new StreamReader(@"../Otel.xml"))
            {
                Oteller = (List<Otel>)xs.Deserialize(sr);
            }
            using (StreamReader sr2 = new StreamReader(@"Kullanici.xml"))
            {
                Kullanicilar = (List<Kullanici>)xs2.Deserialize(sr2);
            }
        }


    }
    
}
