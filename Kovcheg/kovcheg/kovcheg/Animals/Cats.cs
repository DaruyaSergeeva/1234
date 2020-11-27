using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kovcheg.Animals
{
    class Cats:Animal
    {
       /* string _name;
        int _eyes ;
        int _paws ;
        int _teil ;*/
        
        /// <summary>
        /// Имя
        /// </summary>
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
        /// Хвост
        /// </summary>
        public int Teil 
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

        public override string GetInfo()
        {
            return "Animal name is " + _name;
        }
        public Cats(string Name, int Eyes, int Paws, int Teil) : base(true)
        {
            _name = Name;
            int _eyes = Eyes;
            int _paws = Paws;
            int _teil = Teil;
        }
    }
}
















/*public override void GetInfo()
{
    Console.WriteLine($"It`s a cat, his name is {Name}");
    Console.WriteLine($"Cat has {Eyes} eyes, {Paws} paws and {Teil} teil!");
}*/
