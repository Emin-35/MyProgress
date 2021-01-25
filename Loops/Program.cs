using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop -> Recursive Fonksiyon

            for (int i = 0; i <= 20; i = i + 5)
            {
                Console.WriteLine(i);
            }

            // array -> diziler !

            string p1 = "kedi";
            string p2 = "köpek";
            string p3 = "balık";
            string p4 = "kuş";
            string p5 = "kurt";

            // Dizi veya List oluşturma
            string[] hayvanlar = new string[] { p1, p2, p3, p4, p5 };

            // Böyle yazarsak i>5 olduğu zaman çalışmaz ayrıca sadece rakamlar için çalışır string için çalışmaz !
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // Böyle yazılırsa daha dinamik bir şekilde çalışır 
            for (int i = 0; i < hayvanlar.Length; i++)
            {
                Console.WriteLine(hayvanlar[i]);
            }

            // Dizileri (Listeleri) başka bir şekilde yazmanın yolu 
            // "var" yerine "string" "int" "double" da yazılabilir elemanın türünü belirtir 

            foreach (var x in hayvanlar)
            {
                Console.WriteLine(x);
            }

        }
    }
}
