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
        ///<summary>
        ///<para>Giris yapmak isteyen kullanicin id ve sifresini alir</para>
        /// <returns>uygun Musteri ya da Yonetici nesnelerinin kopyasini dondurur , duruma gore hata dondurur</returns>
        /// </summary>
        /// <param name="id">kullanicinin girdigi ID </param>
        /// <param name="password">kullanicinin girdigi sifre </param>
<<<<<<< HEAD:Otel Rezervasyon Sistemi/Otel Rezervasyon Sistemi/Controllers/AuthenticationController.cs
        public static Musteri AccountVerification (string id , string password)
=======
        public static Musteri AccountVerification(string id, string password)
>>>>>>> parent of 774e034... Butun Controllerlar , Main Controller uzerinde baglandi:Otel Rezervasyon Sistemi/Otel Rezervasyon Sistemi/Controllers/UserController.cs
        {
            /*giris yapmak istenen kullanicinin var olup olmadigi kontrolu yapilacak oyle bir musteri varsa ;
             * Musteri nesnesi dogrudan yollanicak ,
             * yoksa hata dondurulucek
             */
            return new Musteri("", "", "");
        }

        /// <summary>
        /// <para>uretilmek istenen hesap biliglerini alicak</para>
        /// <returns>Kullanici yaratilirsa dogru yaratilamazsa false dondurulucek</returns>
        /// </summary>
        /// <param name="A" > gecici olarak olusturulmus olan kullanici nesnesi</param>
<<<<<<< HEAD:Otel Rezervasyon Sistemi/Otel Rezervasyon Sistemi/Controllers/AuthenticationController.cs
        public static bool CreateAccountRequest(Kullanici A )
=======
        public static bool CreateAccountRequest(Kullanici A)
>>>>>>> parent of 774e034... Butun Controllerlar , Main Controller uzerinde baglandi:Otel Rezervasyon Sistemi/Otel Rezervasyon Sistemi/Controllers/UserController.cs
        {
            /*kayit edilmek istenen kullanici durumlara uygun ise db ye eklenicek (eklenirse true) ,
             uygun degilse false donucek*/
            return false;
        }


        ///<summary>
        ///herhangi bir otele eklenmek istenen oda bilgileri alinicak
        ///<returns>Oda Eklenirse true , hata olusursa hatayi aciklayan bir mesaj ile hata donucek</returns>
        ///</summary>
        ///<param name="A">gecici olarak olusturulmus oda nesnesi</param>
        ///<param name="B">islemi yapmak isteyen kullanici nesnesini alir</param>
        public static bool AddRoomRequest(Oda A,Kullanici B)
        {
            /* eklenmek istenen oda daha once eklendiyse hata dondurucek, 
             * eger ilk kez ekleniyorsa eklenip true dondurucek,
             * hangi kullanicinin ekledigi log bilgileri icin alinmalidir .
             * durum basarili ya da basarisiz diye loglara yazilacaktir 
             */
            return false;
        }
        /// <summary>
        /// Kullanicinin sifre degistirme istegi
        /// </summary>
        /// <param name="B">Sifreyi degistirmek isteyen kullanici nesnesi</param>
        /// <param name="newPas">Kullanicinin belirledigi yeni sifre</param>
        /// <param name="newPasVerification">Kullanicinin belirledigi yeni sifrenin dogrulamasi</param>
        /// <returns>islem uygun ise True , degil ise hata dondurur</returns>
<<<<<<< HEAD:Otel Rezervasyon Sistemi/Otel Rezervasyon Sistemi/Controllers/AuthenticationController.cs
        public static bool ChangePasswordRequest(Kullanici B , string newPas,string newPasVerification)
=======
        public static bool ChangePasswordRequest(Kullanici B, string newPas, string newPasVerification)
>>>>>>> parent of 774e034... Butun Controllerlar , Main Controller uzerinde baglandi:Otel Rezervasyon Sistemi/Otel Rezervasyon Sistemi/Controllers/UserController.cs
        {
            /*
             * sifresini degistirmek isteyen kullanicinin bilgileri ve yeni yapmak istedigi 
             * sifre alinicak eger kosullar saglaniyor ise true ,
             * saglanmiyor ise hata dondurulucek ! 
             */
            return false;
        }
        /// <summary>
        /// kullanicinin bilgi guncelleme istegi 
        /// </summary>
        /// <param name="B">Bilgisi guncellenicek olan kullanici nesnesi</param>
        /// <param name="whichInfo">Hangi bilinin guncellenecegi</param>
        /// <param name="newInfo">Guncellenen bilginin yeni hali</param>
        /// <returns>islem uygulanir ise true , hata olusur ise hata dondurucekti</returns>
<<<<<<< HEAD:Otel Rezervasyon Sistemi/Otel Rezervasyon Sistemi/Controllers/AuthenticationController.cs
        public static bool ChangeInformationRequest(Kullanici B , string whichInfo , string newInfo)
=======
        public static bool ChangeInformationRequest(Kullanici B, string whichInfo, string newInfo)
>>>>>>> parent of 774e034... Butun Controllerlar , Main Controller uzerinde baglandi:Otel Rezervasyon Sistemi/Otel Rezervasyon Sistemi/Controllers/UserController.cs
        {
            /*
             * kullanicinin yeni infosu uygun ise db degisikligi yapilicak degil ise hata donulucek
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
