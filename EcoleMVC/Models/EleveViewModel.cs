using EcoleBusiness.DataModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EcoleMVC.Models
{
    public class EleveViewModel : IValidatableObject
    {
        private Eleve monModel { get; set; }

        public int Id => monModel.Id;

        [DisplayName("Nom")]
        [Required(ErrorMessage ="Nom est obligatoire")]
        public string Nom
        {
            get => monModel.Nom;
            set => monModel.Nom = value;
        }

        [DisplayName("Prénom")]
        [Required(ErrorMessage = "Prénom est obligatoire")]
        public string Prenom
        {
            get => monModel.Prenom;
            set => monModel.Prenom = value;
        }

        [DisplayName("Date de naissance")]
        public DateTime? DateNaissance
        {
            get => monModel.DateNaissance;
            set => monModel.DateNaissance = value ?? new DateTime(2000,1,1);
        }

        [DisplayName("Date de naissance")]
        public string ShortDate => DateNaissance?.ToShortDateString();

        [Range(0,20, ErrorMessage ="La moyenne doit être comprise entre 0 et 20")]
        [DisplayName("Moyenne")]
        public int? Moyenne
        {
            get => monModel.Moyenne;
            set => monModel.Moyenne = value ?? 0;
        }

        [DisplayName("Age")]
        public string Age => $"{monModel.GetAge()} ans";

        public Eleve MonModel => monModel;

        public bool IsDetail { get; set; } = false;

        public EleveViewModel()
        {
            monModel = new Eleve() { EcoleId = 1 };
        }

        public EleveViewModel(Eleve eleve)
        {
            monModel = eleve;
        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateNaissance > DateTime.Now)
                yield return new ValidationResult("La date de naissance ne peut pas être dans le futur", new string[] { nameof(DateNaissance) });
        }
    }
}
