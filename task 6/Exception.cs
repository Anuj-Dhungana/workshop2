using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop2.task_6
{
    internal class ExceptionHandler
    {
        public void ConvertToInteger()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            try
            {
                int number = Convert.ToInt32(input);
                Console.WriteLine("You entered: " + number);
            }
            catch
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }

        public void CheckPassword()
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            try
            {
                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }
                Console.WriteLine("Password satisfied the requirement");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
