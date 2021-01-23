using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager EsnafKrediManager = new KonutKrediManager();

            ILoggerService DatabaseLoggerService = new DatabaseLoggerService();
            ILoggerService FileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new FileLoggerService(), new DatabaseLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager ,tasitKrediManager};

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
