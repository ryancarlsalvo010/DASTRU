using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALVO_act2
{
     class Countries
    {
        public string Name { get; set; }
        public string Population { get; set; }
        public string TouristAttraction { get; set; }

        // Parametarized Constructor
        public Countries(string name, string population, string tourist)
        {
            Name = name;
            Population = population;
            TouristAttraction = tourist;
        }

        public virtual void Display() //Virtual World
        {
            Console.WriteLine($"Countrie Name: {Name}");
            Console.WriteLine($"How many population: {Population}");
            Console.WriteLine($"Top 1 Famous Tourist Attraction: {TouristAttraction}");

        }
    }
    class Continent : Countries // Derived Class
    {
        public string Area { get; set; } // Addtional Property 

        // Parametarized Constructor
        public Continent(string name, string population, string tourist, string area) : base(name, population, tourist)
        {
            Area = area;
        }
        public override void Display()
        {
            Console.WriteLine("\n----- Continet Details-----");
            Console.WriteLine($"Area: {Area}");
            base.Display();
        }
    }

    class Government : Countries
    {
        public string President { get; set; }

        // Parametarized Constructor
        public Government(string name, string population, string tourist, string president) : base(name, population, tourist)
        {
            President = president;
        }
        public override void Display()
        {
            Console.WriteLine("\n----- Government Details-----");
            Console.WriteLine($"President: {President}");
            base.Display();
        }

    }
}

