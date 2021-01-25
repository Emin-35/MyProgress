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

            Product prt2 = new Product();
            prt2.ID = 17;
            prt2.Name = "Pc";
            prt2.Discription = "Gaming";

            Product prt3 = new Product();
            prt3.ID = 33;
            prt3.Name = "Mouse";
            prt3.Discription = "RGB";

            Product[] Allproduct = new Product[] { prt1, prt2, prt3 };

            SepetManager SptMng = new SepetManager();

            SptMng.Add(prt1);
            SptMng.Add(prt2);
            SptMng.Add(prt3);
        }
    }
}
