using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class MyDictonary<D>
    {
        D[] items;
        public MyDictonary()
        {
            items = new D[0];
        }

        public void Add(D key)
        {
            D[] tempArray = items;
            items = new D[items.Length  +1];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = key;
        }
    }
}
