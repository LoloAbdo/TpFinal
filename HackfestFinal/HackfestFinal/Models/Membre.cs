using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackfestFinal.Models
{
    public class Membre
    {
        public int ID_Membre { get; set; }

        public Participant ID_Participant { get; set; }
    }
}
