using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharquarium.Models.Fish;
using Csharquarium.Models.Poissons;

namespace Csharquarium.Models
{
    public class EtresVivants
    {
        // propriétés Age et PV

        public int Age { get; set; }

        public int PV { get; set; }
        public EtresVivants()
        {
            PV = 10;
            Age = 0;
        }
    }
}
