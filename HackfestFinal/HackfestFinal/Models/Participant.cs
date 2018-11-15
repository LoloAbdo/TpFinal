using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackfestFinal.Models
{
    public class Participant
    {
        public int ID_Participant { get; set; }

        [Required(ErrorMessage = "SVP Entrez votre prénom")]
        public string prenom_Participant { get; set; }

        [Required(ErrorMessage = "SVP Entrez votre nom")]
        public string nom_participant { get; set; }

        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Entrez votre adresse couriel")]
        public string couriel_participant { get; set; }

        public string affiliation { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Required(ErrorMessage = "Vous devez entrez une Date")]
        public DateTime? date_Inscription { get; set; }
        [Required]
        public decimal montant { get; set; }

    }
}
