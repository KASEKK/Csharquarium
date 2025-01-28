using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.Models.Poissons
{
    public class Poisson : EtresVivants
    {
        // Propriétés Nom, Sexe et Age
        public string Nom { get; }
        public char Sexe { get; private set; }
        

        // Constructeur
        public Poisson(string nom, char sexe)
        {
            Nom = nom;
            Sexe = sexe;
        }
    }

}
