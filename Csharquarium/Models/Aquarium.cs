using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharquarium.Models.Poissons;


namespace Csharquarium.Models
{
    public class Aquarium
    {
        // Liste d'êtres vivants
        private List<EtresVivants> _etreVivants;

        // Constructeur
        public Aquarium()
        {
            _etreVivants = new List<EtresVivants>();
        }

        // Ajouter un être vivant FONCTION
        public void Ajouter(EtresVivants etreVivant)
        {
            _etreVivants.Add(etreVivant);
        }

        //Afficher les êtres vivants FONCTION
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

        // Méthode PasserLeTemps

        Random rdn = new Random();
        
            List<Poisson> poissons = EtresVivants.OfType<Poisson>().ToList();
            List<Algue> algues = EtresVivants.OfType<Algue>().ToList();

            foreach (Poisson poisson in poissons)
            {
                poisson.PasserLeTemps();
            }
 
}
