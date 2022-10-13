using EcoleBusiness.DataModels;
using EcoleBusiness.Services.DataAccess;
using Microsoft.EntityFrameworkCore;
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

        public Ecole GetEcole(int id)
        {
            var repo = new Repository();
            return repo.GetById<Ecole>(id);
        }

        public IEnumerable<Personne> GetAllMembres(int id)
        {
            var lst = new List<Personne>();
            using var ctx = new EcoleDbContext();

            lst.AddRange(
                ctx.Eleves
                .Where(e => e.EcoleId == id)
                .Select(e => (Personne)e)
                .ToList()
                );
            lst.AddRange(
                ctx.Administratifs
                .Where(e => e.EcoleId == id)
                .Include(e=>e.Fonction)
                .Select(e => (Personne)e)
                .ToList()
                );
            lst.AddRange(
                ctx.Professeurs
                .Where(e => e.EcoleId == id)
                .Include(e => e.Matiere)
                .Select(e => (Personne)e)
                .ToList()
                );

            return lst;
        }
            

        public void Inscrire(Eleve eleve)
        {
            var eleveService = new EleveService();
            eleveService.InsertOrUpdateEleve(eleve);
        }

        public void AfficherEleve()
        {
            foreach (Personne personne in MonEcole.Personnes)
            {
                if (personne is Eleve)
                    Console.WriteLine(personne.Afficher());
            }
        }

        public List<Eleve> GetEleves()
        {
            return MonEcole?.Personnes
                .Where(p => p is Eleve)
                .Select(e=>(Eleve)e)
                .ToList();
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

        public EcoleService(int id)
        {
            MonEcole = GetEcole(id);
            MonEcole.Personnes = GetAllMembres(id).ToList();
        }
    }
}
