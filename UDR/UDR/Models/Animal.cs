using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDR.Models
{
    internal abstract class Animal
    {
        string _breed;
        public string Breed
        {
            get => _breed; 
            set
            {
                
              _breed = value;

            }
        }

        public Animal(string breed)
        {
            Breed = breed;
        }



        public abstract void MakeSound();
        public abstract void EatFood(Food food);
    }
}
