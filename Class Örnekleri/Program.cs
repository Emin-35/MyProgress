using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Item item1 = new Item();

        item1.ItemID = "100-100000065BOX";
        item1.ItemName = "AMD RYZEN 5 5600X";
        item1.ItemPrice = 3055;

        Item item2 = new Item();

        item2.ItemID = "CMK16GX4M2Z4000C16";
        item2.ItemName = "CORSAIR 16GB Ram";
        item2.ItemPrice = 1932;

        Item item3 = new Item();

        item3.ItemID = "TUF GAM X570-PLUS";
        item3.ItemName = "ASUS TUF X570-PLUS Anakart";
        item3.ItemPrice = 2269;

        Item item4 = new Item();

        item4.ItemID = "TUF-RTX3090-O24G-GAMING";
        item4.ItemName = "ASUS TUF GeForce RTX 3090 Ekran Kartı";
        item4.ItemPrice = 21657;

        Item[] items = new Item[] { item1, item2, item3, item4 };

        Console.WriteLine("Foreach Part:");
        Console.WriteLine("-----------------");

        foreach (Item x in items)
        {
            Console.WriteLine(x.ItemName + " : " + x.ItemPrice + " : " + x.ItemID);

            Console.WriteLine("-----------------");
        }


        Console.WriteLine("For Part:");
        Console.WriteLine("-----------------");

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i].ItemName + " : " + items[i].ItemPrice + " : " + items[i].ItemID);

            Console.WriteLine("-----------------");

            Console.WriteLine("While Part:");
            Console.WriteLine("********************");
        }

        int a = 0;

        while (items.Length > a)
        {
            Console.WriteLine(items[a].ItemName + " : " + items[a].ItemPrice + " : " + items[a].ItemID);
            a++;
            Console.WriteLine("-----------------");
        }
    }

    class Item
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
    }

}