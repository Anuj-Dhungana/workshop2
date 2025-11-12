using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop2.task_4
{
    internal class DAyPrinter
    {
        public void PrintDay()
        {
            Console.Write("Enter a number (1-7): ");
            string input = Console.ReadLine();

            try
            {
                int dayNumber = Convert.ToInt32(input);

                switch (dayNumber)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Invalid day number.");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
