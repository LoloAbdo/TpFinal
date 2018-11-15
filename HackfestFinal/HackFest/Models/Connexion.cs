using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public class Connexion
    {
        [Required(ErrorMessage = "SVP entrez votre nom d'utilisateur.")]
        public string User { get; set; }
        [Required(ErrorMessage = "SVP entrez votre mot de passe.")]
        public string Password { get; set; }
    }
}
