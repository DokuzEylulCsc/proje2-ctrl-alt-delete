using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Otel_Rezervasyon_Sistemi.Controllers
{
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


        private MainController()
        {
            filterController = new FilterController();
            otelController = new OtelController();
            roomController = new RoomController();
            userController = new UserController();
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
            if (instance == null)
            {
                instance = new MainController();
            }
            return instance;
        }
    }
}
