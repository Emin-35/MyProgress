using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Kurs kurs1 = new Kurs();

            kurs1.Izlenme = 68;
            kurs1.Hoca = "Lucky";
            kurs1.İsim = "C#";

            Kurs kurs2 = new Kurs();

            kurs2.Izlenme = 64;
            kurs2.Hoca = "Ali";
            kurs2.İsim = "Python";

            Kurs kurs3 = new Kurs();

            kurs3.Izlenme = 110;
            kurs3.Hoca = "Mehmet";
            kurs3.İsim = "Java";

            Kurs[] Kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs x in Kurslar)
            {
                Console.WriteLine(x.İsim + " : " + x.Hoca + " : " + x.Izlenme);
            }


        }
    }


    class Kurs
    {
        // (prop tab tab)
        public int Izlenme { get; set; }

        public string Hoca { get; set; }
        public string İsim { get; set; }
    }


}
