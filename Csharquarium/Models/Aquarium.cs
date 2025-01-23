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
        public List<Poisson> Poissons { get; set; }
        public List<Algue> Algues { get; set; }
        public void AjouterPoisson(Poisson poisson)
        {
            Poissons.Add(poisson);
        }

        public void AjouterAlgue(Algue algue)
        {
            Algues.Add(algue);
        }

        //public void PasserJournee()
        //{
        //    foreach (Poisson poisson in Poissons)
        //    {
        //        poisson.Manger();
        //    }
        //    foreach (Algue algue in Algues)
        //    {
        //        algue.Pousser();
        //    }
        //}


    }
}
