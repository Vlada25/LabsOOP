using System;
using System.Collections.Generic;
using System.Text;

namespace MyArrayLibrary
{
    public class Service
    {
        public static MyArray CreateArrayByRandom(int len)
        {
            MyArray myArray = new MyArray(new double[len]);

            Random random = new Random();

            for (int i = 0; i < len; i++)
            {
                myArray[i] = random.Next(-10, 10);
            }

            return myArray;
        }
    }
}
