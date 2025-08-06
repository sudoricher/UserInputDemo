using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string firstName = string.Empty;
            string lastName = string.Empty;
            int age = 0;
            int retirementAge = 65;

            //Prompt for user input
            Console.WriteLine("Please enter your name:");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your name:");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            //Process the data
            int workYearsRemaining = retirementAge - age;

            //Output the results
            Console.WriteLine($"Fullname: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Working years remaining: {workYearsRemaining}");

        }
    }
}
