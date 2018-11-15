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
        [HttpGet]
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
        //Debut des posts
        [HttpPost]
        public ViewResult Index(Connexion p_connexion)
        {
            
         
            if (ModelState.IsValid)
            {
                Depot depot = new Depot();
               
                //On prend l'utilisateur dans la bd
                //var req = from d in depot.utilisateurs
                //          where d.User == p_connexion.User && d.Password == p_connexion.Password
                //          select d.User.FirstOrDefault();
               

                //Depot.AjouterUitlisateur(p_connexion);
                //return View(Depot.Utilisateurs.Where(x=> x.User == p_connexion.User && x.Password == p_connexion.Password))
                return View("Panel" , p_connexion);
            }
            else
            {
                return View();
            }
        }
    }
}