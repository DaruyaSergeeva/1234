using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kovcheg.Animals
{
    abstract class Animal:IMove
    {
        /// <summary>
        /// Жизнь
        /// </summary>
        public bool IsLive;
        public string _name;
        public int _eyes;
        public int _paws;
        public int _teil;
        public int _sting;
        public Animal(string Name, int Eyes, int Paws, int Teil, int Sting)
        {
            IsLive = true;
            _name = Name;
            _eyes = Eyes;
            _paws = Paws;
            _teil = Teil;
            _sting = Sting;
            
        }
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

        public virtual string GetInfo()
        {
            return " "; //"Animal name is " + _name;
        }

    }
}
