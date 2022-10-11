using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismeSurcharge
{
    internal class VehiculeTerrestre : Vehicule
    {
        //propriété automatique
        public int NombreRoue { get; set; }


        //propriété complète => permet de faire de l'encapsulation du champ à l'aide des méthode get et set de la propriété
        private string nom;
        public string Nom
        {
            get { return nom; }
            private set
            {
                if (nom.Length < 2)
                {
                    throw new ArgumentException("Le nom est trop court");
                }
                else
                {
                    nom = value;
                }
            }
        }


        public override void Demarrer()
        {
            Console.WriteLine("Je démarre avec une clé");
        }

        public override string Klaxonner()
        {
            return "Tutut";
        }
    }
}
