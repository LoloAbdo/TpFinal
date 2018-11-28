using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public class MembreArticle
    {
        [Key ,ForeignKey("Article")]
        public int ID_Article { get; set; }
        public Article Article { get; set; }
        [Key ,ForeignKey("Membre")]
        public int ID_Membre { get; set; }
        public Membre Membre { get; set; }

        [Required(ErrorMessage ="Veuillez entrer la note")]
        [Range((byte)0 ,(byte)10 , ErrorMessage ="Veuillez entrer entre 0 et 10") ]
        public byte Note { get; set; }
    }
}
