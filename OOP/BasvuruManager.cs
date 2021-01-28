using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        public void BasvuruYapSingleLogger(IKrediManager kredituru, ILoggerService logger)
        {
            kredituru.Calculate();
            logger.Log();

        }
        public void BasvuruYapMultiLogger(IKrediManager kredituru, List<ILoggerService> loggers) 
        {

            //Eğer böyle yapılırsa "Başvuru Yap" class'ını kredi bağımsız hale getirmiş oluruz
            kredituru.Calculate();
            foreach (var x in loggers)
            {
                x.Log();
            }
        }

        public void BasvuruOnBilgilendirmesi(List<IKrediManager> krediler)
        {
            foreach (var x in krediler)
            {
                x.Calculate();
            }
        
        }
    }
}
