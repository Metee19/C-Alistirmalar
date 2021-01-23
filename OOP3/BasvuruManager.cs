using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    { 
        //Method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggers)
        {
            //Başvuru bilgilerini değerlendirme
            //
            foreach (var loggerService in loggers)
            {
                loggerService.Log();
            }
            krediManager.Hesapla();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
