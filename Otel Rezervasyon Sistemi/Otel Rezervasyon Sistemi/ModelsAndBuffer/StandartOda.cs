using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    class StandartOda:Oda
    {
        public StandartOda(int fiyat, int kisikapasite, int odanumarasi, bool klima, bool wifi, bool minibar, bool televizyon):base(fiyat,kisikapasite,odanumarasi,klima,wifi,minibar,televizyon)
        {
            // Herhangi bir implementasyona ihtiyac yok.
        }
    }
}
