using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharquarium.Models.Fish;

namespace Csharquarium.Models.Poissons
{
    public class Carnivore : Poisson
    {
        public EspeceCarnivoreEnum Espece { get; set; }

        // Constructeur avec paramètres
        public Carnivore(EspeceCarnivoreEnum espece, string nom, char sexe) : base(nom, sexe)
        {
            Espece = espece;
        }

        public void mangerPoisson (Poisson poisson)
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


