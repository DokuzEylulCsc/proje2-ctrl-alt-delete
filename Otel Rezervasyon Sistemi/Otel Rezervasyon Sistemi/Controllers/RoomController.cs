using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.Controllers
{
    class RoomController
    {
        ///<summary>
        ///herhangi bir otele eklenmek istenen oda bilgileri alinicak
        ///<returns>Oda Eklenirse true , hata olusursa hatayi aciklayan bir mesaj ile hata donucek</returns>
        ///</summary>
        ///<param name="A">gecici olarak olusturulmus oda nesnesi</param>
        ///<param name="B">islemi yapmak isteyen kullanici nesnesini alir</param>
        public static bool AddRoomRequest(Oda A, Kullanici B)
        {
            /* eklenmek istenen oda daha once eklendiyse hata dondurucek, 
             * eger ilk kez ekleniyorsa eklenip true dondurucek,
             * hangi kullanicinin ekledigi log bilgileri icin alinmalidir .
             * durum basarili ya da basarisiz diye loglara yazilacaktir 
             */
            return false;
        }
        /// <summary>
        /// Otele Ait bir odayi silme islemi
        /// </summary>
        /// <param name="B">Silmek isteyen kullanici nesesi</param>
        /// <param name="odano">Silinmek istenen oda numarasi</param>
        /// <param name="otelid">Odanin ait oldugu otel</param>
        /// <returns>Islem gerceklesirse true ; hata olusur ise hata doner</returns>
        public static bool DeleteRoomRequest(Kullanici B, int odano, int otelid)
        {
            /*
             * istemi yapan kullanici log icin kullanilicak ,
             * eger oda silinmeye musait ise true dondurulucek 
             * eger degil ise hata dondurulucek orn("boyle bir oda yok , veya suan bu oda da rezervasyon bulunmaktadir ")
             * view kisminda hata yonetimi buna uuygun yapilmalidir.
             */
            return false;
        }

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
    }
}
