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
        XmlSerializer xs = new XmlSerializer(typeof(List<Otel>));

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
            Otel o = new TatilKoyu(1, 1, 1, 125, "123456789", "BulutPansiyon");
            o.Odalar.Add(new ManzaraliOda(400, 2, 9789, true, false, true, false));
            Oteller.Add(o);

            using (FileStream fs = new FileStream(@"../Otel.xml",FileMode.OpenOrCreate))
            {
                xs.Serialize(fs, Oteller);
            }
           
           
        }
        public void Deserialization()
        {
            using (StreamReader sr = new StreamReader(@"../Otel.xml"))
            {
                Oteller = (List<Otel>)xs.Deserialize(sr);
            }
        }

        

    }
}
