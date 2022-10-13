using EcoleBusiness.DataModels;
using EcoleBusiness.Services.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleBusiness.Services
{
    public class EleveService
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
    }
}
