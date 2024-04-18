using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDR.Models
{
    internal class Lion : Animal
    {
        public bool IsPrideLeader;
        
        public Lion(string breed,bool isPrideLeader) : base(breed)
        {
            IsPrideLeader = isPrideLeader;
        }

        public override void EatFood(Food food)
        {
            if (food is Meat) { Console.WriteLine("duzgun qida"); } else { Console.WriteLine("Yalnis qida"); }
        }

        public override void MakeSound()
        {
            Console.WriteLine("xrrrr");
        }
        
    }
}
