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
        int _eyes;
        int _paws;
        int _teil;

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
        
        public Spider (string name, int eyes, int paws, int teil) : base(true)
        {
            _name = name;
            int _eyes = eyes;
            int _paws = paws;
            int _teil = teil;
        }
    }
}











/* public override void GetInfo()
         {
             Console.WriteLine($"It`s a spider, his name is {Name}");
             Console.WriteLine($"Sppider has {Eyes} eyes, {Paws} paws and {Teil} teil!");
         }*/
