using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prt1 = new Product();
            prt1.ID = 12;
            prt1.Name = "Phone";
            prt1.Discription = "Smart";

            Product prt2 = new Product(17,"PC","Gaming");

            Product prt3 = new Product { ID = 33, Name = "Mouse", Discription = "RGB" };

            Product[] Allproduct = new Product[] { prt1, prt2, prt3 };

            SepetManager SptMng = new SepetManager();

            SptMng.Add(prt1);
            SptMng.Add(prt2);
            SptMng.Add(prt3);
        }
    }
}
