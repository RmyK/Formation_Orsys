using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleBusiness.DataModels
{
    public class Eleve : Personne
    {
        public int Moyenne { get; set; }
        public int Id { get; internal set; }

        public override string Afficher()
        {
            return $"{base.Afficher()} Moyenne : {Moyenne}";
        }

    }
}
