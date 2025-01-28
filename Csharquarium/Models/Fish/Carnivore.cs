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
        public Carnivore(string nom, char sexe, int age)
            : base(nom, sexe, age, )
        {

        }

        public void mangerPoisson (Poisson poisson, int pV)
        {
            if (this.PV > 5)
                return;
            
            Console.WriteLine($"Le poisson {Nom} mange le poisson {poisson.Nom}");
            this.PV += 5;
            poisson.PV -= 4;
            Console.WriteLine($"PV {Nom} : {this.PV}");
            Console.WriteLine($"PV {poisson.Nom} : {poisson.PV}");
        }
    }
}


