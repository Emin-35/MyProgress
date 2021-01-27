using System;
using System.Collections.Generic;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string> things = new MyDictonary<string>();
            things.Add("metal");
            things.Add("pc");

            List<string> games = new List<string> { "GTA", "CSGO" };
            games.Add("PUBG");
        }
    
    }
}
