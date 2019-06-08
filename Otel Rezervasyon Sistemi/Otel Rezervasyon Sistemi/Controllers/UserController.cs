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
        private ModelsAndBuffer.Core core = new ModelsAndBuffer.Core();
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
            List<string> customerIDs = core.ReturnCustomerId();
            List<string> managerIDs = core.ReturnAdminId();
            if (customerIDs.Contains(id))
            {
                if(core.PasswordCheck(id,password))
                {
                    Kullanici k = core.ReturnInformations(id);
                    return new Musteri(k.ID, k.Ad, k.Soyad, "**");
                }
                else
                {
                    throw new Exception("Sifreniz hatali");
                }
            }
            else if (managerIDs.Contains(id))
            {
                if(core.PasswordCheck(id,password))
                {
                    Kullanici k = core.ReturnInformations(id);
                    return new Yonetici(k.ID, k.Ad, k.Soyad, "**");
                }
                else
                {
                    throw new Exception("Sifreniz hatali");
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
                List<string> IDs = core.ReturnAdminId();
                IDs.AddRange(core.ReturnCustomerId());
                if (IDs.Contains(id))
                {
                    throw new Exception("Boyle Bir ID zaten bulunmaktadir");
                }
                try
                {
                    core.AddCostumer(id,ad,soyad,password);
                    return true;
                }
                catch(Exception e)
                {
                    throw e;
                }
                

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
            List<string> IDs = core.ReturnAdminId();
            IDs.AddRange(core.ReturnCustomerId());
            if (IDs.Contains(Id))
            {
                if(core.PasswordCheck(Id,oldPas))
                {
                    if (newPas == newPasVerification)
                    {
                        try
                        {
                            core.PasswordChange(Id, newPas);
                            return true;
                        }
                        catch (Exception e)
                        {

                            throw e;
                        }
                        
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
            List<string> IDs = core.ReturnAdminId();
            IDs.AddRange(core.ReturnCustomerId());
            if (IDs.Contains(ID))
            {
                
                if (core.PasswordCheck(ID,Password))
                {
                    if(whichInfo == "Ad")
                    {
                        core.InformationChange(whichInfo, ID,newInfo);
                        return true;
                    }
                    else
                    {
                        core.InformationChange(whichInfo, ID, newInfo);
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
