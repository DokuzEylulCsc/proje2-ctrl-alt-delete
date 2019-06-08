﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otel_Rezervasyon_Sistemi.ModelsAndBuffer;

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
        public  Kullanici AccountVerification(string id, string password)
        {
            List<string> customerIDs = new List<string>();
            List<string> managerIDs = new List<string>();
            if (customerIDs.Contains(id))
            {
                if(true /*get core verification*/)
                {
                    /*get details of id*/
                    return new Musteri("","","","");
                }
            }
            else if (managerIDs.Contains(id))
            {
                if(true /*get core verification*/)
                {
                    /*get details of id*/
                    return new Yonetici("","","","");
                }
            }
            else
            {
                throw new Exception("Boyle bir ID bulunmamaktadir");
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
        public  bool CreateAccountRequest(string id , string password, string passwordverif, string ad , string soyad)
        {
            if(password == passwordverif)
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
        /// Kullanicinin sifre degistirme istegi
        /// </summary>
        /// <param name="B">Sifreyi degistirmek isteyen kullanici nesnesi</param>
        /// <param name="newPas">Kullanicinin belirledigi yeni sifre</param>
        /// <param name="newPasVerification">Kullanicinin belirledigi yeni sifrenin dogrulamasi</param>
        /// <returns>islem uygun ise True , degil ise hata dondurur</returns>
        public  bool ChangePasswordRequest(string Id,string oldPas, string newPas, string newPasVerification)
        {
            List<string> IDs = new List<string>();
            if (IDs.Contains(Id))
            {
                if(true /*pass id verification*/ )
                {
                    if (newPas == newPasVerification)
                    {
                        /*core degisiklik*/
                        return true;
                    }
                    else
                    {
                        throw new Exception("Sifre ile Dogrulama uyusmuyor ");
                    }
                }
                else
                {
                    throw new Exception("Sifrenizi Yanlis girdiniz");
                }
                
            }
            else
            {
                throw new Exception("Boyle bir IDye ulasilamiyor");
            }
        }
        /// <summary>
        /// kullanicinin bilgi guncelleme istegi 
        /// </summary>
        /// <param name="B">Bilgisi guncellenicek olan kullanici nesnesi</param>
        /// <param name="whichInfo">Hangi bilinin guncellenecegi</param>
        /// <param name="newInfo">Guncellenen bilginin yeni hali</param>
        /// <returns>islem uygulanir ise true , hata olusur ise hata dondurucekti</returns>
        public  bool ChangeInformationRequest(string ID , string Password, string whichInfo, string newInfo)
        {
            List<string> IDs = new List<string>();
            if (IDs.Contains(ID))
            {
                string pass = ""; /*get password of ID*/
                if (pass == Password)
                {
                    if(whichInfo == "Ad")
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
                    throw new Exception("ID ile sifreniz uyusmamaktadir");
                }
            }
            else
            {
                throw new Exception("Boyle bir ID yoktur");
            }

        }
    }
}
