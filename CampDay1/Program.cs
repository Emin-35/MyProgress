using System;

namespace CampDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool abc = true;

            int x = 10;
            int y = 5;

            if (abc == true)
            {
                Console.WriteLine("Welcome");
            }

            else
            {
                Console.WriteLine("Log in");
            }

            if (x > y) 
            {
                Console.WriteLine("Positive");
            }
            else if (x < y)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Stabile");
            }

        }
    }
}
