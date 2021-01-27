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

            Mylist<string> games = new Mylist<string> ();
            games.Add("csgo");
            games.Add("pubg");

        }
        //Kendi Generic'ini oluşturma
        class Mylist<T>
        {
            T[] _array;

            //Mylist çalıştığında 1. olarak 0 elemanlı bir liste oluşturacak
            public Mylist()
            {
                _array = new T[0];
            }

            // Önceden içinde bulunan elemanlar gitmesin diye 2. olarak geçici bir generic oluşturuyoruz
            // Geçici oluşturduğumuz generic'i item sayısı 1 artacak şekilde orijinal generic'e bağlıyoruz
            public void Add(T item)
            {
                T[] temparray = _array;
                _array = new T[_array.Length+1];

                for (int i = 0; i < _array.Length; i++)
                {
                    _array[i] = temparray[i];
                }

                _array[_array.Length - 1] = item;
            }
        }

    }
}
