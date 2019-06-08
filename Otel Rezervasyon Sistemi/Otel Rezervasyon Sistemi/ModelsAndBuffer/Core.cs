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

        // User controller islemlerinin metotlari.

        // User Id listi dondurecek metot.(yonetici - musteri idler ayrı listelerde donecek)
        public List<string> ReturnCustomerId() // Gerekli kontroller icin controller classına musterilerin ıdlerini dondurecek olan metot.
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
        public List<string> ReturnAdminId() // Gerekli kontroller icin controller classına yoneticilerin ıdlerini dondurecek olan metot.
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
        public bool PasswordCheck(string id, string sifre)
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
        public bool AddCostumer(string id, string name, string surname, string password)
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
        public bool PasswordChange(string id, string password)
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
        public void InformationChange(string something, string id, string newInfo)
        {
            foreach (Kullanici item in buf.Kullanicilar)
            {
                if (id == item.ID)
                {
                    if (something == "Ad")
                    {
                        item.Ad = newInfo;
                    }
                    else if (something == "Soyad")
                    {
                        item.Soyad = newInfo;
                    }
                }
            }
        }

        // ID si verilen kullanicinin diger tum bilgilerini donduren metot ( password *** seklinde)
        public Kullanici ReturnInformations(string id)
        {
            foreach (Kullanici item in buf.Kullanicilar)
            {
                if (id == item.ID)
                {
                    return item;
                }
            }
            throw new Exception("Bir hata olustu !!");
        }

        // Otel Controller islemleri icin gerekli metotlar

        // Otel Id leri controllera dondurecek metot
        public List<string> ReturnHotelID()
        {
            List<string> HotelID = new List<string>();
            foreach (Otel item in buf.Oteller)
            {
                HotelID.Add(item.ID);
            }
            return HotelID;
        }

        //Otel Ekleme Metodu
        public bool AddOtel(int temizlik, int konum, int hizmet, string otelid, string oteladi, string type)
        {
            if (type == "Pansiyon")
            {
                buf.Oteller.Add(new Pansiyon(temizlik, konum, hizmet, otelid, oteladi));
                return true;
            }
            else if (type == "Butik")
            {
                buf.Oteller.Add(new ButikOtel(temizlik, konum, hizmet, otelid, oteladi));
                return true;
            }
            else if (type == "Tatil")
            {
                buf.Oteller.Add(new TatilKoyu(temizlik, konum, hizmet, otelid, oteladi));
                return true;
            }

            throw new Exception("Otel eklenirken bir hata olustu");
        }

        //  Otel Silme Metodu
        public bool DeleteOtel(string otelid)
        {
            for (int i = 0; i < buf.Oteller.Count; i++)
            {
                if (otelid == buf.Oteller[i].ID)
                {
                    buf.Oteller.Remove(buf.Oteller[i]);
                    return true;
                }
            }
            throw new Exception("Otel silerken bir hata olustu. Tekrar Deneyin !!");
            
        }

        // Rezervasyon Listesi Dondurecek metot
        public List<Rezervasyon> ReturnRezervasyon(string otelid)
        {
            List<Rezervasyon> Rezervasyonlar = new List<Rezervasyon>();
            foreach (Otel item in buf.Oteller)
            {
                foreach (Oda item2 in item.Odalar)
                {
                    Rezervasyonlar.AddRange(item2.Rezervasyonlar);
                }
            }
            return Rezervasyonlar;
        }

















        /*//RoomController islemlerinin metotlari

        // Oda Idlerini dondurecek metot.
        public List<int> ReturnRoomIds(string whichotelıd)
        {
            List<int> RoomID = new List<int>();
            foreach (Otel item in buf.Oteller)
            {
                foreach (Oda item2 in item.Odalar)
                {
                    RoomID.Add(item2.OdaNo);
                }
            }
            return RoomID;
        }

        //Otel Idleri dondurecek metot.
       */








    }
}
