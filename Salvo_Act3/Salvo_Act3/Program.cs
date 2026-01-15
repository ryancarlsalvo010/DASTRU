using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvo_Act3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string[,] cars = new string[3, 3]

            {
                {"\tTOYOTA", "SUZUKI", "HONDA" },
                {"\tHOLDEN", "HYUNDAO", "FERRARI" },
                {"\tBMW", "AUDI", "FORD" }
            };

            // Access and print the elements of the array 
            Console.WriteLine("\t     Car Brands\n ");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();

            for (int i = 0; i < cars.GetLength(0); i++)
            {
                for (int j = 0; j < cars.GetLength(1); j++)
                {
                    // Print each element followed by a tab space
                    Console.Write(cars[i, j] + "\t");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
