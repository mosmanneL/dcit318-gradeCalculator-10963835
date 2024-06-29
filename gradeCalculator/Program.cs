using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade between 0 and 100: ");
            string input = Console.ReadLine();
            int grade;

            // Validate input
            while (!int.TryParse(input, out grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
                Console.Write("Enter a numerical grade between 0 and 100: ");
                input = Console.ReadLine();
            }

            // Determine the letter grade
            string letterGrade = GetLetterGrade(grade);

            // Display the result
            Console.WriteLine($"The letter grade for {grade} is: {letterGrade}");
        }

        static string GetLetterGrade(int grade)
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
