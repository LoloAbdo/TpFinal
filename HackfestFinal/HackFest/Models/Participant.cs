using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace HackFest.Models
{
    public sealed class Participant
    {
        [Key]
        public int ID_Participant { get; set; }

        [Required(ErrorMessage = "SVP, inscrivez votre prénom")]
        [Display(Name = "Votre Prenom:")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "SVP inscrivez votre nom")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Couriel { get; set; }

        [Required(ErrorMessage = "SVP spécifier une affiliaton")]
        public string Affiliation { get; set; }

        [UIHint("Date")]
        [Required(ErrorMessage = "Entrez une date svp.")]
        [Remote("ValideDate", "Home")] //(NomDeLaMethode, Emplacement)
        public DateTime Date_inscription { get; set; }

    }
}
