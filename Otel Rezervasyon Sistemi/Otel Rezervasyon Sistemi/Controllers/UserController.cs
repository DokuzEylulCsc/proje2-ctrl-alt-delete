using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.Controllers
{
    class UserController
    {
        internal UserController()
        {

        }
        ///<summary>
        ///<para>Giris yapmak isteyen kullanicin id ve sifresini alir</para>
        /// <returns>uygun Musteri ya da Yonetici nesnelerinin kopyasini dondurur , duruma gore hata dondurur</returns>
        /// </summary>
        /// <param name="id">kullanicinin girdigi ID </param>
        /// <param name="password">kullanicinin girdigi sifre </param>
        public  Musteri AccountVerification(string id, string password)
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
        public  bool CreateAccountRequest(Kullanici A)
        {
            /*kayit edilmek istenen kullanici durumlara uygun ise db ye eklenicek (eklenirse true) ,
             uygun degilse false donucek*/
            return false;
        }
        /// <summary>
        /// Kullanicinin sifre degistirme istegi
        /// </summary>
        /// <param name="B">Sifreyi degistirmek isteyen kullanici nesnesi</param>
        /// <param name="newPas">Kullanicinin belirledigi yeni sifre</param>
        /// <param name="newPasVerification">Kullanicinin belirledigi yeni sifrenin dogrulamasi</param>
        /// <returns>islem uygun ise True , degil ise hata dondurur</returns>
        public  bool ChangePasswordRequest(Kullanici B, string newPas, string newPasVerification)
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
        public  bool ChangeInformationRequest(Kullanici B, string whichInfo, string newInfo)
        {
            /*
             * kullanicinin yeni infosu uygun ise db degisikligi yapilicak degil ise hata donulucek
             */

            return false;
        }
    }
}
