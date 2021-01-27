using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
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
                D[] temparray = items;
                items = new D[items.Length];

                for (int i = 0; i < items.Length; i++)
                {
                    items[i] = temparray[i];
                }

                items[items.Length - 1] = key;
            }
        }
    }
