using EcoleBusiness.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleBusiness.Services.IServices
{
    public interface IElevesService
    {
        void InsertOrUpdateEleve(Eleve eleve);
        List<Eleve> GetEleves();

        Eleve GetEleveById(int id);
    }
}
