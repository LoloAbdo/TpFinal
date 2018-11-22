using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public interface IDepot
    {
        IQueryable<Participant> participants();

        void AjouterParticipants(Participant p_participant);

        void SoumettreChangements();
    }
}
