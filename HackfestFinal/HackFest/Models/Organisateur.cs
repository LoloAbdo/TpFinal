using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public class Organisateur
    {
        public enum Role
        {
            PrésidentComitéOrganisateur,
            PrésidentComitéDeProgramme,
            ResponsableDesFinances,
            ResponsableDesArticles
        }


        [Key]
        public int ID_Organisateur { get; set; }
        
        [ForeignKey("Participant")]
        public int ID_Participant { get; set; }

        public Participant Participant { get; set; }

        //[RegularExpression(@"^ (?=.*[a - z])(?=.*[A - Z])(?=.*\d).{8, 15}$)",
        //                  ErrorMessage = "Il vous faut au moins 8 caracteres, une majuscule et un chiffre")]
        [StringLength(20, MinimumLength = 8)]
        public string MotDePasse { get; set; }

        [Required(ErrorMessage = "Entrez un rôle")]
        public Role RoleOrganisteur { get; set; }
    }
}
