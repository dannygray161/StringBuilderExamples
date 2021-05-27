using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            bool newChoice = false;
            string[] candies = new string[10];

            while (!newChoice)
            {


                Console.Write("1. Add New Item " + "\n2. Edit Item " + "\n3. Remove Item " + "\n4. View All Items " + "\n5. Exit " + "\nYour Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You wish to add an item. Please add it below: ");
                        for (int i = 0; i < candies.Length; i++)
                        {
                            if (candies[i].ToString())
                            {

                            }
                        }

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        newChoice = true;
                        break;
                    default:
                        Console.WriteLine("Unrecognized Option Please choose a corresponding number ");
                        break;



                }
            }
        }
    }
}
