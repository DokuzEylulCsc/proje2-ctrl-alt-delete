using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otel_Rezervasyon_Sistemi.ModelsAndBuffer;

namespace Otel_Rezervasyon_Sistemi.Controllers
{
    class FilterController
    {
        internal FilterController()
        {

        }
        private Core core = new Core();
        /// <summary>
        /// butun filtreler uygulandiginda cagirilicak method Tam olarak istenileni donduru eger TV secilmemis ise icerisinde TV olmayan ve diger kosullara uygun olanlari dondurur
        /// </summary>
        /// <param name="hotelType">Otel tipini dogrudan comboboxdaki gibi gonder</param>
        /// <param name="roomType">Oda tipini dogrudan comboboxdaki gibi gonder</param>
        /// <param name="point">odada aranan minimum yildiz puani</param>
        /// <param name="minPrice">odanin mininmum fiyati</param>
        /// <param name="maxPrice">odanin maximum fiyati</param>
        /// <param name="wifi"></param>
        /// <param name="minibar"></param>
        /// <param name="klima"></param>
        /// <param name="televizyon"></param>
        /// <param name="start">baslangic tarihi</param>
        /// <param name="end">bitis tarihi</param>
        /// <returns>"OtelID-OtelAdi-OdaNumarasi" formatinda elemanlari olan bir string listesi dondurur</returns>
        public List<string> HotelFilter(string hotelType, string roomType, int point, int minPrice, int maxPrice, bool wifi, bool minibar, bool klima, bool televizyon, DateTime start, DateTime end)
        {
           
            List<string> hotelIDandNamesandStars = core.ReturnOtelInformations(hotelType);
            List<string> hotelIDs = new List<string>();
            List<string> hotelNames = new List<string>();
            List<string> hotelStars = new List<string>();
            foreach (string s in hotelIDandNamesandStars)
            {
                hotelIDs.Add(s.Split('-')[0]);
                hotelNames.Add(s.Split('-')[1]);
                hotelStars.Add(s.Split('-')[2]);
            }
            List<string> roomie = new List<string>();
            List<List<string>> roomsOfHotel = new List<List<string>>();
            for (int i = 0; i < hotelIDs.Count; i++)
            {
                if (Convert.ToInt32(hotelStars[i]) >= point)
                {

                    List<Oda> rooms = core.ReturnRoomObjects(hotelIDs[i]);

                    foreach (Oda o in rooms)
                    {
                        bool available = true;
                        if (roomType == "Kral Dairesi" && o is KralDairesi)
                        {
                            if (o.Klimali == klima && o.Televizyonlu == televizyon && o.Minibarli == minibar && o.Wifili == wifi && o.OdaFiyati > minPrice && o.OdaFiyati < maxPrice)
                            {
                                foreach (Rezervasyon r in o.Rezervasyonlar)
                                {
                                    if ((r.RezBaslangic < start && r.RezBitis > start) || (r.RezBaslangic < end && r.RezBitis > end))
                                    {
                                        available = false;
                                    }
                                }
                                if (available)
                                {
                                    roomie.Add(hotelIDs[i] + "-" + hotelNames[i] + "-" + o.OdaNo.ToString());
                                }
                            }
                        }
                        else if (roomType == "Manzarali" && o is ManzaraliOda)
                        {
                            if (o.Klimali == klima && o.Televizyonlu == televizyon && o.Minibarli == minibar && o.Wifili == wifi && o.OdaFiyati > minPrice && o.OdaFiyati < maxPrice)
                            {
                                foreach (Rezervasyon r in o.Rezervasyonlar)
                                {
                                    if ((r.RezBaslangic < start && r.RezBitis > start) || (r.RezBaslangic < end && r.RezBitis > end))
                                    {
                                        available = false;
                                    }
                                }
                                if (available)
                                {
                                    roomie.Add(hotelIDs[i] + "-" + hotelNames[i] + "-" + o.OdaNo.ToString());
                                }
                            }
                        }
                        else if (roomType == "Standart" && o is StandartOda)
                        {
                            if (o.Klimali == klima && o.Televizyonlu == televizyon && o.Minibarli == minibar && o.Wifili == wifi && o.OdaFiyati > minPrice && o.OdaFiyati < maxPrice)
                            {
                                foreach (Rezervasyon r in o.Rezervasyonlar)
                                {
                                    if ((r.RezBaslangic < start && r.RezBitis > start) || (r.RezBaslangic < end && r.RezBitis > end))
                                    {
                                        available = false;
                                    }
                                }
                                if (available)
                                {
                                    roomie.Add(hotelIDs[i] + "-" + hotelNames[i] + "-" + o.OdaNo.ToString());
                                }
                            }
                        }
                    }


                }
            }
            if (roomie.Count > 0)
            {
                return roomie;
            }
            else
            {
                throw new Exception("Bu filtreye uygun bos oda bulunamiyor");
            }
        }
    }
}
