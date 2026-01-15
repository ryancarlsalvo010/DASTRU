using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALVO_Act1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare Array 
            string[] Countries = new string[5];

            // User Input
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  Please enter your 5 favorite countries: \n");

            for (int idx = 0; idx < Countries.Length; idx++)
            {
                Console.Write($"Countrie #{idx + 1}: ");
                Countries[idx] = Console.ReadLine();
            }

            // sort and Display on user choice
            Array.Sort(Countries);

            // Display user favorite countries in ascending order
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n -----Here is the list of your favorite Countries in Ascending order-----\n");

            foreach (string s in Countries)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
