using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifAcces
{
    internal class Reparateur
    {
        public int Tarif { get; set; }

        public void AjouterRdv()
        {
            VerifierDispoRDV();
        }

        private void VerifierDispoRDV()
        {
        }

        public void EntretenirAvionVoiture(Vehicule vehicule)
        {
            vehicule.ReparerMoteur();
        }

        public void Entretenir(Vehicule vehicule)
        {

        }

    }
}
