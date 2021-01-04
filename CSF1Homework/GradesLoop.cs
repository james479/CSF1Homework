using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class GradesLoop
    {
        static void Main(string[] args)
        {
            //list to hold all grades
            List<int> grades = new List<int>();

            try
            {
                Console.Write("Enter a score: ");
                int score = Int32.Parse(Console.ReadLine());

                //looping until users enters a negavtive number
                while (score >= 0)
                {
                    grades.Add(score);
                    Console.Write("Enter a score: ");
                    score = Int32.Parse(Console.ReadLine());
                }

                //if list has scores will print all of them
                if(grades.Count > 0)
                {
                    Console.WriteLine("Your scores:");
                    foreach (var grade in grades)
                    {
                        Console.WriteLine(grade);
                    }
                }
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
                System.Environment.Exit(1);
            }
        }
    }
}
