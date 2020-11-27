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
        int _eyes ;
        int _paws ;
        int _sting ;

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
        
        public override string GetInfo()
        {
            return "Animal name is " + _name;
        }
        public Bee(string name, int eyes, int paws, int sting) : base(true)
        {
            _name = name;
            int _eyes = eyes;
            int _paws = paws;
            int _sting = sting;
        }
    }
}
