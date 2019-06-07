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
        /// <summary>
        /// Oda filtreleme icin cagirilmasi gereken method
        /// </summary>
        /// <param name="hotelType">Otel tipi string ["Butik" , "TatilKoyu" , "Pansiyon"]</param>
        /// <param name="roomType">Oda tipi string ["Standart" , "Manzarali" , "KralDairesi"]</param>
        /// <param name="minPoint">int alt puan</param>
        /// <param name="minPrice">int alt fiyat</param>
        /// <param name="maxPrice">int ust fiyat</param>
        /// <param name="start">datetime baslangic tarihi</param>
        /// <param name="finish">date time bitis tarihi</param>
        /// <param name="checks">oda Ozellikleri </param>
        /// <returns></returns>
        public List<Oda> RoomFilter(string hotelType , string roomType , int minPoint , int minPrice , int maxPrice , DateTime start , DateTime finish , bool[] checks)
        {
            List<Otel> hotels = new List<Otel>();
            if(hotelType == "Butik")
            {
                //get Butiks from core
            }else if(hotelType == "TatilKoyu")
            {
                //get TatilKoyu from core
            }else if(hotelType == "Pansiyon")
            {
                //get pansiyon from core
            }
            else
            {
                throw new Exception("Bu tipte bir otel bulunmamaktadir");
            }
            List<Oda> _temp = new List<Oda>();
            if(roomType == "Manzarali")
            {
                foreach(Otel o in hotels)
                {
                    foreach(Oda _o in o.Odalar )
                    {
                        if(o.Hizmet+o.Konum+o.Temizlik >= minPoint)
                        {
                            if (_o is ManzaraliOda && _o.OdaFiyati > minPrice && _o.OdaFiyati < maxPrice/*rezervasyon kontrolleri eklenicek*/)
                            {
                                _temp.Add(_o);
                            }
                        }
                        
                    }
                }
            }
            else if(roomType == "Standart")
            {

                foreach (Otel o in hotels)
                {
                    foreach (Oda _o in o.Odalar)
                    {
                        if (o.Hizmet + o.Konum + o.Temizlik >= minPoint)
                        {
                            if (_o is StandartOda && _o.OdaFiyati > minPrice && _o.OdaFiyati < maxPrice/*rezervasyon kontrolleri eklenicek*/)
                            {
                                _temp.Add(_o);
                            }
                        }

                    }
                }
            }
            else if (roomType == "KralDairesi")
            {
                foreach (Otel o in hotels)
                {
                    foreach (Oda _o in o.Odalar)
                    {
                        if (o.Hizmet + o.Konum + o.Temizlik >= minPoint)
                        {
                            if (_o is KralDairesi && _o.OdaFiyati > minPrice && _o.OdaFiyati < maxPrice/*rezervasyon kontrolleri eklenicek*/)
                            {
                                _temp.Add(_o);
                            }
                        }

                    }
                }
            }
            else
            {
                throw new Exception("Boyle bir oda tipi bulunamadi");
            }
            return _temp;

        }
    }
}
