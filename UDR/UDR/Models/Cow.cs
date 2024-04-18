using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDR.Models
{
    internal class Cow : Animal
    {
        public Cow(string breed) : base(breed)
        {
        }

        public override void EatFood(Food food)
        {
            if (food is Grass) { Console.WriteLine("duzgun qida"); } else { Console.WriteLine("Yalnis qida"); }

        }

        public override void MakeSound()
        {
            Console.WriteLine("Moo mooo");
        }

        public virtual void ProduceMilk()
        {
            Console.WriteLine("milk produced");              
        }

    }
}
