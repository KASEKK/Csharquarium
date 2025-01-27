using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.Models.Poissons
{
    public class Carnivore : Poisson
    {
        // Constructeur
        public Carnivore(string nom, char sexe)
       : base(nom, sexe)
        {

        }

        // Constructeur avec paramètres
        public Herbivore(string nom, char sexe, int age)
            : base(nom, sexe, age)
        {

        }
    }
}
