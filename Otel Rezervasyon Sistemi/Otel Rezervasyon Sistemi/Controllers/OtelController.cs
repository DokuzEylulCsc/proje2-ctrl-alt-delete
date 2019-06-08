using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.Controllers
{
    class OtelController
    {
        internal OtelController()
        {

        }

        /// <summary>
        /// Otelin butun rezervasyon bilgilerini dondurur
        /// </summary>
        /// <param name="otelid">Rezervasyonu sorgulanmak istenen otelin idsi</param>
        public  void GetReservations(string otelid)
        {
            /*
             * otelin butun rezervasyonlarini dondurucek olan id 
             */
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
        public  void AddHotel(string otelid , string otelname, string oteltype,int temizlik ,int konum , int hizmet)
        {
            /*
             * gerekli implementasyon yapilacaka duruma gore parametre eklenip cikartilacak 
             * sadece bir templatedir
             */
        }
        /// <summary>
        /// genel listeden otel siler 
        /// </summary>
        /// <param name="hotelId">silinmek istenen otelIdsi </param>
        public  void DeleteHotel(string hotelId)
        {
            /*
             * gerekli implementasyon yapilacaka duruma gore parametre eklenip cikartilacak 
             * sadece bir templatedir
             */
        }

        /*
         * duruma gore ekstra fonksiyonlar eklenebilir simdilik aklima gelenler bu kadar 
         */
    }
}
