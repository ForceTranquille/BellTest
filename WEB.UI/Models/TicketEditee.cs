using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB.UI.Models
{
    public class TicketEditee : IValidatableObject
    {
        
        [Display(Name = "Numéro du billet")]
        public int? TICKETNO { get; set; }
        [Display(Name = "Demandé par")]
        public int EMPNO { get; set; }
        [Required]
        [Display(Name = "Nom du projet")]
        public string PROJECTNAME { get; set; }
        [Required]
        [Display(Name = "Description du problème")]
        public string DESCRIPTION { get; set; }
        [Required]
        [Display(Name = "Date soumission")]
        public System.DateTime DATECREATION { get; set; }

        public virtual EmployeeEditee EmployeeEditee { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var resultats = new List<ValidationResult>();
            if (DATECREATION < DateTime.UtcNow)
            {
                var erreur = new ValidationResult(
                    "vous devez soumettre votre billet a une date supérieur à la date actuelle",
                    new List<string> { "DATECREATION" });

                resultats.Add(erreur);
            }

            return resultats;
        }
    }
}