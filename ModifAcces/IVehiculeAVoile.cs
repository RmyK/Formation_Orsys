using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifAcces
{
    internal interface IVehiculeAVoile
    {
        public int NombreDeVoile { get; set; }

        public void RepriserVoile()
        {
            Console.WriteLine("Voiles comme neuves");
        }
    }
}
