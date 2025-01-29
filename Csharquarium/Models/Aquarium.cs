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

        // Ajouter une algue FONCTION
        public void AjouterAlgue(Algue algue)
        {
            _etreVivants.Add(algue);
        }

        //Afficher les êtres vivants FONCTION
        public void AfficherEtreVivant()
        {
            foreach (EtresVivants etreVivant in _etreVivants)
            {
                if (etreVivant is Algue)
                {
                    Console.WriteLine($"Algue : Age => {etreVivant.Age}");
                    Console.WriteLine("\n");
                }
                else if (etreVivant is Poisson poisson)
                {
                    Console.WriteLine($"Poisson nommé {poisson.Nom} agé de {poisson.Age}");
                    Console.WriteLine("\n");
                }
            }

           

        }

        // Méthode PasserLeTemps
        public void PasserLeTemps()
        {
            Random rdn = new Random();

            List<Poisson> poissons = _etreVivants.OfType<Poisson>().ToList();
            List<Algue> algues = _etreVivants.OfType<Algue>().ToList();

            // Mettre à jour les algues
            foreach (Algue algue in algues)
            {
                algue.Grandir();
            }

            // Mettre à jour les poissons
            foreach (Poisson poisson in poissons)
            {
                poisson.PV -= 1; // Les poissons perdent 1 PV chaque tour

                if (poisson.PV <= 5)
                {
                    if (poisson is Herbivore herbivore)
                    {
                        // Les herbivores mangent des algues
                        if (algues.Any())
                        {
                            Algue algueAManger = algues[rdn.Next(algues.Count)];
                            herbivore.mangerAlgue(algueAManger);
                        }
                    }
                    else if (poisson is Carnivore carnivore)
                    {
                        List<Poisson> poissonsMangeables = new List<Poisson>();
                        poissonsMangeables.AddRange(poissons);
                        poissonsMangeables.Remove(carnivore);

                        Poisson miskine = poissonsMangeables[rdn.Next(0, poissonsMangeables.Count())];

                        carnivore.mangerPoisson(miskine);
                    }
                    }
                }
            }
        }
    }

