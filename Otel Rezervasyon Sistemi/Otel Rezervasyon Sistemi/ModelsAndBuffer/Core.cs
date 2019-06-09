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
            else if (type == "Butik Otel")
            {
                buf.Oteller.Add(new ButikOtel(temizlik, konum, hizmet, otelid, oteladi));
                return true;
            }
            else if (type == "Tatil Köyü")
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
        public List<Oda> ReturnRoomObjects(string otelid)
        {
            List<Oda> Odalar = new List<Oda>();
            foreach (Otel item in buf.Oteller)
            {
                Odalar.AddRange(item.Odalar);
            }
            return Odalar;
        }

        //RoomController islemlerinin metotlari

        // Oda Idlerini dondurecek metot.
        public List<int> ReturnRoomIds(string whichotelıd)
        {
            List<int> RoomID = new List<int>();
            foreach (Otel item in buf.Oteller)
            {
                if (whichotelıd == item.ID)
                {
                    foreach (Oda item2 in item.Odalar)
                    {
                        RoomID.Add(item2.OdaNo);
                    }
                }     
            }
            return RoomID;
        }

        
        // Oda Ekleme Metodu
        public bool AddRoom(string otelid,string type, int fiyat, int kisikapasite, int odanumarasi, bool klima, bool wifi, bool minibar, bool televizyon)
        {
            foreach (Otel item in buf.Oteller)
            {
                if (otelid == item.ID)
                {
                    if (type == "Standart")
                    {
                        item.Odalar.Add(new StandartOda(fiyat, kisikapasite, odanumarasi, klima, wifi, minibar, televizyon));
                        return true;
                    }
                    else if (type == "Manzarali")
                    {
                        item.Odalar.Add(new ManzaraliOda(fiyat, kisikapasite, odanumarasi, klima, wifi, minibar, televizyon));
                        return true;
                    }
                    else if (type == "Kral Dairesi")
                    {
                        item.Odalar.Add(new KralDairesi(fiyat, kisikapasite, odanumarasi, klima, wifi, minibar, televizyon));
                        return true; 
                    }
                }
            }
            throw new Exception("Otele oda eklenirken bir hata olustu. Yeniden deneyin");
        }

        // Oda silme metodu.
        public bool DeleteRoom(string whichotel,int whichroom)
        {
            for (int i = 0; i < buf.Oteller.Count; i++)
            {
                if (whichotel == buf.Oteller[i].ID)
                {
                    for (int j = 0; j < buf.Oteller[i].Odalar.Count; j++)
                    {
                        if (whichroom == buf.Oteller[i].Odalar[j].OdaNo)
                        {
                            buf.Oteller[i].Odalar.Remove(buf.Oteller[i].Odalar[j]);
                            return true;
                        }
                    }
                }
            }
            throw new Exception("Oda Silinirken Bir Hata Olustu. Tekrar Deneyin !!");           
        }


        // Spesifik olarak bir odaya ait olan rezervasyonları donduren metot.
        public List<Rezervasyon> ReservationofRoom(string whichotel,int roomnumber)
        {         
            foreach (Otel item in buf.Oteller)
            {
                if (whichotel == item.ID)
                {
                    foreach (Oda item2 in item.Odalar)
                    {
                        if (roomnumber == item2.OdaNo)
                        {
                            return item2.Rezervasyonlar;
                        }
                    }

                }
            }
            throw new Exception("Bir hata olustu");
        }
       
        public bool AddReservation(string otelid,string costumerid, int roomnumber,DateTime baslangic,DateTime bitis)
        {
            foreach (Otel item in buf.Oteller)
            {
                if (otelid == item.ID)
                {
                    foreach (Oda item2 in item.Odalar)
                    {
                        if (roomnumber == item2.OdaNo)
                        {
                            foreach (Musteri item3 in buf.Kullanicilar)
                            {
                                if (costumerid == item3.ID)
                                {
                                    item2.Rezervasyonlar.Add(new Rezervasyon(baslangic, bitis,otelid,roomnumber));
                                    item3.ReservationofCostumer.Add(new Rezervasyon(baslangic, bitis, otelid, roomnumber));
                                    return true;
                                }
                            }
                            
                        }
                    }
                }
            }
            throw new Exception("Rezervasyon eklenirken bir hata olustu");
            
        }
        
        // Rezervasyon Silme Metodu.
        public bool DeleteReservation(string otelid,int roomnumber,string customerid,int rezid)
        {
            try
            {
                for (int i = 0; i < buf.Oteller.Count; i++)
                {
                    if (otelid == buf.Oteller[i].ID)
                    {
                        for (int j = 0; j < buf.Oteller[i].Odalar.Count; j++)
                        {
                            if (roomnumber == buf.Oteller[i].Odalar[j].OdaNo)
                            {
                                for (int t = 0; t < buf.Oteller[i].Odalar[j].Rezervasyonlar.Count; t++)
                                {
                                    if (rezid == buf.Oteller[i].Odalar[j].Rezervasyonlar[t].RezID)
                                    {
                                        buf.Oteller[i].Odalar[j].Rezervasyonlar.Remove(buf.Oteller[i].Odalar[j].Rezervasyonlar[t]);
                                    }
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < buf.Kullanicilar.Count; i++)
                {
                    if (customerid == buf.Kullanicilar[i].ID)
                    {
                        for (int j = 0; j < ((Musteri)buf.Kullanicilar[i]).ReservationofCostumer.Count; j++)
                        {
                            if (rezid == ((Musteri)buf.Kullanicilar[i]).ReservationofCostumer[j].RezID)
                            {
                                ((Musteri)buf.Kullanicilar[i]).ReservationofCostumer.Remove(((Musteri)buf.Kullanicilar[i]).ReservationofCostumer[j]);

                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {

                throw new Exception("Rezervasyon silinirken bir hata olustu !! Yeniden Deneyin");
            }          
        }

        // Filter Controller icin gerekli Otel Informations metodu
        public List<string> ReturnOtelInformations(string type)
        {
            string temp;
            List<string> ReturnsItems = new List<string>();
            if (type == "Pansiyon")
            {
                foreach (Otel item in buf.Oteller)
                {
                    if (item is Pansiyon)
                    {
                        temp = item.ID + "-" + item.OtelAdi + "-" + item.OtelYildiz;
                        ReturnsItems.Add(temp);
                    }                 
                }
                return ReturnsItems;
            }
            else if (type == "Butik Otel")
            {
                foreach (Otel item in buf.Oteller)
                {
                    if (item is ButikOtel)
                    {
                        temp = item.ID + " - " + item.OtelAdi + "-" + item.OtelYildiz;
                        ReturnsItems.Add(temp);
                    }                 
                }
                return ReturnsItems;
            }
            else if (type == "Tatil Köyü")
            {
                foreach (Otel item in buf.Oteller)
                {
                    if (item is TatilKoyu)
                    {
                        temp = item.ID + " - " + item.OtelAdi + "-" + item.OtelYildiz;
                        ReturnsItems.Add(temp);
                    }                   
                }
                return ReturnsItems;
            }

            throw new Exception("Bir hata olustu. Yeniden Deneyin !!");
          
        }








    }
}
