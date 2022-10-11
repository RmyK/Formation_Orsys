using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifAcces
{
    internal class CharAVoile : Vehicule, IVehiculeAVoile
    {
        public int NombreDeVoile { get; set; }

        public override int GetHashCode()
        {
            return (NombreDeVoile, Proprietaire).GetHashCode();
        }
    }
}
