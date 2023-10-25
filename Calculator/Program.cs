using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 2;

            if (Methods.Multiply(number1, number2) == 10)
            {
                Console.WriteLine($"Multiplication of {number1} and {number2} works as expected");
            }
            else
            {
                Console.WriteLine($"Error when multiplying {number1} and {number2}!");
            }

            if (Methods.Multiply(7, 15) == 105)
            {
                Console.WriteLine($"Multiplication of {7} and {15} works as expected");
            }
            else
            {
                Console.WriteLine($"Error when multiplying {7} and {15}!");
            }

            if (Methods.Divide(number1, number2) == 2.5)
            {
                Console.WriteLine($"Multiplication of {number1} and {number2} works as expected");
            }
            else
            {
                Console.WriteLine($"Error when dividing {number1} and {number2}!");
            }
        }
    }
}
