using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otel_Rezervasyon_Sistemi;

namespace Otel_Rezervasyon_Sistemi.Controllers
{
    class AuthenticationController
    {
        public static Musteri AccountVerification (string id , string password)
        {
            /*giris yapmak istenen kullanicinin var olup olmadigi kontrolu yapilacak oyle bir musteri varsa ;
             * Musteri nesnesi dogrudan yollanicak ,
             * yoksa hata dondurulucek
             */
            return new Musteri("", "", "");
        }
        public static bool CreateAccountRequest(Kullanici A )
        {
            /*kayit edilmek istenen kullanici durumlara uygun ise db ye eklenicek (eklenirse true) ,
             uygun degilse false donucek*/
            return false;
        }
        public static bool AddRoomRequest(Oda A,Kullanici B)
        {
            /* eklenmek istenen oda daha once eklendiyse hata dondurucek, 
             * eger ilk kez ekleniyorsa eklenip true dondurucek,
             * hangi kullanicinin ekledigi log bilgileri icin alinmalidir .
             * durum basarili ya da basarisiz diye loglara yazilacaktir 
             */
            return false;
        }
        public static bool ChangePasswordRequest(Kullanici B , string pas,string pasVerification)
        {
            /*
             * sifresini degistirmek isteyen kullanicinin bilgileri ve yeni yapmak istedigi 
             * sifre alinicak eger kosullar saglaniyor ise true ,
             * saglanmiyor ise hata dondurulucek ! 
             */
            return false;
        }
        public static bool ChangeInformationRequest(Kullanici B , string whichInfo , string newInfo)
        {
            /*
             * kullanicinin yeni infosu uygun ise db degisikligi yapilicak degil ise hata donulucek
             */

            return false;
        }
        public static bool DeleteRoomRequest(Kullanici B , int odano , int otelid)
        {
            /*
             * istemi yapan kullanici log icin kullanilicak ,
             * eger oda silinmeye musait ise true dondurulucek 
             * eger degil ise hata dondurulucek orn("boyle bir oda yok , veya suan bu oda da rezervasyon bulunmaktadir ")
             * view kisminda hata yonetimi buna uuygun yapilmalidir.
             */
            return false;
        }
        /*
         * ihtiyaca bagli olarak dahasi da eklenecektir .
         */

    }
}
