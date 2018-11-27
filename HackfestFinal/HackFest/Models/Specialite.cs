using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public class Specialite
    {
        [Key]
        public int ID_Specialite { get; set; }

        [ForeignKey("Membre")]
        public int ID_Membre { get; set; }
        public Membre Membre { get; set; }

        [Required(ErrorMessage ="Veuillez entrer la description de la specialite")]
        public string DescriptionSpecialite { get; set; }
    }
}
