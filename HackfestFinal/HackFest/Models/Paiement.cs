using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public class Paiement
    {
        [Key]
        public int ID_Paiement { get; set; }

        [ForeignKey("Participant")]
        public int ID_Participant { get; set; }
        public Participant Participant { get; set; }

        [Required(ErrorMessage = "Vous devez entrer un montant")]
        public double Montant { get; set; }

        [Required(ErrorMessage = "Veuillez selectionner une Date de paiement")]
        public DateTime DateReceptionPaiement { get; set; }
    }
}
