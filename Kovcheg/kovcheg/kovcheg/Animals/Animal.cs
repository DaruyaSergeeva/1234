using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kovcheg.Animals
{
    abstract class Animal:IMove
    {
        public bool IsLive;
        public Animal(bool isLive)
        {
            IsLive = isLive;
        }

        public void Live()
        {
            if (IsLive)
           
                Console.WriteLine("I live!!!");
            else
                Console.WriteLine("I died(((");

        }

        public virtual void GetInfo()
        {
            Console.WriteLine("I am Animal");
        }

    }
}
