using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleBusiness.DataModels
{
    public class Administratif : Personne, ISalarie
    {
        public Fonction? Fonction { get; set; }
        public decimal Salaire { get; set; }

        public override string Afficher()
        {
            return $"{base.Afficher()} Service : {Fonction.Service} - Fonction : {Fonction.Libelle}";
        }
    }
}
