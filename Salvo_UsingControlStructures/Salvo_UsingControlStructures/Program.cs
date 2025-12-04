using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvo_UsingControlStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t This program will determine what type of number and display its range.\n");

            string tryAgain;

            do
            {
                int number = 0;
                bool isValidInput = false;

                // Input and Validation Loop
                while (!isValidInput)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\nPlease enter a number: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out number))
                    {
                        // Check if the number is positive
                        if (number > 0)
                        {
                            isValidInput = true;
                        }
                        else
                        {
                            // Numeric but non-positive
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nPlease enter a positive integer greater than 0.");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPlease re-try to enter a numeric value.");
                    }
                }


                if (number % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\n{number} is an even number");
                    Console.WriteLine("\nThis is the range of numbers based from the number entered.");


                    string rangeOutput = "";
                    for (int i = number; i >= 2; i -= 2)
                    {
                        // Add the number
                        rangeOutput += i.ToString();


                        if (i > 2)
                        {
                            rangeOutput += " ";
                        }
                    }


                    Console.WriteLine(rangeOutput);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\n{number} is an odd number");
                    Console.WriteLine("Sorry, I cannot provide the range of numbers based from the number you entered.");
                }

                Console.WriteLine("\n");

                // Try Again Prompt
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Do you want to try again (y/n)? ");
                    tryAgain = Console.ReadLine()?.Trim().ToLower();
                } while (tryAgain != "y" && tryAgain != "n");


            } while (tryAgain == "y");



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThank you for using this program.");

            Console.ReadLine();
        }
    }
}
