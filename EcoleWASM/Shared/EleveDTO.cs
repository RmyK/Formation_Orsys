using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleWASM.Shared
{
    public class EleveDTO
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public DateTime DateNaissance { get; set; }
        public int Moyenne { get; set; }
    }
}
