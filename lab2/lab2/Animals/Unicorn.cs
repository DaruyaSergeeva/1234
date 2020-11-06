using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Animals
{
    class Unicorn:Animal
    {
        string _name;
        int _horn;
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
        public int Horn
        {
            get
            {
                return _horn;
            }
            set
            {
                _horn = value;
            }
        }
        /*public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = $"{value}";
            }
        }*/
        public void GetInfo()
        {
            Console.WriteLine($"{Name} exists!!!");
            if (_horn == 1)
            {
                Console.WriteLine($"It has {Horn} horn, it's a unicorn)))");
            }
            else
            {
                Console.WriteLine($"It has {Horn} horn, it's not a unicorn(((");
            }
        }
        public Unicorn(string name, int horn): base (true)
        {
            _name = name;
            _horn = horn;
        }
    }
}
