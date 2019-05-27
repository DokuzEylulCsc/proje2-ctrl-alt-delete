using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.Controllers
{
    class OtelController
    {

        /// <summary>
        /// Otelin butun rezervasyon bilgilerini dondurur
        /// </summary>
        /// <param name="otelid">Rezervasyonu sorgulanmak istenen otelin idsi</param>
        public static void GetReservations(string otelid)
        {
            /*
             * otelin butun rezervasyonlarini dondurucek olan id 
             */
        }
        /// <summary>
        /// genel listeye otel ekler 
        /// </summary>
        /// <param name="otelid">eklenecek olan otelin idsi</param>
        /// <param name="otelname">eklenicek olan otelin ismi</param>
        /// <param name="oteltype">eklenicek olan otelin tipi </param>
        public static void AddHotel(string otelid , string otelname, string oteltype)
        {
            /*
             * gerekli implementasyon yapilacaka duruma gore parametre eklenip cikartilacak 
             * sadece bir templatedir
             */
        }
        /// <summary>
        /// genel listeden otel siler 
        /// </summary>
        /// <param name="hotelId">silinmek istenen otelIdsi </param>
        public static void DeleteHotel(string hotelId)
        {
            /*
             * gerekli implementasyon yapilacaka duruma gore parametre eklenip cikartilacak 
             * sadece bir templatedir
             */
        }

        /*
         * duruma gore ekstra fonksiyonlar eklenebilir simdilik aklima gelenler bu kadar 
         */
    }
}
