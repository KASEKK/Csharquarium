using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.Models
{
    // Algues, enfants de EtresVivants
    public class Algue : EtresVivants
    {
        // Propriété Age et constructeur
        public int Age { get; private set; }
        public Algue(int age) : base(age)
        {
            Age = age;
        }
    }
}
