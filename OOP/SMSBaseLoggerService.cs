using System;

namespace OOP3
{
    class SMSBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms yollandı");
        }
    }
}
