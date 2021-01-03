using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class InterestCalc
    {
        static void Main(string[] args)
        {
            
            try
            {
                //getting begining balance
                Console.Write("Enter the beginning balance: ");
                double balnce = Double.Parse(Console.ReadLine());

                //getting interest rate
                Console.Write("Enter the interest rate: ");
                double interestRate = Double.Parse(Console.ReadLine());
                interestRate *= .01;

                //getting number of years
                Console.Write("Enter the number of years: ");
                int numberOfYears = Int32.Parse(Console.ReadLine());

                //calculating ending balance
                for (int i = 1; i <= numberOfYears; i++)
                {
                    double interest = balnce * interestRate;
                    balnce += interest;
                }

                Console.WriteLine($"The amount you will have in {numberOfYears} years is {balnce:c}");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
