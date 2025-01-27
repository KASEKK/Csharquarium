using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharquarium.Models.Fish;
using Csharquarium.Models.Poissons;

namespace Csharquarium.Models
{
    public class EtresVivants
    {
        // Propriétés Age et PV
        public EtresVivants(int age = 0)
        {
            int PV = 10;
            int Age = age;
        }

        // Méthode PasserLeTemps
        public void PasserLeTemps()
        {
            bool Journee = true;
            while (Journee)
            {
                Age++;
                if (Age == 10)
                {
                    PV--;
                }
                if (PV == 0)
                {
                    Journee = false;
                }


            }
        }
    }
}
