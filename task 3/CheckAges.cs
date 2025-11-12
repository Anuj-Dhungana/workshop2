using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop2.task_3
{
    internal class CheckAges
    {
        public void AgeCheck()
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            try
            {
                int age = Convert.ToInt32(input);

                if (age < 13)
                {
                    Console.WriteLine("You are a Child.");
                }
                else if (age >= 13 && age <= 19)
                {
                    Console.WriteLine("You are a Teenager.");
                }
                else if (age >= 20)
                {
                    Console.WriteLine("You are an Adult.");
                }
                else
                {
                    Console.WriteLine("Invalid age.");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
