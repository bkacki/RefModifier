using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefModifier
{
    internal class Guy
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Age}-latek o imieniu {Name}"; 
    }
}
