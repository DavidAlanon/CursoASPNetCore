using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {

        static void Main(string[] args)
        {
            List<ILogger> loggers = new List<ILogger>();
            loggers.Add(new DataBaseLogger());
            loggers.Add(new ConsoleLogger());

            MetodoQueHaceAlgo(loggers);

           // var logger = new ILogger();
           try
           {

               // Este método "casca" y queremos "logear" la excepción
               throw new ArgumentNullException();

           }

           catch(ArgumentNullException ex)
           {
               // Se ha producido un error de argumento nulo, quiero guardar el error
               foreach (var logger in loggers)
               {
                   logger.LogError(ex.StackTrace);
               }

           }
        }

        private static void MetodoQueHaceAlgo(List<ILogger> loggers)
        {
             // cualquier instrucción, operación...
             foreach (var logger in loggers)
             {
                 logger.LogInfo("He pasado por MetodoQueHaceAlgo");
             }
        }
    }

    public interface ILogger
    {
        void LogError(string LogMessage);
        void LogInfo(string LogMessage);

        string GetStorage();

    }

    public class ConsoleLogger : ILogger
    {
        public string GetStorage()
        {
            return "Console";
        }

        public void LogError(string LogMessage)
        {
            Console.WriteLine("Error volcado en consola: " + LogMessage);
        }

        public void LogInfo(string LogMessage)
        {
            Console.WriteLine("Información volcada en Consola: " + LogMessage);
        }
    }


    public class DataBaseLogger : ILogger
    {
        public string GetStorage()
        {
            return "DB";
        }

        public void LogError(string LogMessage)
        {
            Console.WriteLine("Error guardado en DB: " + LogMessage);
        }

        public void LogInfo(string LogMessage)
        {
            Console.WriteLine("Información guardada en DB: " + LogMessage);


        }
    }
}
