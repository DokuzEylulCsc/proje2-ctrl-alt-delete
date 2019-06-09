using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    interface IYonetebilir
    {
        void YoneticiOtelEkleme();
        void YoneticiOtelSil();
        void YoneticiOdaEkleme();
        void YoneticiOdaSilme();
    }
}
