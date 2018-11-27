using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public class Membre
    {
        [Key]
        public int ID_Membre { get; set; }

        [ForeignKey("Participant")]
        public int ID_Participant { get; set; }
        public Participant Participant { get; set; }
    }
}
