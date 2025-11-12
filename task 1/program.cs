using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop2.task_1
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, from task 1");

            var ops = new operators();

            int a = 26;
            int b = 4;
            int number = 15;

            Console.WriteLine($"Add: {ops.Add(a, b)}");
            Console.WriteLine($"Subtract: {ops.Subtract(a, b)}");
            Console.WriteLine($"Multiply: {ops.Multiply(a, b)}");
            Console.WriteLine($"Divide: {ops.Divide(a, b)}");

            ops.OddEvenFinder(number);
        }
    }
}
