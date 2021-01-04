using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number of number you want in the Fibonacci sequence: ");

            //making sure user enters a valid integer, will loop until valid
            bool isValid = Int32.TryParse(Console.ReadLine(), out n);

            while (!isValid)
            {
                Console.WriteLine("Invalid integer entered.");
                Console.Write("Enter the number of number you want in the Fibonacci sequence: ");
                isValid = Int32.TryParse(Console.ReadLine(), out n);
            }

            Fib(n);
        }

        static void Fib(int n)
        {
            //a and b reprsent the first two sequences of the sequence
            int a = 0;
            int b = 1;
            int c;

            //printing first two numbers of sequence
            Console.Write($"{a} {b} ");
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
            }
            Console.WriteLine("\n");
        }
    }
}
