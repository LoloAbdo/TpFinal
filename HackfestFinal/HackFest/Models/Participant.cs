using System;
using System.ComponentModel.DataAnnotations;

namespace HackFest.Models
{
    public sealed class Participant
    {
        [Key]
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

    }
}
