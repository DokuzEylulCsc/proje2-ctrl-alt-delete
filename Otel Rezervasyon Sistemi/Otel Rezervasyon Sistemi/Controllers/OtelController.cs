using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.Controllers
{
    class OtelController
    {
        private ModelsAndBuffer.Core core = new ModelsAndBuffer.Core();
        internal OtelController()
        {

        }

        /// <summary>
        /// Otelin butun rezervasyon bilgilerini dondurur
        /// </summary>
        /// <param name="otelid">Rezervasyonu sorgulanmak istenen otelin idsi</param>
        public List<ModelsAndBuffer.Rezervasyon> GetReservations(string otelid)
        {
            try
            {
                List<string> IDs = core.ReturnHotelID();
                if (IDs.Contains(otelid))
                {

                    List<ModelsAndBuffer.Oda> rooms = core.ReturnRoomObjects(otelid);
                    List<ModelsAndBuffer.Rezervasyon> rezervasyons = new List<ModelsAndBuffer.Rezervasyon>();
                    foreach (ModelsAndBuffer.Oda room in rooms)
                    {
                        rezervasyons.AddRange(room.Rezervasyonlar);
                    }
                    return rezervasyons;


                }
                else
                {
                    throw new MessageException("Boyle Bir Otel IDsi yok");
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
        /// Otel Ekleme Fonksiyonu
        /// </summary>
        /// <param name="otelid">Eklenicek olan otelin idsi</param>
        /// <param name="otelname">Eklenicez olan otelin ismi</param>
        /// <param name="oteltype">eklenicek olan otelin tipi {Pansiyon,Tatil,Butik}</param>
        /// <param name="temizlik">temizlik puani</param>
        /// <param name="konum">konum puani</param>
        /// <param name="hizmet">hizmet puani</param>
        public bool AddHotel(string otelid, string otelname, string oteltype, int temizlik, int konum, int hizmet)
        {
            try
            {

                List<string> IDs = core.ReturnHotelID();
                if (!IDs.Contains(otelid))
                {
                    core.AddOtel(temizlik, konum, hizmet, otelid, otelid, oteltype);
                    return true;
                }
                else
                {
                    throw new MessageException("Boyle bir otel ID zaten bulunmaktadir");
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
                throw new ExceptionHandler("Otel Ekleme Hatasi", "AddHotel()", "OtelController", e.Message);
            }

        }
        /// <summary>
        /// genel listeden otel siler 
        /// </summary>
        /// <param name="hotelId">silinmek istenen otelIdsi </param>
        public bool DeleteHotel(string hotelId)
        {
            try
            {

                List<string> IDs = core.ReturnHotelID();

                if (IDs.Contains(hotelId))
                {
                    core.DeleteOtel(hotelId);
                    return true;
                }
                else
                {
                    throw new MessageException("Boyle bir otel ID bulunamadi");
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
                throw new ExceptionHandler("Otel Silme Hatasi", "DeleteHotel()", "OtelController", e.Message);
            }


        }

        /*
         * duruma gore ekstra fonksiyonlar eklenebilir simdilik aklima gelenler bu kadar 
         */
    }
}
