using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismeSurcharge
{
    internal class VehiculeMaritime : Vehicule
    {
        public int NombreDeVoile { get; set; }

        public override void Demarrer()
        {
            Console.WriteLine("Je démarre à la rame");
        }
    }
}
