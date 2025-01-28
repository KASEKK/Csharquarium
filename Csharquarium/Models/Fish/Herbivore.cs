using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Csharquarium.Models.Fish;

namespace Csharquarium.Models.Poissons
{
    // Enumération des types de poissons herbivores
    public class Herbivore : Poisson
    {
        public EspeceHerbivoreEnum Espece { get; set; }

        // Constructeur avec paramètres
        public Herbivore(EspeceHerbivoreEnum espece, string nom, char sexe) : base(nom, sexe)
        {
            Espece =  espece;
        }


        public void mangerAlgue (Algue algue)
        {
            if (this.PV > 5)
                return;

            Console.WriteLine($"Le poisson {Nom} mange une algue");
            this.PV += 3;
            algue.PV -= 2;
            Console.WriteLine($"PV {Nom} : {this.PV}");
            Console.WriteLine($"PV algue : {algue.PV}");
        }
    }
}
