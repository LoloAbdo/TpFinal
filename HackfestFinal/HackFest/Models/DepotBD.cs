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
        public IQueryable<Organisateur> organisateurs() => _context.Organisateurs;
        

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

        public void AjouterOrganisateur(Organisateur p_organisateur)
        {
            if (p_organisateur.ID_Organisateur == 0)
            {
                _context.Organisateurs.Add(p_organisateur);
            }
            else
            {
                Organisateur monOrganisateur = _context.Organisateurs
                                                     .FirstOrDefault(x => x.ID_Organisateur ==
                                                      p_organisateur.ID_Organisateur);
                if (monOrganisateur != null)
                {
                    monOrganisateur.ID_Participant = p_organisateur.ID_Participant;
                    monOrganisateur.MotDePasse = p_organisateur.MotDePasse;
                    monOrganisateur.RoleOrganisteur = p_organisateur.RoleOrganisteur;
                }
            }
            _context.SaveChanges();
        }
    }
}
