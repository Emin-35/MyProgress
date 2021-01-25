using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(CustomerName customer) 
        {
            Console.WriteLine("Customer Added : " + customer.Name);
        }

        public void List(CustomerName List, CustomerName List2)
        {
            Console.WriteLine("Customers Listed : " + List.Name + " : " + List.ID + " : " + List.MoneyAmount);
            Console.WriteLine("Customers Listed : " + List2.Name + " : " + List2.ID + " : " + List2.MoneyAmount);
        }

        public void Delete(CustomerName del) 
        {
            Console.WriteLine("Customers Deleted : " + del.Name + " : " + del.ID + " : " + del.MoneyAmount);
        }

    }
}
