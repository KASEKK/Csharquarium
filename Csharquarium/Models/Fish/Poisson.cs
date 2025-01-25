using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.Models.Poissons
{
    public class Poisson : EtresVivants
    {
        public string Nom { get; }
        public char Sexe { get; private set; }
        public int Age { get; private set; }

        public Poisson(string nom, char sexe)
        {
            Nom = nom;
            Sexe = sexe;
        }

        public Poisson(string nom, char sexe, int age) : base(age)
        {
            Nom = nom;
            Sexe = sexe;
            Age = age;
        }
    }

}
