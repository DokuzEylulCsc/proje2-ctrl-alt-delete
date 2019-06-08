using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otel_Rezervasyon_Sistemi.ModelsAndBuffer;

namespace Otel_Rezervasyon_Sistemi.Controllers
{
    class RoomController
    {
        public ModelsAndBuffer.Core core = new ModelsAndBuffer.Core();
        internal RoomController()
        {

        }
        /// <summary>
        /// Oda ekleme requesti icin bu method kullanilacak
        /// </summary>
        /// <param name="roomType">Manzarali/Kral/Standart</param>
        /// <param name="yoneticiID">Eklemek isteyen yonetici Idsi</param>
        /// <param name="otelID">Eklenilecek olan Otel ID </param>
        /// <param name="odaNo">Eklenecek olan odanin numarasi </param>
        /// <returns></returns>
        public bool AddRoomRequest(string roomType, int fiyat, string yoneticiID, string otelID, int odaNo, int kisiKapasitesi, bool klima, bool televizyon, bool minibar, bool wifi)
        {
            List<string> managerIDs = core.ReturnAdminId();
            List<string> hotelIDS = core.ReturnHotelID();
            if (managerIDs.Contains(yoneticiID))
            {
                if (hotelIDS.Contains(otelID))
                {
                    List<int> roomNOs = core.ReturnRoomIds(otelID);
                    if (!roomNOs.Contains(odaNo))
                    {
                        core.AddRoom(otelID, roomType, fiyat, kisiKapasitesi, odaNo, klima, klima, minibar, televizyon);
                        return true;
                    }
                    else
                    {
                        throw new Exception("Bu oda numarasina ait baska bir oda bulunmakta");
                    }
                }
                else
                {
                    throw new Exception("Boyle bir otel IDsi bulunamadi ");
                }
            }
            else
            {
                throw new Exception("Boyle Bir Yonetici bulunmamaktadir");
            }
        }
        /// <summary>
        /// Oda silinmek istediginde cagirilmasi gereken method
        /// </summary>
        /// <param name="yoneticiID">Silmek isteyen yoneticinin IDsi</param>
        /// <param name="otelID">silinmek istenen odanin otel IDsi </param>
        /// <param name="odaNo">silinmek istenen odanin numarasi </param>
        /// <returns></returns>
        public bool DeleteRoomRequest(string yoneticiID, string otelID, int odaNo)
        {
            List<string> managerIDs = core.ReturnAdminId();
            List<string> hotelIDS = core.ReturnHotelID();

            if (managerIDs.Contains(yoneticiID))
            {
                if (hotelIDS.Contains(otelID))
                {
                    List<int> roomNOs = core.ReturnRoomIds(otelID);
                    if (roomNOs.Contains(odaNo))
                    {
                        core.DeleteRoom(otelID, odaNo);
                        return true;
                    }
                    else
                    {
                        throw new Exception("Bu oda numarasina ait baska bir oda bulunmakta");
                    }
                }
                else
                {
                    throw new Exception("Boyle bir otel IDsi bulunamadi ");
                }
            }
            else
            {
                throw new Exception("Boyle Bir Yonetici bulunmamaktadir");
            }

        }

        /// <summary>
        /// Butun otellerin o tarihler arasindaki odalarini dondurur
        /// </summary>
        /// <param name="start">belirlenen tarihin baslangici</param>
        /// <param name="end">belirlenen tarihin bitisi</param>
        /// <returns>"idsi ** olan otelin ** nolu odasi ** kisi tarafindan ** TL ye tutulmustur"</returns>
        public List<string> GetReservations(DateTime start, DateTime end)
        {
            List<string> reservedRoomHotel = new List<string>();
            List<string> hotelIDs = core.ReturnHotelID();
            foreach (string ID in hotelIDs)
            {
                List<Oda> rooms = core.ReturnRoomObjects(ID);
                foreach (Oda room in rooms)
                {
                    foreach (ModelsAndBuffer.Rezervasyon rez in room.Rezervasyonlar)
                    {
                        if ((rez.RezBaslangic < start && rez.RezBitis > start) || (rez.RezBaslangic < end && rez.RezBitis > end))
                        {
                            reservedRoomHotel.Add(
                                "Girilen tarihler arasinda ID si " +
                                ID + " olan otelin " +
                                room.OdaNo + " nolu odasi " +
                                room.KisiKapasitesi.ToString() + " kisi icin " +
                                room.OdaFiyati.ToString() + "TL ye tutulmustur"
                                );
                            break;
                        }
                    }
                }
            }
            return reservedRoomHotel;
        }
    }
}
