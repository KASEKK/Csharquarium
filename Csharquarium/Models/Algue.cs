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
        // Constructeur par défaut
        public Algue()
        {
            PV = 10;
        }

        // Constructeur avec paramètre age
        public Algue(int age)
        {
            Age = age;
            PV = 10;
        }
        public override void Grandir()
        {
            PV += 1;
            Console.WriteLine($"L'algue grandit. PV actuels : {PV}");
            Age++;
            if (Age > 20)
            {
                Mourir();
            }
            else
            {
                Console.WriteLine($"L'age de l'algue est de {this.Age}");
            }
        }
    }
    
}
