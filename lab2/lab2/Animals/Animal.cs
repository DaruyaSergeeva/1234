using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Animals
{
    abstract class Animal: IMove
    {
        public bool IsLive;

        public Animal(bool isLive)
        {
            IsLive = isLive;
        }

        public void Live()
        {
            Console.WriteLine("I live!!!");
        }

        public void Breathe()
        {
            Console.WriteLine("I Breathe!!!");
        }
    }
}
