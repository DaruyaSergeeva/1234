using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kovcheg.Animals
{
    class Spider:Animal
    {
        string _name;
        int _eyes = 8;
        int _paws = 8;
        int _teil = 0;

 
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
            Console.WriteLine($"It`s a spider, his name is {Name}");
            Console.WriteLine($"He has {Eyes} eyes, {Paws} paws and {Teil} teil!");
        }
        public Spider(string name) : base(true)
        {
            _name = name;

        }
    }
}
