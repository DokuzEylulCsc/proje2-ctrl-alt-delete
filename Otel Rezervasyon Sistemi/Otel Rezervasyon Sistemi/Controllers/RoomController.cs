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
        /// Otel Odalari listelenmek istediginde cagirilmali
        /// </summary>
        /// <param name="otelId">odalari listelenicek otelin idsi</param>
        /// <returns> List<Oda>  dondurur </returns>
        /*public List<Oda> GetRooms(string otelId)
        {
            List<string> IDs = new List<string>(); //get ids from core
            if (IDs.Contains(otelId))
            {
                List<Oda> odas = new List<Oda>(); //get rooms of hotel
                return odas;
            }
            else
            {
                throw new Exception("Boyle bir otel bulunamadi");
            }
        }*/
        /// <summary>
        /// Oda bilgilerini goruntulemek icin cagirilir
        /// </summary>
        /// <param name="odano">bilgileri goruntulenicek oda no</param>
        /// <param name="otelid">bilgileri goruntulenicek odanin ait oldugu otel idsi</param>
        /*public string[] GetRoomDetails(int odano, string otelid)
        {
            List<string> hotelIDs = new List<string>(); //get ids from core
            if (hotelIDs.Contains(otelid))
            {
                List<int> odaIDs = new List<int>(); // get ids from core 
                if (odaIDs.Contains(odano))
                {
                    //get details from core ;
                    return new string[3];
                }
                else
                {
                    throw new Exception("Bu otele ait boyle bir oda bulunamadi");
                }
            }
            else
            {
                throw new Exception("Bu IDye sahip otel bulunamadi");
            }
        }*/

            /*
        /// <summary>
        /// Odanin rezervasyon bilgileri istendiginde dondurur
        /// </summary>
        /// <param name="odano">rezervasyon bilgileri istenen odanin numarasi</param>
        /// <param name="otelid">rezervasyon bilgileri istenen odanin ait oldugu otel id </param>
        /// <returns></returns>
        public List<string> GetReservations(DateTime start , DateTime end)
        {
            List<string> IDs = new List<string>();
            foreach(string ID in IDs)
            {
                
            }
               
        }*/
    }
}
