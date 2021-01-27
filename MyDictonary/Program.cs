using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string> things = new MyDictonary<string>();
            things.Add("csgo");
            things.Add("pubg");
        }
    }
}
