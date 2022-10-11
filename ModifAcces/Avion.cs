using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifAcces
{
    internal class Avion : Vehicule , IVehiculeAMoteur
    {
        private int Vitesse_Croisiere { get; set; } = 800; // Egale à l'initialisation par le constructeur

        public void AjouterKerozen()
        {
            QteCarburant++;
        }

        public void ReparerMoteur()
        {
            Console.WriteLine("Moteur de l'avion reparé");
        }
    }
}
