using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDR.Models
{
    internal class Meat : Food
    {
        string Type;
        public Meat(int calori, string type) : base(calori)
        {
            Type = type;
        }
    }
}
