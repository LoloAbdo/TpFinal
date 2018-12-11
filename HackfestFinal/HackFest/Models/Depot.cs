using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    /// <summary>
    /// 
    /// 
    /// CECI EST UN DEPOT INUTILE , IL SERT SEULEMENT A LA FAUSSE CONNEXION
    /// SI VOUS VOULEZ VOIR LE VRAI DEPOT , IL SE NOMME DEPOTBD
    /// 
    /// </summary>
    public class Depot
    {
        private static List<Connexion> utilisateurs = new List<Connexion>();
        private static List<Participant> participants = new List<Participant>();
        public List<Connexion> utilisateursPublic = new List<Connexion>() {
            new Connexion()
            {
                User ="Marc",
                Password="Incrypte"
            },
            new Connexion()
            {
                User = "Henri",
                Password = "password"
            }
        };
        public static IEnumerable<Connexion> Utilisateurs
        {
            get { return utilisateurs; }
        }

        public static void AjouterUitlisateur(Connexion p_utilisateur)
        {
            utilisateurs.Add(p_utilisateur);
        }

        public static void AjouterParticipant(Participant p_participant)
        {
            participants.Add(p_participant);
        }

        /// <summary>
        /// Contient une liste d'utilisateur qui seront la par default.
        /// On les utilisera pour se connecter
        /// </summary>
        public static void LoaderUtilisateurs()
        {
            utilisateurs.Add(new Connexion
            {
                User ="Marc",
                Password="Incrypte"
            });
            utilisateurs.Add(new Connexion
            {
                User = "Henri",
                Password = "password"
            });
        }

       
    }
}
