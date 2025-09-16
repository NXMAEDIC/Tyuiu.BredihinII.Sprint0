using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BredihinII.Sprint0.Task5.V0.Lib;

namespace Tyuiu.BredihinII.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(5, 16));
            Console.WriteLine("A - B = " + DataService.Subtraction(22, 3));
            Console.WriteLine("A * B = " + DataService.Multiplication(6, 7));
            Console.WriteLine("A / B = " + DataService.Division(144, 2));

            Console.ReadKey();
        }
    }
}
