using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerServices)
        {
            krediManager.Hesapla();
            
        }
        //listedeki her kredinin hesabını yap
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        internal void BasvuruYap(EsnafKrediManager esnafKrediManager, List<ILoggerService> loggers)
        {
            throw new NotImplementedException();
        }
    }
}
