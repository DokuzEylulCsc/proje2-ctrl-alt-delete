using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    class ExceptionHandler:Exception
    {
        public ExceptionHandler(string message , string methodName , string className , string defultMesage):base(defultMesage)
        {
            
            using (FileStream fs = new FileStream(@"../ExceptionLog.txt", FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Mesaj : " + message + " Method Name : " + methodName + " Class Name : " + className);
                    sw.Close();
                    fs.Close();
                }
            }
        }
    }
    class MessageException : Exception
    {
        public MessageException(string message) : base(message)
        {

        }
    }
}
