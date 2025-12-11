using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALVO_Reiview2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tAREA COMPUTATION PROGRAM\n");

            Console.WriteLine("Choose a shape:\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1 - Circle");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2 - Rectangle\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter your choice: ");


            int choice = int.Parse(Console.ReadLine());

            Shape shape = null;

            if (choice == 1)
            {
                Circle c = new Circle();
                Console.Write("Enter color: ");
                c.Color = Console.ReadLine();

                Console.Write("Enter radius: ");
                c.Radius = double.Parse(Console.ReadLine());

                shape = c;
            }
            else if (choice == 2)
            {
                Rectangle r = new Rectangle();
                Console.Write("Enter color: ");
                r.Color = Console.ReadLine();

                Console.Write("Enter width: ");
                r.Width = double.Parse(Console.ReadLine());

                Console.Write("Enter height: ");
                r.Height = double.Parse(Console.ReadLine());

                shape = r;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid choice!\n");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n--- RESULT ---\n");
            Console.WriteLine("Color: " + shape.Color);
            Console.WriteLine("Area: " + shape.GetArea());

            Console.ReadLine();
        }
    }
}
