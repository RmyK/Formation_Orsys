using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleBusiness.DataModels
{
    public class Ecole
    {
        public int NbEleve { get; set; }
        public int NbPersonnel { get; set; }
        public List<Personne> Personnes { get; set; } = new List<Personne>();
        public string Nom { get; set; }

        public Ecole()
        {
            Personnes.Add(new Eleve() { Id = 1, Nom = "Oumal", Prenom = "Fabien", Moyenne = 12, DateNaissance = new DateTime(2012, 9, 14) });
            Personnes.Add(new Eleve() { Id = 2, Nom = "DePoheur", Prenom = "Agathe", Moyenne = 15, DateNaissance = new DateTime(2009, 2, 4) });
            Personnes.Add(new Professeur() { Id = 1, Nom = "Erie", Prenom = "Yann", Matiere = new Matiere() { Coefficient = 4, Libelle = "Science" }, DateNaissance = new DateTime(1984, 4, 17) });
            Personnes.Add(new Professeur() { Id=2, Nom = "Mobil",Prenom="Otto",Matiere = new Matiere() {Coefficient =5, Libelle="Sport" }, DateNaissance = new DateTime(1978, 3, 22) });
            Personnes.Add(new Administratif() { Id = 1, Nom = "Sion", Prenom = "Eva", Fonction = new Fonction() { Libelle = "Principale", Service = "Administration" }, DateNaissance = new DateTime(1989, 11, 19) });
            NbEleve = 2;
            NbPersonnel = 3;
        }
    }
}
