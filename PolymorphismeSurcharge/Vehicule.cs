using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismeSurcharge
{
    internal abstract class Vehicule
    {
        public int VitesseDeplacement { get; set; }
        public int SerialNumber { get; set; }
        public string Fabricant { get; set; }

        public string Nom { get; set; }

        public virtual string Klaxonner()
        {
            return "Tiiit";

        }

        public abstract void Demarrer();
    }
}
