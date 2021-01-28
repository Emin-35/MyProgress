using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasıtKrediManager : IKrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi hesaplandı");
        }
    }
}
