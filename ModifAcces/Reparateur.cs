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

        public void EntretenirVehiculeAMoteur(IVehiculeAMoteur vehicule)
        {
            if(vehicule is Voiture)
            {
                ((Voiture)vehicule).AjouterGasoil();
            }
            else if (vehicule is Avion)
            {
                ((Avion)vehicule).AjouterKerozen();
            }

            vehicule.ReparerMoteur();
        }

        public void Entretenir(Vehicule vehicule)
        {

        }

    }
}
