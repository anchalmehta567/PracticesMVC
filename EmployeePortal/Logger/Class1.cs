using System;
using System.IO;
using System.Text;

namespace Logger
{
    public sealed class Log:ILog
    {
        private static int counter = 0;
        private Log()
        {
           
        }

        //private static readonly object obj = new object();
        //To achive lazy looger we follow three stpes 
        //change null intialization to singletone
        //private static Singletone instance = null;
        //change it to readonly property
        //remove the double locking change

        //        private static readonly Singletone instance = new Singletone();


        //lazy intialization
        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());
        public static Log GetInstance
        {
            get
            {
                /* 
                 if (instance == null) 
                  {
                      lock (obj)
                      {
                          if (instance == null)
                              instance = new Singletone();      
                      }
                   }   
                
                */
                return instance.Value;
            }
        }

        public void Logexception(string message)
        {
            string FileName = string.Format("{0}_{1}.log", "Exception", DateTime.Now.ToShortDateString());

            string LogFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, FileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------------------------");
            sb.AppendLine(DateTime.Now.ToString());

            sb.AppendLine(message);

            using (StreamWriter writer = new StreamWriter(LogFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
