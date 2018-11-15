using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public class Participant
    {
        public int ID_Participant { get; set; }

        [Required(ErrorMessage = "SVP, inscrivez votre prénom")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "SVP inscrivez votre nom")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "SVP inscrivez votre couriel")]
        public string Couriel { get; set; }

        [Required(ErrorMessage = "SVP spécifier une affiliaton")]
        public string Affiliation { get; set; }

        [Required(ErrorMessage = "SVP veuillez spécifier une date")]
        public DateTime Date_inscription { get; set; }

        [Required(ErrorMessage = "SVP inscrivez un montant")]
        public int Montant { get; set; }
    }
}
