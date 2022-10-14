using EcoleBusiness.Services;
using EcoleWASM.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcoleWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EleveController : ControllerBase
    {
        private readonly EleveService eleveService;

        public EleveController(EleveService eleveSrv)
        {
            eleveService = eleveSrv;
        }

        [HttpGet]
        public IEnumerable<EleveDTO> GetEleves()
        {
            var eleves = eleveService.GetEleves();
            var dtos = eleves.Select(
                e => new EleveDTO()
                {
                    Age = e.Age,
                    DateNaissance = e.DateNaissance,
                    Id = e.Id,
                    Moyenne = e.Moyenne,
                    Nom = e.Nom,
                    Prenom = e.Prenom
                }) ;
            return dtos;
        }

        [HttpGet("getelevebyid/{id?}")]
        public void GetEleveById(int? id)
        {

        }

        [HttpPost]
        public void PostEleve(EleveDTO eleve)
        {

        }

    }
}
