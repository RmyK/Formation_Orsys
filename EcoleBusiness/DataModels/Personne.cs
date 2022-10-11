using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleBusiness.DataModels
{
    public abstract class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public int Age
        {
            get
            {
                return (int)DateTime.Now.Subtract(DateNaissance).TotalDays / 365;
            }
        }

        public int Age2 => (int)DateTime.Now.Subtract(DateNaissance).TotalDays / 365;

        public int GetAge()
        {
            return (int)DateTime.Now.Subtract(DateNaissance).TotalDays / 365;
        }

        public virtual string Afficher()
        {
            return $"{Nom} {Prenom} - Age : {Age} ans";
        }
    }
}
