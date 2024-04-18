using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDR.Models
{
    internal class Grass : Food
    {
        string Name;
        public Grass(int calori, string name) : base(calori)
        {
            Name = name;
        }
    }
}
