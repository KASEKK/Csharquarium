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

        public virtual void Grandir()
        {
            Age++;
            if (Age > 20)
            {
                Mourir();
            }
        }

        public void Mourir()
        {
            PV = 0;
            Console.WriteLine($"{this.GetType().Name} est mort de vieillesse.");
        }
    }
    
}
