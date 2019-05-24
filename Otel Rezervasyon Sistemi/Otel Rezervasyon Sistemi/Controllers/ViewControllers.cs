using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otel_Rezervasyon_Sistemi;

namespace Otel_Rezervasyon_Sistemi.Controllers
{
    class ViewControllers
    {
        /// <summary>
        /// Otel Odalari listelenmek istediginde cagirilmali
        /// </summary>
        /// <param name="otelId">odalari listelenicek otelin idsi</param>
        /// <returns> List<Oda>  dondurur </returns>
        public static List<Oda> GetRooms(string otelId)
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
        public static void GetRoomDetails(int odano, string otelid)
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
        public static void GetReservations(int odano, string otelid)
        {
            /*
             * odanin rezervasyonlari dondurucek method
             */
        }
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
        /// Sadece Fiyat Filtresi kullanilir ise cagirilmasi gereken method
        /// </summary>
        /// <param name="minFiyat">araligin alt siniri (eger belirlenmemisse defult olarak 0 girin)</param>
        /// <param name="maxFiyat">araligin ust sinir (eger belirlenmemis ise negatif bir deger giriniz)</param>
        /// <returns>Oda listesi Dondurur</returns>
        public static List<Oda> RoomFilter(int minFiyat, int maxFiyat)
        {
            /*
             * fiyat filtresine gore oda Listesi Dondurucek
             */
            return new List<Oda>();
        }
        /// <summary>
        /// oda tipi ve fiyat araligi ile filtrelenirse 
        /// </summary>
        /// <param name="minFiyat">araligin alt siniri (eger belirlenmemisse defult olarak 0 girin)</param>
        /// <param name="maxFiyat">araligin ust sinir (eger belirlenmemis ise negatif bir deger giriniz)</param>
        /// <param name="odaTipi">istenilen oda tipi orn("Standart")</param>
        /// <returns></returns>
        public static List<Oda> RoomFilter(int minFiyat , int maxFiyat , string odaTipi)
        {
            return new List<Oda>();
        }
        /// <summary>
        /// oda tipi olarak filtrelenirse
        /// </summary>
        /// <param name="odaTipi"> istenilen oda tipi orn("Standart")</param>
        /// <returns></returns>
        public static List<Oda> RoomFilter(string odaTipi)
        {
            return new List<Oda>();
        }

        /*Viewde ihtiyac oldukca eklemeler yapilacaktir*/
    }
}
