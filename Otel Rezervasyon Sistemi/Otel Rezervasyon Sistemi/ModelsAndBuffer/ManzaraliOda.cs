using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    class ManzaraliOda:Oda
    {
        public ManzaraliOda(int fiyat, int kisikapasite, int odanumarasi, bool klima, bool wifi, bool minibar, bool televizyon):base(fiyat,kisikapasite,odanumarasi,klima,wifi,minibar,televizyon)
        {
            // Herhangi bir implementasyon yapılmadı cunku oda yaratılırken hangi oda turunden yaratıldıgını yonetıcı belırtecek ve ona gore gereklı ozellıkler
            // baseden alınıcak. 
        }
    }
}
