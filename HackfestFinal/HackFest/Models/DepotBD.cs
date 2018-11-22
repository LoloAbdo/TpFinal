using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public sealed class DepotBD : IDepot
    {

        #region VariableGlobales
        private ContextBD _context;
        #endregion

        #region contructeur
        public DepotBD(ContextBD p_context)
        {
            _context = p_context;
        }
        #endregion
        public IQueryable<Participant> participants() => _context.Participants;
        

        public void AjouterParticipants(Participant p_participant)
        {
            if (p_participant.ID_Participant == 0)
            {
                _context.Participants.Add(p_participant);
            }
            else
            {
                Participant monParticipant = _context.Participants
                                                     .FirstOrDefault(x => x.ID_Participant ==
                                                      p_participant.ID_Participant);
                if (monParticipant != null)
                {
                    monParticipant.Prenom = p_participant.Prenom;
                    monParticipant.Nom = p_participant.Nom;
                    monParticipant.Couriel = p_participant.Couriel;
                    monParticipant.Date_inscription = p_participant.Date_inscription;
                    monParticipant.Affiliation = p_participant.Affiliation;
                }
            }
            _context.SaveChanges();
        }


        public void SoumettreChangements()
        {
        }
    }
}
