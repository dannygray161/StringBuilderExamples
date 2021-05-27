using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // write an expression to determine if the 3rd digit of an integer is 3
            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number.ToString()[number.ToString().Length - 3] == '3')
            {
                Console.WriteLine($"the third digit right to left of {number} is 3");
            }
            else
            {
                Console.WriteLine($"the third digit from right to left of {number} is not 3");
            }

            // write a program to exchange two numbers if the first is bigger
            int tempNumber = 0;
            if (number > number2)
            {
                tempNumber = number2;
                number2 = number;
                number = tempNumber;

            }
            Console.WriteLine(number);
            Console.WriteLine(number2);
           
        }
    }
}
