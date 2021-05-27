using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniWhileGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a game where two characters who will fight one another. They must have damage and health values.
            // at some point someone wins, 
            Random rng = new Random();
            int warrior1Health = 100;
            int warrior2Health = 100;
            int damage = 0;
            string warrior1 = "Carl";
            string warrior2 = "Bob";
            bool gameOver = false;

            while (!gameOver)
            {
                damage = rng.Next(1, 10);
                warrior1Health -= damage;
                warrior2Health -= damage;

                Console.WriteLine($"{warrior1} inflicted {damage} on {warrior2}. {warrior2}'s health is now {warrior2Health}");
                Console.WriteLine($"{warrior2} inflicted {damage} on {warrior1}. {warrior1}'s health is now {warrior1Health}");
                if (warrior1Health <= 0 )
                {
                    Console.WriteLine($"{warrior2} has won with {warrior2Health} health remaining!");
                    Console.WriteLine($"{warrior1} has lost the battle!");
                    gameOver = true;
                }
                else if (warrior2Health <= 0)
                {
                    Console.WriteLine($"{warrior1} has won with {warrior1Health} health remaining!");
                    Console.WriteLine($"{warrior2} has lost the battle!");
                    gameOver = true;
                }
            }
            // does not work as intended but i understand while loops now. 
        }
    }
}
