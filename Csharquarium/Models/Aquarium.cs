using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharquarium.Models.Poissons;


namespace Csharquarium.Models
{
    public class Aquarium
    {

        private List<EtresVivants> _etreVivants;

        public Aquarium()
        {
            _etreVivants = new List<EtresVivants>();
        }

        public Aquarium(IEnumerable<EtresVivants> poissons)
        {
            _etreVivants = new List<EtresVivants>(poissons);
        }

        public void Ajouter(EtresVivants etreVivant)
        {
            _etreVivants.Add(etreVivant);
        }

        public void AfficherEtreVivant()
        {
            foreach (EtresVivants etreVivant in _etreVivants)
            {
                if (etreVivant is Algue)
                {
                    Console.WriteLine($"Algue : Age => {etreVivant}");
                }
                else if (etreVivant is Poisson poisson)
                {
                    Console.WriteLine($"Poisson nommé {poisson.Nom} agé de {poisson.Age}");
                }
            }

        }
    }
}
