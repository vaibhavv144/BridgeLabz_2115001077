using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            Console.WriteLine("Add: " + c1.Add(10, 5));
            Console.WriteLine("Subtract: " + c1.Subtract(10, 5));
            Console.WriteLine("Multiply: " + c1.Multiply(10, 5));
            Console.WriteLine("Divide: " + c1.Divide(10, 5));
        }
    }
}