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
        public DepotBD()
        {

        }
        #endregion
        public IQueryable<Participant> participants() => _context.Participants;
        public IQueryable<Organisateur> organisateurs() => _context.Organisateurs;
        public IQueryable<Paiement> paiements() => _context.Paiements;


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
                    monOrganisateur.Participant.Prenom = p_organisateur.Participant.Prenom;
                    monOrganisateur.Participant.Nom = p_organisateur.Participant.Nom;
                    monOrganisateur.Participant.Couriel = p_organisateur.Participant.Couriel;
                    monOrganisateur.Participant.Affiliation = p_organisateur.Participant.Affiliation;
                    monOrganisateur.Participant.Date_inscription = p_organisateur.Participant.Date_inscription;
                    monOrganisateur.ID_Participant = p_organisateur.Participant.ID_Participant;
                    monOrganisateur.MotDePasse = p_organisateur.MotDePasse;
                    monOrganisateur.RoleOrganisteur = p_organisateur.RoleOrganisteur;
                }
            }
            _context.SaveChanges();
        }

        public void AjouterUnPaiement(Paiement p_paiement)
        {
            if (p_paiement.ID_Paiement == 0)
            {
                _context.Paiements.Add(p_paiement);
            }
            else
            {
                Paiement monPaiement = _context.Paiements
                                               .FirstOrDefault(x => x.ID_Paiement ==
                                                p_paiement.ID_Paiement);

                if (monPaiement != null)
                {
                    monPaiement.Participant.Prenom = p_paiement.Participant.Prenom;
                    monPaiement.Participant.Nom = p_paiement.Participant.Nom;
                    monPaiement.Participant.Couriel = p_paiement.Participant.Couriel;
                    monPaiement.Participant.Affiliation = p_paiement.Participant.Affiliation;
                    monPaiement.Participant.Date_inscription = p_paiement.Participant.Date_inscription;
                    monPaiement.ID_Participant = p_paiement.Participant.ID_Participant;
                    monPaiement.Montant = p_paiement.Montant;
                    monPaiement.DateReceptionPaiement = p_paiement.DateReceptionPaiement;
                }
            }
            _context.SaveChanges();
        }
    }
}
