using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Voiture
    {
        public int NombreDeRoues { get; set; } = 4;
        public string Marque { get; set; }
        public string Modele { get; set; }

        public void Demarrer()
        {
            Console.WriteLine($"Voiture {Marque} {Modele} préte à rouler");
        }

        public void CouperContact()
        {
            Console.WriteLine("Voiture à l'arrêt");
        }

        public Voiture(string marque, string modele)
        {
            Marque = marque;
            Modele = modele;

            //NombreDeRoues = 4;

            Demarrer();
        }

        public Voiture()
        {

        }

        ~Voiture()
        {
            CouperContact();
        }
    }
}
