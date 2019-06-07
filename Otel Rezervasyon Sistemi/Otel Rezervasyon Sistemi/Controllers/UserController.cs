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
        public Kullanici AccountVerification(string id, string password)
        {
            List<string> managerIDs = new List<string>();
            List<string> customerIDs = new List<string>();
            if (managerIDs.Contains(id))
            {
                if (true /* Core Password Verification */)
                {
                    string[] managerDetails = new string[3]; // get manager details from core
                    return new Yonetici(id, managerDetails[1], managerDetails[2],"***");
                }
                else
                {
                    throw new Exception("Sifreniz Hatali");
                }
            }
            else if (customerIDs.Contains(id))
            {
                if (true /* Core Password Verification */)
                {
                    string[] customerDetails = new string[3]; //get customer details from core
                    return new Musteri(id, customerDetails[1], customerDetails[2],"***");
                }
                else
                {
                    throw new Exception("Sifreniz Hatali");
                }
            }
            else
            {
                throw new Exception("Boyle bir ID sistemimizde bulunmamaktadir");
            }
        }
        /// <summary>
        /// Yeni Kullanici Olusturulmak istendiginde cagirilmasi gereken metod
        /// </summary>
        /// <param name="id">kullanilmak istenen id</param>
        /// <param name="password">kullanilmak istenen sifre</param>
        /// <param name="passwordverif">sifre dogrulamasi</param>
        /// <param name="ad">kullanicinin adi</param>
        /// <param name="soyad">kullanicinin soyadi</param>
        /// <returns></returns>
        public bool CreateAccountRequest(string id, string password, string passwordverif, string ad, string soyad)
        {
            if (password == passwordverif)
            {
                List<string> IDs = new List<string>();//=getIds from core
                if (IDs.Contains(id))
                {
                    throw new Exception("Boyle Bir ID zaten bulunmaktadi");
                }

                return true;/*create new entity with these parameters (id , password, ad,soyad)*/
            }
            else
            {
                throw new Exception("Sifreler Uyusmuyor!");
            }
        }
        /// <summary>
        /// Sifre Degistirme istegi 
        /// </summary>
        /// <param name="ID">Degistirmek isteyen kullanicinin idsi</param>
        /// <param name="oldPass">Kullanicinin mevcut sifresi</param>
        /// <param name="newPas">Kullanicinin yeni sifresi</param>
        /// <param name="newPasVerification">Kullanicinin yeni sifre dogrulamasi</param>
        /// <returns></returns>
        public bool ChangePasswordRequest(string ID, string oldPass, string newPas, string newPasVerification)
        {


            if (true /*core pass verification*/)
            {
                if (newPas == newPasVerification)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Girilen sifre ile dogrulama sifresi uyusmuyor");
                }
            }
            else
            {
                throw new Exception("Sifrenizi hatali girdiniz");
            }

        }
        /// <summary>
        /// kullanicinin bilgi guncelleme istegi 
        /// </summary>
        /// <param name="B">Bilgisi guncellenicek olan kullanici nesnesi</param>
        /// <param name="whichInfo">Hangi bilinin guncellenecegi</param>
        /// <param name="newInfo">Guncellenen bilginin yeni hali</param>
        /// <returns>islem uygulanir ise true , hata olusur ise hata dondurucekti</returns>
        public bool ChangeInformationRequest(string ID, string Password, string whichInfo, string newInfo)
        {

            if (true /*Get pass verification from core*/)
            {
                if (whichInfo == "Ad")
                {
                    //Idye sahip adi new info ile degistir
                    return true;
                }
                else
                {
                    //Idye sahip soyadi new info ile degistir
                    return true;
                }
            }
            else
            {
                throw new Exception("Sifre hatali lutfen sifrenizi kontrol ediniz");
            }



        }
    }
}
