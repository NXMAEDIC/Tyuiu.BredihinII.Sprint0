using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BredihinII.Sprint0.Task4.V0.Lib;

namespace Tyuiu.BredihinII.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(5, 16));
            Console.WriteLine(DataService.Subtraction(22, 3));
            Console.WriteLine(DataService.Multiplication(6, 7));
            Console.WriteLine(DataService.Division(144, 2));

            Console.ReadKey();
        }
    }
}
