using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kovcheg.Animals
{
    class Bee:Animal
    {
        string _name;
        int _eyes = 5;
        int _paws = 6;
        int _sting = 1;

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
        /// <summary>
        /// Глаза
        /// </summary>
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
        /// <summary>
        /// Лапы
        /// </summary>
        public int Paws 
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
        /// <summary>
        /// Жало
        /// </summary>
        public int Sting 
        {
            get
            {
                return _sting;
            }
            set
            {
                _sting = value;
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine($"It`s a bee, her name is {Name}");
            Console.WriteLine($"Bee has {Eyes} eyes, {Paws} paws and {Sting} sting, it stings painfully!!!");
        }
        public Bee(string name) : base(true)
        {
            _name = name;
          
        }
    }
}
