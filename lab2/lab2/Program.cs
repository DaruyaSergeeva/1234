using lab2.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {

        static void Main(string[] args)
        {
            var unic = new Unicorn("Test", 1 );
            unic.Name = "Baby" ;
            unic.Horn = 1;
            unic.IsLive = true;
            unic.GetInfo();
            unic.Live();
            unic.Breathe();
            Console.ReadKey();
        }
    }
}
