using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Apple", "Grape", "Orange", "Pear", "Grapefruit", "Avocado"  };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
