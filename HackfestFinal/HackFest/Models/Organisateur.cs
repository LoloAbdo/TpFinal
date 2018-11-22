using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public class Organisateur
    {
        [Key]
        public int ID_Organisateur { get; set; }
        
        public int ID_Participant { get; set; }


        public enum Role
        {
            PresidentCO,
            President
        }


    }
}
