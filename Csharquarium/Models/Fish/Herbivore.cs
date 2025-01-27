using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.Models.Poissons
{
    // Enumération des types de poissons herbivores
    public class Herbivore : Poisson
    {
        public TypeHerbivore Type { get; set; }
    }
}
