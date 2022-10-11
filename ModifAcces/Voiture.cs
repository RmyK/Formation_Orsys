using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifAcces
{
    internal class Voiture : Vehicule, IVehiculeAMoteur
    {
        public int NbRoues { get; set; }

        public static string Couleur;

        public void AjouterGasoil()
        {
            QteCarburant++;
        }

        public static string ShowColor()
        {
            return Couleur;
        }

        ~Voiture()
        {
            Console.WriteLine("Adieu");
        }

        public Voiture(int nbroues)
        {
            NbRoues = nbroues;
        }

        public Voiture(string proprietaire)
        {
            Proprietaire = Proprietaire;
        }

        public Voiture(int nbroues, string proprietaire)
        {
            NbRoues = nbroues;
            Proprietaire = proprietaire;
        }

        public Voiture()
        {
            NbRoues = 4;
            Proprietaire = "John Doe";
        }

    }
}
