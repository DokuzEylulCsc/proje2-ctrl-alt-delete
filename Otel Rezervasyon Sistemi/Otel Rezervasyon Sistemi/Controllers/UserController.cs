using System;
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
        public Kullanici AccountVerification(string id, string password)
        {
            try
            {

                List<string> customerIDs = core.ReturnCustomerId();
                List<string> managerIDs = core.ReturnAdminId();
                if (customerIDs.Contains(id))
                {
                    if (core.PasswordCheck(id, password))
                    {
                        Kullanici k = core.ReturnInformations(id);
                        return new Musteri(k.ID, k.Ad, k.Soyad, "**");
                    }
                    else
                    {
                        throw new MessageException("Sifreniz hatali");
                    }
                }
                else if (managerIDs.Contains(id))
                {
                    if (core.PasswordCheck(id, password))
                    {
                        Kullanici k = core.ReturnInformations(id);
                        return new Yonetici(k.ID, k.Ad, k.Soyad, "**");
                    }
                    else
                    {
                        throw new MessageException("Sifreniz hatali");
                    }
                }
                else
                {
                    throw new MessageException("Boyle bir ID bulunmamaktadir");
                }
            }
            catch (MessageException m)
            {
                throw m;
            }
            catch (ExceptionHandler e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new ExceptionHandler("Account Dogrulama hatasi", "AccountVerification()", "UserController", e.Message);
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
            try
            {

                if (password == passwordverif)
                {
                    List<string> IDs = core.ReturnAdminId();
                    IDs.AddRange(core.ReturnCustomerId());
                    if (IDs.Contains(id))
                    {
                        throw new MessageException("Boyle Bir ID zaten bulunmaktadir");
                    }
                    try
                    {
                        core.AddCostumer(id, ad, soyad, password);
                        return true;
                    }
                    catch (MessageException e)
                    {
                        throw e;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                }
                else
                {
                    throw new MessageException("Sifreler Uyusmuyor!");
                }

            }
            catch (MessageException m)
            {
                throw m;
            }
            catch (ExceptionHandler e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new ExceptionHandler("Hesap Olusturma hatasi", "CreateAccountRequest()", "UserController", e.Message);
            }

        }
        public bool CreateManagerAccountRequest(string id, string password, string passwordverif, string ad, string soyad)
        {
            try
            {

                if (password == passwordverif)
                {
                    List<string> IDs = core.ReturnAdminId();
                    IDs.AddRange(core.ReturnCustomerId());
                    if (IDs.Contains(id))
                    {
                        throw new MessageException("Boyle Bir ID zaten bulunmaktadir");
                    }
                    try
                    {
                        core.AddAdmin(id, ad, soyad, password);
                        return true;
                    }
                    catch (MessageException e)
                    {
                        throw e;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                }
                else
                {
                    throw new MessageException("Sifreler Uyusmuyor!");
                }
            }
            catch (MessageException m)
            {
                throw m;
            }
            catch (ExceptionHandler e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new ExceptionHandler("Rezervasyon getirme hatasi", "GetMethods()", "OtelController", e.Message);
            }
        }

        /// <summary>
        /// Kullanicinin sifre degistirme istegi
        /// </summary>
        /// <param name="B">Sifreyi degistirmek isteyen kullanici nesnesi</param>
        /// <param name="newPas">Kullanicinin belirledigi yeni sifre</param>
        /// <param name="newPasVerification">Kullanicinin belirledigi yeni sifrenin dogrulamasi</param>
        /// <returns>islem uygun ise True , degil ise hata dondurur</returns>
        public bool ChangePasswordRequest(string Id, string oldPas, string newPas, string newPasVerification)
        {
            List<string> IDs = core.ReturnAdminId();
            IDs.AddRange(core.ReturnCustomerId());
            if (IDs.Contains(Id))
            {
                if (core.PasswordCheck(Id, oldPas))
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
        public bool ChangeInformationRequest(string ID, string Password, string whichInfo, string newInfo)
        {
            try
            {

                List<string> IDs = core.ReturnAdminId();
                IDs.AddRange(core.ReturnCustomerId());
                if (IDs.Contains(ID))
                {

                    if (core.PasswordCheck(ID, Password))
                    {
                        if (whichInfo == "Ad")
                        {
                            core.InformationChange(whichInfo, ID, newInfo);
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
                        throw new MessageException("ID ile sifreniz uyusmamaktadir");
                    }
                }
                else
                {
                    throw new MessageException("Boyle bir ID yoktur");
                }
            }
            catch (MessageException m)
            {
                throw m;
            }
            catch (ExceptionHandler e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new ExceptionHandler("Bilgi Degistirme hatasi", "ChangeInformationRequest()", "UserController", e.Message);
            }

        }
        /// <summary>
        /// Kullanicinin aktif olan rezervasyonlarini "Rezervasyon ID:**-Otel ID:***-Oda NO:***-Baslangic Tarihi:***-Bitis Tarihi:***" seklinde elemanlar tutan liste gonderir
        /// </summary>
        /// <param name="userID">User ID ise</param>
        /// <returns></returns>
        public List<string> ShowActiveReservationsOfCustomer(string userID)
        {
            try
            {

                List<string> UserReservation = new List<string>();
                List<string> IDs = core.ReturnCustomerId();
                if (IDs.Contains(userID))
                {
                    List<ModelsAndBuffer.Rezervasyon> reservationsOfUser = ((Musteri)core.ReturnInformations(userID)).ReservationofCostumer;
                    foreach (ModelsAndBuffer.Rezervasyon reservation in reservationsOfUser)
                    {
                        if (reservation.RezBaslangic >= DateTime.Now)
                        {
                            UserReservation.Add(
                                "Rezervasyon ID:" + reservation.RezID +
                                "-Otel ID :" + reservation.RezOtelID +
                                "-Oda NO:" + reservation.RezOdaNumarasi.ToString() +
                                "-Baslangic Tarihi:" + reservation.RezBaslangic.ToString() +
                                "-Bitis Tarihi" + reservation.RezBitis.ToString()
                                );
                        }
                    }
                    if (UserReservation.Count > 0)
                    {
                        return UserReservation;
                    }
                    else
                    {
                        throw new MessageException("Bu kullanicinin hic guncel rezervasyonu yok ");
                    }
                }
                else
                {
                    throw new MessageException("Boyle bir kullanici yok");
                }
            }
            catch (MessageException m)
            {
                throw m;
            }
            catch (ExceptionHandler e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new ExceptionHandler("Kullanici Rezervasyonlarini getirme hatasi", "ShowActiveReservationsOfCustomer()", "UserController", e.Message);
            }
        }
        /// <summary>
        /// Kullanicinin aktif olan rezervasyonlarini "Rezervasyon ID:**-Otel ID:***-Oda NO:***-Baslangic Tarihi:***-Bitis Tarihi:***" seklinde elemanlar tutan liste gonderir
        /// </summary>
        /// <param name="userID">user ID iste</param>
        /// <returns></returns>
        public List<string> ShowOldReservationsOfCustomer(string userID)
        {
            try
            {

                List<string> UserReservation = new List<string>();
                List<string> IDs = core.ReturnCustomerId();
                if (IDs.Contains(userID))
                {
                    List<ModelsAndBuffer.Rezervasyon> reservationsOfUser = ((Musteri)core.ReturnInformations(userID)).ReservationofCostumer;
                    foreach (ModelsAndBuffer.Rezervasyon reservation in reservationsOfUser)
                    {
                        if (reservation.RezBaslangic < DateTime.Now)
                        {
                            UserReservation.Add(
                                 reservation.RezID +
                                "-" + reservation.RezOtelID +
                                "-" + reservation.RezOdaNumarasi.ToString() +
                                "-" + reservation.RezBaslangic.ToString() +
                                "-" + reservation.RezBitis.ToString()
                                );
                        }
                    }
                    if (UserReservation.Count > 0)
                    {
                        return UserReservation;
                    }
                    else
                    {
                        throw new MessageException("Bu kullanicinin hic guncel rezervasyonu yok ");
                    }
                }
                else
                {
                    throw new MessageException("Boyle bir kullanici yok");
                }
            }
            catch (MessageException m)
            {
                throw m;
            }
            catch (ExceptionHandler e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new ExceptionHandler("Kullanicinin eski rezervasyonlarini getirme hatasi", "ShowOldReservationOfCustomer()", "UserController", e.Message);
            }
        }

        public bool DeleteActiveReservation(string userID, string reservationDetails)
        {
            int reservationID = Convert.ToInt32(((reservationDetails.Split('-'))[0].Split(':'))[1]);
            string otelID = (((reservationDetails.Split('-'))[1]).Split(':'))[1];
            int odaNo = Convert.ToInt32((((reservationDetails.Split('-'))[2]).Split(':'))[1]);
            List<string> userIDs = core.ReturnCustomerId();
            if (userIDs.Contains(userID))
            {
                try
                {
                    core.DeleteReservation(otelID, odaNo, userID, reservationID);
                    return true;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            else
            {
                throw new Exception("Boyle bir musteri YOK");
            }
        }
    }
}
