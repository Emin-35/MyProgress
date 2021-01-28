using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // IhtıyacKrediManager yerine IKrediManager dersek de aynı sonucu alırız
            //Çünkü IhtiyacKrediManager, alt yapı olarak IKerdiManager'ı kullanıyor
            IKrediManager ihtiyaçKredi = new IhtıyacKrediManager();
            TasıtKrediManager tasıtKredi = new TasıtKrediManager();
            IKrediManager konutKredi = new KonutKrediManager();

            //Loglama servisleri
            DataBaseLoggerService databaseLogger = new DataBaseLoggerService();
            ILoggerService fileLogger = new FileLoggerService();
            SMSBaseLoggerService smsLogger = new SMSBaseLoggerService();

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyaçKredi,tasıtKredi,konutKredi};
            List<ILoggerService> loggerlar = new List<ILoggerService>() { databaseLogger, smsLogger };

            //SingleLoggerŞekli
            BasvuruManager başvuruS = new BasvuruManager();
            başvuruS.BasvuruYapSingleLogger(tasıtKredi, fileLogger);
            başvuruS.BasvuruYapSingleLogger(ihtiyaçKredi, smsLogger);

            //Bu şekilde farklı kredilere de başvuru yapılabiliyor
            //MultiLoggerŞekli
            BasvuruManager başvuruM = new BasvuruManager();
            başvuruM.BasvuruYapMultiLogger(konutKredi, loggerlar);
            başvuruM.BasvuruYapMultiLogger(tasıtKredi, loggerlar);

            BasvuruManager onBilgilendirme = new BasvuruManager();
            onBilgilendirme.BasvuruOnBilgilendirmesi(krediler);

           
        }
    }
}
