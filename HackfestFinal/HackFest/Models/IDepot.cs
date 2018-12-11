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

        void AjouterOrganisateur(Organisateur p_organisateur);

        void AjouterUnPaiement(Paiement p_paiement);

        void SoumettreChangements();
    }
}
