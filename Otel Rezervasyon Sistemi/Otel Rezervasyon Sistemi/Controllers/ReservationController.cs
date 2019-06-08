using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otel_Rezervasyon_Sistemi;
using Otel_Rezervasyon_Sistemi.ModelsAndBuffer;

namespace Otel_Rezervasyon_Sistemi.Controllers
{
    class ReservationController
    {
        private ModelsAndBuffer.Core core = new ModelsAndBuffer.Core();

        /// <summary>
        /// Odanin musaitlik durum sorgusu buradan yapilmali
        /// </summary>
        /// <param name="otelId">kontrolun yapilacagi otelin idsi</param>
        /// <param name="odaNo">kontrolun yapilacagi odanin numarasi</param>
        /// <param name="baslangic">kontrolun yapilacagi tarihin baslangici</param>
        /// <param name="bitis">kontrolun yapilacagi tarihin bitisi</param>
        /// <returns>onay durumun True , onay alamama durumunda false </returns>
        public bool CheckReservationDateAvailabilty(string otelId, int odaNo, DateTime baslangic, DateTime bitis)
        {
            List<string> IDs = core.ReturnHotelID();
            if (IDs.Contains(otelId))
            {
                List<int> roomIDs = core.ReturnRoomIds(otelId);
                if (roomIDs.Contains(odaNo))
                {
                    List<ModelsAndBuffer.Rezervasyon> reservations = new List<Rezervasyon>();
                    foreach (Rezervasyon r in reservations)
                    {
                        if ((r.RezBaslangic < baslangic && r.RezBitis > baslangic) || (r.RezBaslangic < bitis && r.RezBitis > bitis))
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    throw new Exception("Bu otele ait boyle bir oda YOK");
                }

            }
            else
            {
                throw new Exception("Bu ID ye sahip bir otel YOK");
            }

        }

        /// <summary>
        /// Rezervasyon odaya islenecegi zaman cagirilmasi gereken metod
        /// </summary>
        /// <param name="otelId">odanin bulundugu otelin idsi</param>
        /// <param name="odaNo">odanin numarasi</param>
        /// <param name="baslangic">rezervasyonun baslicagi tarih</param>
        /// <param name="bitis">rezervasyonun bitecegi tarih</param>
        /// <returns></returns>
        public bool ReserveRoom(string otelId, int odaNo, DateTime baslangic, DateTime bitis)
        {
            /*
             * rezervasyon onayi aldigi zaman rezervasyonunu odaya islenmesi icin
             */
            return false;
        }
        public bool DeleteReservation(string otelID, int odaNo, DateTime baslangic, DateTime bitis)
        {
            /*
             * rezervasyon onayi aldigi zaman rezervasyonunu odaya islenmesi icin
             */
            return false;
        }


    }
}
