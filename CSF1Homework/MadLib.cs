using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            //user instructions
            Console.WriteLine("Please enter some information below to do this Mad Lib.");

            //prompting user for words
            Console.Write("Enter a noun: ");
            string noun = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter an adjectivce: ");
            string adjective = Console.ReadLine();

            Console.Write("Enter another noun");
            string noun2 = Console.ReadLine();

            Console.Write("Enter a verb ening in ing: ");
            string verb2 = Console.ReadLine();

            Console.Write("Enter another adjective: ");
            string adjective2 = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            string adverb = Console.ReadLine();

            Console.Write("Enter an exclamatoin: ");
            string exclamation = Console.ReadLine();

            Console.Write("Enter a city: ");
            string city = Console.ReadLine();

            Console.Write("Enter a time: ");
            string time = Console.ReadLine();

            //writing the story
            Console.WriteLine($"One day there was a {noun} that didn't want to {verb} anymore. " +
                $"And so, like any good {adjective} {noun2}, the {noun} decided to go {verb2}. " +
                $"But sometimes the universe is a {adjective2} mistress, and destiny {adverb} called. " +
                $"After that the {noun} exclaimed '{exclamation}', and they heard it all the way in {city}! " +
                $"And the {noun} vowed not to return until {time}.");
        }
    }
}
