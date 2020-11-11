using kovcheg.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kovcheg
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cats("Matroskin"));
            animals.Add(new Bee ("Maya"));
            animals.Add(new Spider ("Shniuk"));

            Console.WriteLine("Animals from our ark:");
            Console.WriteLine();
            foreach (Animal animal in animals)
            {
                animal.GetInfo();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}