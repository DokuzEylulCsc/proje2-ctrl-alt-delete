using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.ModelsAndBuffer
{
    class Core
    {
        Otel_Rezervasyon_Sistemi.ModelsAndBuffer.Buffer buf = Otel_Rezervasyon_Sistemi.ModelsAndBuffer.Buffer.BUF;

        // User Id listi dondurecek metot.(yonetici - musteri idler ayrı listelerde donecek)

        public List<string> ReturnMusteriId() // Gerekli kontroller icin controller classına musterilerin ıdlerini dondurecek olan metot.
        {
            List<string> MusteriID = new List<string>();
            foreach (Kullanici item in buf.Kullanicilar)
            {
                if (item is Musteri)
                {
                    MusteriID.Add(item.ID);
                }    
            }
            return MusteriID;
        }
        public List<string> ReturnYoneticiId() // Gerekli kontroller icin controller classına yoneticilerin ıdlerini dondurecek olan metot.
        {
            List<string> YoneticiID = new List<string>();
            foreach (Kullanici item in buf.Kullanicilar)
            {
                if (item is Yonetici)
                {
                    YoneticiID.Add(item.ID);
                }
            }
            return YoneticiID;
        }

        // Parametre olarak ıd ve sıfre alacak geriye true false seklinde dogru sıfre kontrolu ıcın gereken metot. Veritabanında kayıtlı olan sifreyle 
        //parametre olarak geleni karsılastıracak.
        public bool PasswordCheck(string id,string sifre)
        {
            foreach (Kullanici item in buf.Kullanicilar)
            {
                if (item.ID == id && item.Sifre == sifre)
                {
                    return true;
                }
            }
            return false; ;
        }

        // Kullanıcı Ekleme metodu. Parametre olarak kullanıcı nesnesinin gereklerini alacak.
        public bool AddCostumer(string id,string name,string surname,string password)
        {
            try
            {
                buf.Kullanicilar.Add(new Musteri(id, name, surname, password));
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Musteri kaydedilirken bir hata olustu !!");
            }
        }

        public bool AddAdmin(string id, string name, string surname, string password)
        {
            try
            {
                buf.Kullanicilar.Add(new Yonetici(id, name, surname, password));
                return true;
            }
            catch (Exception)
            {

                throw new Exception("Yonetici kaydedilirken bir hata olustu !!");
            }
        }

        // Id ve sifre alacak sifreyi o ıdnın yeni sifresi yapacak.
        public bool PasswordChange(string id,string password)
        {
            try
            {
                foreach (Kullanici item in buf.Kullanicilar)
                {
                    if (item.ID == id)
                    {
                        item.Sifre = password;
                    }
                }
                return true;
            }
            catch (Exception)
            {

                throw new Exception("Sifre degistirmek istendi ancak bir hata sebebiyle degistirilemedi !!");
            }

        }


        // Ad veya soyad gelecek hangisi geldiyse onu degistiricem ??????



       
    }
}
