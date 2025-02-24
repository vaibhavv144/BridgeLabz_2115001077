using System;

namespace ExceptionHandlingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExceptionHandling exceptionHandling = new ExceptionHandling();

            try
            {
                int result = exceptionHandling.Divide(10, 0);
                Console.WriteLine("Result: " + result);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
        }
    }
}