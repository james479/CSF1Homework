using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temperature converter");
            bool repeat = true;  //variable to serve as condition for loop
            double tempFahrenheit;
            double tempCelsius;
            do
            {
                Console.Write("Enter C to convert to Celsius, F to covert to Farhrenheit or Q to quit: ");  //prompt user for input
                string userChoice = Console.ReadLine().ToUpper();
                
                switch (userChoice)
                {
                    //convert to celsius
                    case "C":
                        Console.Write("Enter the temperature im Fahrenheit: ");
                        tempFahrenheit = double.Parse(Console.ReadLine());
                        tempCelsius = (tempFahrenheit - 32) / (9 / 5);
                        Console.WriteLine($"The temperature in Celsius is {tempCelsius} degrees");
                        break;
                    //convert to fahrenheit
                    case "F":
                    Console.Write("Enter the temperature in Celsius: ");   
                    tempCelsius = double.Parse(Console.ReadLine());  
                    tempFahrenheit = tempCelsius * 9 / 5 + 32;  
                    Console.WriteLine($"The temperature in fahrenheit is {tempFahrenheit} degrees.");
                        break;
                    //quit program
                    case "Q":
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("You entered an invalid option try again.");
                        break;
                }
            } while (repeat);
        }
    }
}
