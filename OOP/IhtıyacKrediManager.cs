using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Gelen ampulden "Implement interface" seçerek interface'de olan özellikleri otomatik ekleyebilirsin
    class IhtıyacKrediManager : IKrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplandı");
        }
    }
}
