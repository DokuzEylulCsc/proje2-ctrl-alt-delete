using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    class KralDairesi:Oda
    {
        public KralDairesi(int fiyat, int kisikapasite, int odanumarasi, bool klima, bool wifi, bool minibar, bool televizyon): base(fiyat, kisikapasite, odanumarasi, klima, wifi, minibar, televizyon)
        {
            // Bir implementasyona ihtiyac yok. Cunku zaten degerler oda yaratılırken base classtan alınacak.
        }
    }
}
