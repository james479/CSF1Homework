using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            //prompt user to enter number
            Console.Write("Enter an integer to go to: ");
            int number;
            bool isValid = Int32.TryParse(Console.ReadLine().Trim(), out number);

            //if valid integer
            if(isValid)
            {
                for (int i = 1; i <= number; i++)
                {
                    //if number is divisable by 3 and 5
                    if (i % 15 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    //if divisable by 3
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine($"{i}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid integer");
            }
        }
    }
}
