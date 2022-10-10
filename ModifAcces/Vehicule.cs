using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifAcces
{
    internal abstract class Vehicule
    {
        public Guid NumeroSerie { get; private set; }

        //public string Proprietaire { get; set; }

        private string proprietaire;
        public string Proprietaire
        {
            get { return proprietaire; }
            set
            {
                proprietaire = value;
                Console.WriteLine("Le proprio de ce véhicule est " + value);
            }
        }

        protected int QteCarburant { get; set; }
        public DateTime DateDernierEntretien { get; set; }

        public void Demarrer()
        {

        }

        public void ReparerMoteur()
        {

        }


        private void Generer_NumSerie()
        {
            NumeroSerie = Guid.NewGuid();
        }

        public Vehicule()
        {
            Generer_NumSerie();
        }

    }
}
