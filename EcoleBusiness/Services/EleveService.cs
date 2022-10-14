using EcoleBusiness.DataModels;
using EcoleBusiness.Services.DataAccess;
using EcoleBusiness.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleBusiness.Services
{
    public class EleveService : IElevesService
    {
        public void InsertOrUpdateEleve(Eleve eleve)
        {
            var repo = new Repository();
            if (eleve.Id == 0)
                repo.Insert(eleve);
            else
                repo.Update(eleve);
        }

        public List<Eleve> GetEleves()
        {
            var repo = new Repository();
            return repo.GetAll<Eleve>().ToList();
        }

        public Eleve GetEleveById(int id)
        {
            var repo = new Repository();
            return repo.GetById<Eleve>(id);
        }
    }
}
