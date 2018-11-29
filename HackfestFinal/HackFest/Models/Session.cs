using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public class Session
    {
        [Key, ForeignKey("Article")]
        public int ID_Article { get; set; }
        public Article Article { get; set; }
        [Key, ForeignKey("Membre")]
        public int ID_Membre { get; set; }
        public Membre Membre { get; set; }
        public string TitreSession { get; set; }
        public DateTime DateSession { get; set; }
        public DateTime Heures { get; set; }

    }
}
