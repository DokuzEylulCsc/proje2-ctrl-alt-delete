using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Otel_Rezervasyon_Sistemi
{
    [Serializable]
    public class StandartOda:Oda
    {
        private StandartOda()
        {

        }
        public StandartOda(int fiyat, int kisikapasite, int odanumarasi, bool klima, bool wifi, bool minibar, bool televizyon):base(fiyat,kisikapasite,odanumarasi,klima,wifi,minibar,televizyon)
        {
            // Herhangi bir implementasyona ihtiyac yok.
        }
    }
}
