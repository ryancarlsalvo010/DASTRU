using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvo_Act4
{
    internal class Program
    {
        static void Main(string[] args)
            
            {
                // Create an array of Countries objects
                Countries[,] countries = new Countries[2, 2];

                // Assign values for each object
                Console.ForegroundColor = ConsoleColor.Cyan;
                //ROW 0:
                countries[0, 0] = new Continent("Canada", "41.5 to 41.7 million people", "Niagara Falls", "9.985 million km²");
                countries[0, 1] = new Continent("Italy", "59 million people", "the Colosseum in Rome", "301,340 square kilometers");

                //ROW 1:
                countries[1, 0] = new Government("Brazil", "213 million people", " Christ the Redeemer statue in Rio de Janeiro", "Luiz Inácio Lula da Silva");
                countries[1, 1] = new Government("England", "57.1 million people", "the Tower of London", "King Charles III (Head of State)");

                // Display Information for each Countries
                for (int i = 0; i < countries.GetLength(0); i++)
                {
                    for (int j = 0; j < countries.GetLength(1); j++)
                    {
                        countries[i, j].Display();
                    }
                }
                Console.ReadKey();
            }
    }
}
