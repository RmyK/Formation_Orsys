using EcoleBusiness.DataModels;
using EcoleBusiness.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleBusiness.Services
{
    public class EleveMockService : IElevesService
    {
        public Eleve GetEleveById(int id)
        {
            return new Eleve() { Id = 1, Nom = "Car", Prenom = "Otto", DateNaissance = new DateTime(2008, 5, 15), Moyenne = 13 };
        }

        public List<Eleve> GetEleves()
        {
            return new List<Eleve>() {
                new Eleve() { Id = 1, Nom = "Car", Prenom = "Otto", DateNaissance = new DateTime(2008,5,15), Moyenne = 13 }
                };
        }

        public void InsertOrUpdateEleve(Eleve eleve)
        {

        }
    }
}
