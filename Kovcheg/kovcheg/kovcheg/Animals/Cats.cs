using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kovcheg.Animals
{
    class Cats:Animal
    {
        string _name;
        int _eyes = 2;
        int _paws = 4;
        int _teil = 1;

        //public int Horn;
        /* public bool Exists;
         public Unicorn(bool Exists)
         {
             Exist = Exists;
         }*/
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = $"{value}";
            }
        }
        public int Eyes
        {
            get
            {
                return _eyes;
            }
            set
            {
                _eyes = value;
            }
        }

        public int Paws //лапы
        {
            get
            {
                return _paws;
            }
            set
            {
                _paws = value;
            }
        }

        public int Teil //хвост
        {
            get
            {
                return _teil;
            }
            set
            {
                _teil = value;
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine($"It`s a cat, his name is {Name}");
            Console.WriteLine($"He has {Eyes} eyes, {Paws} paws and {Teil} teil!");
        }
        public Cats(string name) : base(true)
        {
            _name = name;
       
        }
    }
}
