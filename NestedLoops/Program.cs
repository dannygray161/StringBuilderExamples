using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine("I am learning about loops");
            //    counter++;
            //}

            // use a while loop to accept input in a given range
            // create your variables
            //int number = 0;
            //int min = 20;
            //int max = 30;
            //bool numberInRange = false;

            //while (!numberInRange)
            //{
            //    Console.WriteLine($"Please input a number in the range {min} to {max}");
            //    number = Convert.ToInt32(Console.ReadLine());

            //    if (number >= min && number <= max)
            //    {
            //        numberInRange = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"PLease input anither number, {number} is not a valid entry");
            //        Thread.Sleep(2000);
            //        Console.Clear();
            //    }
            //}
            //Console.WriteLine($"Congratulations, you r number {number} is a valid number");

            int number = 4;
            int number2 = 10;

            do
            {
                Console.WriteLine(number);
                number++;
            } while (number <= 10);

            Console.ReadLine();

        }
    }
}
