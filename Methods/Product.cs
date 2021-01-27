using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Product
    {

        public Product()
        {

        }

        //Defult constroctor (ctor tab tab)
        public Product(int id, string name, string discriptiton)
        {
            ID = id;
            Name = name;
            Discription = discriptiton;
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Discription { get; set; }

    }
}
