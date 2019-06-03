using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otel_Rezervasyon_Sistemi.ModelsAndBuffer;

namespace Otel_Rezervasyon_Sistemi.Controllers
{
    class FilterController
    {
        internal FilterController()
        {

        }
        /// <summary>
        /// Sadece Fiyat Filtresi kullanilir ise cagirilmasi gereken method
        /// </summary>
        /// <param name="minFiyat">araligin alt siniri (eger belirlenmemisse defult olarak 0 girin)</param>
        /// <param name="maxFiyat">araligin ust sinir (eger belirlenmemis ise negatif bir deger giriniz)</param>
        /// <returns>Oda listesi Dondurur</returns>
        public  List<Oda> RoomFilter(int minFiyat, int maxFiyat)
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
        public  List<Oda> RoomFilter(int minFiyat, int maxFiyat, string odaTipi)
        {
            return new List<Oda>();
        }
        /// <summary>
        /// oda tipi olarak filtrelenirse
        /// </summary>
        /// <param name="odaTipi"> istenilen oda tipi orn("Standart")</param>
        /// <returns></returns>
        public  List<Oda> RoomFilter(string odaTipi)
        {
            return new List<Oda>();
        }
        /// <summary>
        /// otel tipine gore o tipe sahip oteller listesini dondurur
        /// </summary>
        /// <param name="otelType">istenilen otel tipi</param>
        /// <returns></returns>
        public  List<Otel> HotelFilter(string otelType)
        {
            return new List<Otel>();
        }
        /// <summary>
        /// istenilen otel tipine ve yildizina gore dondurur
        /// </summary>
        /// <param name="otelType">istenilen otel tipi ( string ) </param>
        /// <param name="star"> isteniler minimum yildiz ( int ) </param>
        /// <returns></returns>
        public  List<Otel> HotelFilter(string otelType , int star)
        {

            return new List<Otel>();
        }

        /// <summary>
        /// istenilen otel yildizina gore dondurur
        /// </summary>
        /// <param name="star">Olmasi istenilen minimum yildiz</param>
        /// <returns></returns>
        public  List<Otel> HotelFilter(int star)
        {
            return new List<Otel>();
        }
    }
}
