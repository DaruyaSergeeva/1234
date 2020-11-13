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

        public override void GetInfo()
        {
            Console.WriteLine($"It`s a spider, his name is {Name}");
            Console.WriteLine($"Sppider has {Eyes} eyes, {Paws} paws and {Teil} teil!");
        }
        public Spider(string name) : base(true)
        {
            _name = name;

        }
    }
}
