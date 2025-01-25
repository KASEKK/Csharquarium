using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.Models
{
    public class Algue : EtresVivants
    {
        public int Age { get; private set; }
        public Algue(int age) : base(age)
        {
            Age = age;
        }
    }
}
