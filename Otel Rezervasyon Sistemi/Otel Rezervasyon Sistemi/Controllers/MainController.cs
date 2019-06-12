using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Otel_Rezervasyon_Sistemi.Controllers
{
    /* Controller classi Buffer ve modeller ile Formlar arasinda ADAPTOR DESIGN PATTERN Sistemi ile Tanimlanip
     * bir ADAPTOR olarak kullanilmaktadir
     */
    class MainController
    {

        private static MainController instance = null;
        private FilterController filterController = null;
        public FilterController filter { get { return filterController;  } }
        private OtelController otelController = null;
        public OtelController otel { get { return otelController; } }
        private RoomController roomController = null;
        public RoomController room { get { return roomController; } }
        private UserController userController = null;
        public UserController user { get { return userController; } }
        private ReservationController reservationController = null;
        public ReservationController ReservationController { get { return reservationController; } }


        private MainController()
        {
            filterController = new FilterController();
            otelController = new OtelController();
            roomController = new RoomController();
            userController = new UserController();
            reservationController = new ReservationController();
        }

        /// <summary>
        /// mainController uzerinden butun controllerlara erisim saglanir. kod icerisinde 
        /// her ihtiyac olan controller icin farkli obje uretmeniz gerekmez
        /// </summary>
        /// <returns>
        /// Singleton object
        /// </returns>
        public static MainController GetController()
        {
            try
            {
                if (instance == null)
                {
                    instance = new MainController();
                }
                return instance;
            }
            catch(Exception e)
            {
                throw new ExceptionHandler("Singleton Constructor hatasi !", "GetController()", "Main Controller", e.Message);
            }
        }
        /// <summary>
        /// Objeleri XMLe Cekmek icin bitiste cagirilir
        /// </summary>
        public void SerializeAtEnd()
        {
            try
            {
                Otel_Rezervasyon_Sistemi.ModelsAndBuffer.Buffer b = Otel_Rezervasyon_Sistemi.ModelsAndBuffer.Buffer.BUF;
                b.Serialization();
            }
            catch(Exception e)
            {
                throw new ExceptionHandler("Serialization Hatasi !", " SerializeAtEnd()", "Main Controller", e.Message);
            }
        }
        /// <summary>
        /// XML elementleri objelestirmek icin baslangicta calisir
        /// </summary>
        public void DeserializeAtStart()
        {
            try
            {
                Otel_Rezervasyon_Sistemi.ModelsAndBuffer.Buffer b = Otel_Rezervasyon_Sistemi.ModelsAndBuffer.Buffer.BUF;
                b.Deserialization();
            }
            catch(ExceptionHandler a)
            {
                throw a;
            }
            catch(Exception e)
            {
                throw new ExceptionHandler("Deserialize Hatasi ! ", " DeserializeAtStart()", "MainController", e.Message);
            }
        }
    }
}
