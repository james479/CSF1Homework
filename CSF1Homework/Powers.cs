using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Powers
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                long power = Convert.ToInt64(Math.Pow(i, 2));
                //displaying result
                Console.WriteLine($"2 to the {i} power is {power}.");
                

            }
        }
    }
}
