using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public class Article
    {
        [Key]
        public int ID_Article { get; set; }

        [ForeignKey("Participant")]
        public int ID_Participant { get; set; }
        public Participant Participant { get; set; }

        [Required(ErrorMessage ="Veuillez entrer un titre d'article")]
        public string TitreArticle { get; set; }






    }
}
