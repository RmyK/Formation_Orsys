using EcoleBusiness.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleBusiness.Services
{
    public class EcoleService
    {
        public Ecole MonEcole { get; set; }

        public void Embaucher(ISalarie salarie)
        {
            Personne p = null;
            if (salarie is Personne)
                p = (Personne)salarie;

            //Exemple d'écriture à l'aide d'un opérateur ternaire
            //Personne p2 = salarie is Personne ? (Personne)salarie : null;

            if (p != null)
            {
                p.Id = ++MonEcole.NbPersonnel;
                MonEcole.Personnes.Add(p);
            }
        }

        public void Inscrire(Eleve eleve)
        {
            eleve.Id = ++MonEcole.NbEleve;
            MonEcole.Personnes.Add(eleve);
        }

        public void AfficherEleve()
        {
            foreach (Personne personne in MonEcole.Personnes)
            {
                if (personne is Eleve)
                    Console.WriteLine(personne.Afficher());
            }
        }

        public void AfficherPersonnel()
        {
            foreach (Personne personne in MonEcole.Personnes)
            {
                if (personne is Administratif || personne is Professeur)
                    Console.WriteLine(personne.Afficher());
            }
        }

        public void AfficherPersonne()
        {
            foreach (Personne personne in MonEcole.Personnes)
            {
                personne.Afficher();
            }
        }

        public EcoleService(Ecole ecole)
        {
            MonEcole = ecole;
        }
    }
}
