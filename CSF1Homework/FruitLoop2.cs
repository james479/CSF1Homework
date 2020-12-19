using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Apple", "Grape", "Orange", "Pear", "Grapefruit", "Avocado" };

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"{fruits[i]}");
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(".");
                }
            }
        }
    }
}
