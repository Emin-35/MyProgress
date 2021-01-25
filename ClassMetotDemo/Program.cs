using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerName Cus1 = new CustomerName();
            Cus1.Name = "Ahmet Vefik";
            Cus1.ID = "12345678";
            Cus1.MoneyAmount = 36540;

            CustomerName Cus2 = new CustomerName();
            Cus2.Name = "Ali Görmüş";
            Cus2.ID = "32456890";
            Cus2.MoneyAmount = 44322;

            CustomerName Cus3 = new CustomerName();
            Cus3.Name = "Mustafa Kırık";
            Cus3.ID = "45678932";
            Cus3.MoneyAmount = 9865;

            CustomerName[] Customers = new CustomerName[] { Cus1, Cus2, Cus3 };

            CustomerManager Listing = new CustomerManager();
            Listing.List(Cus1,Cus2);
            Listing.List(Cus3,Cus1);

            CustomerManager Adding = new CustomerManager();
            Adding.Add(Cus2);
            Adding.Add(Cus1);

            CustomerManager Deleting = new CustomerManager();
            Deleting.Delete(Cus2);
            Deleting.Delete(Cus1);
            Deleting.Delete(Cus3);
        }
    }
}
