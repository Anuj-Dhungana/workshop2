using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop2.task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var demo = new ExceptionHandler();

            demo.ConvertToInteger();
            Console.WriteLine();
            demo.CheckPassword();
        }
    }
}
