using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackFest.Models;

namespace HackFest.Controllers
{
    public sealed class HomeController : Controller
    {
        #region Interfaces
        private IDepot idepot;
        #endregion

        #region Constructeur
        public HomeController(IDepot p_depot) => this.idepot = p_depot;
        
        #endregion

        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Inscriptions()
        {
            return View();
        }
        [HttpGet]
        public ViewResult InscriptionsCO()
        {
            return View();
        }
        [HttpGet]
        public ViewResult InscriptionsPaiement()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Panel()
        {
            return View("Panel");
        }
        [HttpPost]
        public ViewResult Inscriptions(Participant participant)
        {
            if (ModelState.IsValid)
            {
                idepot.AjouterParticipants(participant);
                return View("MerciInscription", participant);
            }
            else
                return View();
        }
        [HttpPost]
        public ViewResult InscriptionsCO(Organisateur organisateur)
        {
            if (ModelState.IsValid)
            {
                idepot.AjouterOrganisateur(organisateur);
                return View("MerciInscription", organisateur);
            }
            else
                return View();
        }
        [HttpPost]
        public ViewResult InscriptionsPaiement(Paiement paiement)
        {
            if (ModelState.IsValid)
            {
                idepot.AjouterUnPaiement(paiement);
                //TODO: Refaire une page merci Paiement 
                return View("MerciInscription", paiement);
            }
            else
                return View();
        }

        //Debut des posts
        [HttpPost]
        public ViewResult Index(Connexion p_connexion)
        {
                  
            if (ModelState.IsValid)
            {
                #region Connexion
                string sNom ="";
                Depot depot = new Depot();

                //Requete LINQ qui verifie dans la liste de gens interne s'ils existent.
                var req = from d in depot.utilisateursPublic
                          where d.User == p_connexion.User && d.Password == p_connexion.Password
                          select d.User;

                foreach (var x in req)               
                    sNom += x;
                
                if (sNom == p_connexion.User.ToString())
                   return View("Panel", p_connexion);            
                else
                    return View();
                #endregion
            }
            else
            {
                return View();
            }
        }
    }
}