using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDR.Models
{
    internal abstract class Food
    {
        int Calori;
        protected Food(int calori)
        {
            if (calori > 0)
            {
                Calori = calori;
            }
            else 
            {
                Console.WriteLine("menfi calori olur?duz yazda bunu");
            }
        }
    }
}
