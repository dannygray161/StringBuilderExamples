using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumber = 10;
            int addition = firstNumber + secondNumber; // addition
            int subtraction = firstNumber - secondNumber; // subtraction
            int multiplication = firstNumber * secondNumber; // multiplication
            double division = firstNumber / secondNumber; // division in order to do this you need to type cast 


            double equation2 = ((3 / 7) + Math.Pow(5, 2)) / (3 + (4 /3)); // complex arithmetic

            // ++ & --   these are increment and decrement

            // assignment operators: += etc


            Console.WriteLine(addition);
            Console.WriteLine(division);
            Console.WriteLine(equation2);
        }
    }
}
