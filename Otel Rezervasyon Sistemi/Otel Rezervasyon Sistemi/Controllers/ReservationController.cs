using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            try
            {

                List<string> IDs = core.ReturnHotelID();
                if (IDs.Contains(otelId))
                {
                    List<int> roomIDs = core.ReturnRoomIds(otelId);
                    if (roomIDs.Contains(odaNo))
                    {
                        List<ModelsAndBuffer.Rezervasyon> reservations = core.ReservationofRoom(otelId, odaNo);
                        foreach (Rezervasyon r in reservations)
                        {
                            if ((r.RezBaslangic <= baslangic && r.RezBitis >= baslangic) || (r.RezBaslangic <= bitis && r.RezBitis >= bitis))
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    else
                    {
                        throw new MessageException("Bu otele ait boyle bir oda YOK");
                    }

                }
                else
                {
                    throw new MessageException("Bu ID ye sahip bir otel YOK");
                }
            }
            catch (MessageException m)
            {
                throw m;
            }
            catch (ExceptionHandler e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new ExceptionHandler("Oda Musaitlik durumu", "CheckReservationDateAvailabilty()", "OtelController", e.Message);
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
        public bool ReserveRoom(string userID, string Desteroy, DateTime baslangic, DateTime bitis)
        {
            try
            {

                Desteroy = Desteroy.Replace(" - ", "-");
                //Desteroy = Desteroy.Replace("--", "-");
                Debug.WriteLine(Desteroy);
                string otelId = Desteroy.Split('-')[0];
                int odaNo = Convert.ToInt32(Desteroy.Split('-')[2]);

                try
                {
                    if (CheckReservationDateAvailabilty(otelId, odaNo, baslangic, bitis))
                    {
                        try
                        {
                            core.AddReservation(otelId, userID, odaNo, baslangic, bitis);
                            return true;
                        }
                        catch (MessageException e)
                        {
                            throw new MessageException(e.Message);
                        }



                    }
                    else
                    {
                        throw new MessageException("Bu tarihler arasinda bu oda uygun degil");
                    }
                }
                catch (MessageException e)
                {
                    throw new MessageException(e.Message);
                }
            }
            catch (MessageException m)
            {
                throw m;
            }
            catch (ExceptionHandler e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new ExceptionHandler("Rezervasyon hatasi", "ReserveRoom()", "OtelController", e.Message);
            }


        }
        public bool DeleteReservation(string userID, string desteroy)
        {
            try
            {

                int rezID = Convert.ToInt32((desteroy.Split('-')[0]).Split(':')[1]);
                int odaNo = Convert.ToInt32((desteroy.Split('-')[2]).Split(':')[1]);
                string otelID = (desteroy.Split('-')[1]).Split(':')[1];
                List<string> userIDs = core.ReturnCustomerId();
                if (userIDs.Contains(userID))
                {
                    List<string> hotelIDs = core.ReturnHotelID();
                    if (hotelIDs.Contains(otelID))
                    {
                        List<int> roomIDs = core.ReturnRoomIds(otelID);
                        if (roomIDs.Contains(odaNo))
                        {
                            List<ModelsAndBuffer.Rezervasyon> reservationsOfRoom = core.ReservationofRoom(otelID, odaNo);
                            foreach (ModelsAndBuffer.Rezervasyon reservation in reservationsOfRoom)
                            {
                                if (reservation.RezID == rezID)
                                {
                                    try
                                    {
                                        if (core.DeleteReservation(otelID, odaNo, userID, rezID))
                                        {
                                            return true;
                                        }

                                    }
                                    catch (MessageException a)
                                    {
                                        throw a;
                                    }
                                }


                            }
                            throw new MessageException("Boyle bir rezervasyon yok");
                        }
                        else
                        {
                            throw new MessageException("Boyle bir oda yok");
                        }
                    }
                    else
                    {
                        throw new MessageException("Boyle bir otel yok");
                    }

                }
                else
                {
                    throw new MessageException("Boyle bir kullanici yok");
                }

            }
            catch (MessageException m)
            {
                throw m;
            }
            catch (ExceptionHandler e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new ExceptionHandler("Rezervasyon getirme hatasi", "GetMethods()", "OtelController", e.Message);
            }
        }


    }
}
