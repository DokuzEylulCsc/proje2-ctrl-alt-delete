using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.Controllers
{
    class RoomController
    {
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
        public  bool AddRoomRequest(string roomType , string yoneticiID , string otelID , int odaNo )
        {
            List<string> managerIDs = new List<string>(); //coredan alinacak 
            List<string> hotelIDS = new List<string>(); // coredan alinacak
            List<int> roomNOs = new List<int>(); // coredan alinacak 
            if (managerIDs.Contains(yoneticiID))
            {
                if (hotelIDS.Contains(otelID))
                {
                    if (!roomNOs.Contains(odaNo))
                    {
                        //core a uygun oldugu gonderilicek 
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
        public  bool DeleteRoomRequest(string yoneticiID, string otelID, int odaNo)
        {
            List<string> managerIDs = new List<string>(); //coredan alinacak 
            List<string> hotelIDS = new List<string>(); // coredan alinacak
            List<int> roomNOs = new List<int>(); // coredan alinacak 
            if (managerIDs.Contains(yoneticiID))
            {
                if (hotelIDS.Contains(otelID))
                {
                    if (roomNOs.Contains(odaNo))
                    {
                        //core a uygun oldugu gonderilicek 
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
        public  List<Oda> GetRooms(string otelId)
        {
            /*
             * herhangi bir otelin odalari gosterilmek istendiginde cagirilmasi gereken method 
             */
            return new List<Oda>();
        }
        /// <summary>
        /// Oda bilgilerini goruntulemek icin cagirilir
        /// </summary>
        /// <param name="odano">bilgileri goruntulenicek oda no</param>
        /// <param name="otelid">bilgileri goruntulenicek odanin ait oldugu otel idsi</param>
        public  void GetRoomDetails(int odano, string otelid)
        {
            /*
             * Dondurcegi sey oda fieldlari tamamlaninca belirlenicek sadece taslak icin void olarak belirlendi
             * 
             */
        }
        /// <summary>
        /// Odanin rezervasyon bilgileri istendiginde dondurur
        /// </summary>
        /// <param name="odano">rezervasyon bilgileri istenen odanin numarasi</param>
        /// <param name="otelid">rezervasyon bilgileri istenen odanin ait oldugu otel id </param>
        /// <returns></returns>
        public  void GetReservations(int odano, string otelid)
        {
            /*
             * odanin rezervasyonlari dondurucek method
             */
        }
    }
}
