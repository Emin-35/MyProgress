using System;
using System.Collections.Generic;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Emre", "Melih","Halil","Mehmet"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);

            //4 elelmanlı bir dizinin içine 5.elemanı böyle koyamayız
            //çünkü new heap'de yeni bir referans alıyor ve 5 elemanlı ancak 4 elemanı boş olan bir dizi oluşturuyor
            isimler = new string[5];
            Console.WriteLine(4);
            Console.WriteLine(1);

            //Yanda çıkan ampulden using System.Collections.Generic; eklemelisin
            //List ile koleksiyon kuruluyor !
            List<string> isimler2 = new List<string> {"Emre", "Melih", "Halil", "Mehmet"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);

            //Bu şekilde yeni eleman eklenir
            isimler2.Add("Emin");
            Console.WriteLine(isimler2[4]);

        }
    }
}
