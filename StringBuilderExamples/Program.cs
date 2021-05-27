using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfCharacter = "Tod";
            string spellName = "fireball";
            int damageTaken = 100;
            string damageReport = "The " + nameOfCharacter + " took " + damageTaken + " from " + spellName; // long way concatenation 
            // challenge create another on your own
            string damageReportV2 = string.Format("The {0}  character  took  {1} damage from {2} ", nameOfCharacter, damageTaken, spellName);

            string damageReportV3 = string.Format("The {0} Character took {1} damage from {2} and {0} is now dead", nameOfCharacter, damageTaken, spellName);

            // interpolation 

            string damageReportV4 = $"The {nameOfCharacter} character took {damageTaken} damage from {spellName}";

           


            Console.WriteLine(damageReport);
            Console.WriteLine(damageReportV2);
            Console.WriteLine(damageReportV3);
            Console.WriteLine(damageReportV4);

            Console.ReadLine();
        }
    }
}
