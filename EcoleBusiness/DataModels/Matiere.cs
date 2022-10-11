using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleBusiness.DataModels
{
    public class Matiere
    {
        public string Libelle { get; set; }
        public int Coefficient { get; set; }
    }
}
