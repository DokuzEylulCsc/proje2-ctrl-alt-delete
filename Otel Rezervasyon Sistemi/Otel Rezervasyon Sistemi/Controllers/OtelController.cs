using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.Controllers
{
    class OtelController
    {
        internal OtelController()
        {

        }


        /// <summary>
        /// Otelin butun rezervasyon bilgilerini dondurur
        /// </summary>
        /// <param name="otelid">Rezervasyonu sorgulanmak istenen otelin idsi</param>
        public  List<string> GetReservations(string otelid)
        {
            List<string> IDs = new List<string>(); // get ids from core
            if (IDs.Contains(otelid))
            {
                List<string> reservations = new List<string>(); // get Reservations from core
                return reservations;
            }
            else
            {
                throw new Exception("Boyle bir IDye ait otel bulunamadi");
            }
        }
        /// <summary>
        /// Otel Eklenmek istediginde
        /// </summary>
        /// <param name="temizlik">int temizlik puani [1,10]</param>
        /// <param name="konum">int komun puani [1,10]</param>
        /// <param name="hizmet">int hizmet puani [1,10]</param>
        /// <param name="otelid">yaratilacak otelin IDsi</param>
        /// <param name="otelname">yaratilicak otelin ismi</param>
        /// <param name="oteltype">yaratilacak otelin tipi string  ["TatilKoyu","Pansiyon","Butik"]</param>
        /// <returns>islem basarili olursa true</returns>
        public bool AddHotel(int temizlik , int konum , int hizmet ,string otelid , string otelname, string oteltype)
        {
            List<string> IDs= new List<string>(); // get IDs from core
            if (IDs.Contains(otelid))
            {
                if (oteltype == "TatilKoyu")
                {
                    // core add tatilkoyu
                    return true;
                }
                else if (oteltype == "Pansiyon")
                {
                    //core add pansiyon
                    return true;
                }
                else if (oteltype == "Butik")
                {
                    //core add butik
                    return true;
                }
                else
                {
                    throw new Exception("Something gone wrong ! CODE : HTFE1");//Hotel Type Not Found
                }
            }
            else
            {
                throw new Exception("Bu IDye sahip otel bulunamadi");
            }
            
        }
        /// <summary>
        /// genel listeden otel siler 
        /// </summary>
        /// <param name="hotelId">silinmek istenen otelIdsi </param>
        public bool DeleteHotel(string hotelId)
        {
            List<string> IDs = new List<string>(); // Get Otel IDs from Core
            if (IDs.Contains(hotelId))
            {
                //delete request to core 
                return true;
            }
            else
            {
                throw new Exception("Boyle bir ID ye ait otel bulunamadi");
            }
        }

        /*
         * duruma gore ekstra fonksiyonlar eklenebilir simdilik aklima gelenler bu kadar 
         */
    }
}
