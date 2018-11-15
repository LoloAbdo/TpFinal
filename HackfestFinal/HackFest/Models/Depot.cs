using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public class Depot
    {
        private static List<Connexion> utilisateurs = new List<Connexion>();
        public List<Connexion> utilisateursPublic = new List<Connexion>();
        public static IEnumerable<Connexion> Utilisateurs
        {
            get { return utilisateurs; }
        }

        public static void AjouterUitlisateur(Connexion p_utilisateur)
        {
            utilisateurs.Add(p_utilisateur);
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
