using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Interface'i birbinin alternatifi olan ancak kod içeriği farklı olan durumlar için kullanırız
    //Calculate imzamız ve bütün kredi türlerinde aynı ancak her krediyi farklı şekillerde hesaplama yapılacağı için interface kullanılır
    //Interface sablon görevi görür ve sadece imza konulabilir
    // Süslü parantez yok ve anlamlı olması için başa "I" konulur!
      interface IKrediManager
      {
        public void Calculate();
      }
}
