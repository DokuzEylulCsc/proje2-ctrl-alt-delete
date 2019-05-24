using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otel_Rezervasyon_Sistemi;

namespace Otel_Rezervasyon_Sistemi.Controllers
{
    class ReservationController
    {
        /// <summary>
        /// Odanin musaitlik durum sorgusu buradan yapilmali
        /// </summary>
        /// <param name="otelId">kontrolun yapilacagi otelin idsi</param>
        /// <param name="odaNo">kontrolun yapilacagi odanin numarasi</param>
        /// <param name="baslangic">kontrolun yapilacagi tarihin baslangici</param>
        /// <param name="bitis">kontrolun yapilacagi tarihin bitisi</param>
        /// <returns>onay durumun True , onay alamama durumunda false </returns>
        public static bool CheckReservationDateAvailabilty(string otelId,int odaNo ,DateTime baslangic , DateTime bitis)
        {
            /*
             * rezervasyon istemi yapilmadan once burasi kontrol edilmeli ve ya bosluklar buradan sorgulanmali
             */
            return false;
        }

        /// <summary>
        /// Rezervasyon odaya islenecegi zaman cagirilmasi gereken metod
        /// </summary>
        /// <param name="otelId">odanin bulundugu otelin idsi</param>
        /// <param name="odaNo">odanin numarasi</param>
        /// <param name="baslangic">rezervasyonun baslicagi tarih</param>
        /// <param name="bitis">rezervasyonun bitecegi tarih</param>
        /// <returns></returns>
        public static bool ReserveRoom(string otelId ,int odaNo , DateTime baslangic , DateTime bitis)
        {
            /*
             * rezervasyon onayi aldigi zaman rezervasyonunu odaya islenmesi icin
             */
            return false;
        }
    }
}
