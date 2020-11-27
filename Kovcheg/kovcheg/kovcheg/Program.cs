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
            Animal[] kovcheg = {
                new Cats("Matroskin", 2, 4, 1),
                new Bee ("Maya", 5, 6, 1),
                new Spider ("Shniuk", 8, 8, 0)
            };

            for (var i = 0; i < kovcheg.Length; i++)
            {
                if (kovcheg[i] is Cats)
                {
                    var a = (Cats)kovcheg[i];
                    Console.WriteLine(a.GetInfo());
                }
                else if (kovcheg[i] is Bee)
                {
                    var a = (Bee)kovcheg[i];
                    Console.WriteLine(a.GetInfo());
                }
                else if (kovcheg[i] is Spider)
                {
                    var a = (Spider)kovcheg[i];
                    Console.WriteLine(a.GetInfo());
                }
            }
               
                Console.ReadKey();
        }
    }
}













/*List<Animal> animals = new List<Animal>();
               animals.Add(new Cats("Matroskin"));
               animals.Add(new Bee ("Maya"));
               animals.Add(new Spider ("Shniuk"));

               Console.WriteLine("Animals from our ark:");
               Console.WriteLine();
               foreach (Animal animal in animals)
               {
                   var t = animal is Cats;
                   Console.WriteLine(t);
                   //animal.GetInfo();
                   Console.WriteLine();
               }*/
