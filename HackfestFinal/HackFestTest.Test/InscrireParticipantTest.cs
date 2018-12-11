using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using HackFest.Models;
using HackFest.Controllers;

namespace HackFestTest.Test
{
    [TestClass]
    public class InscrireParticipantTest
    {
        //Réponse réponse = new Réponse() { Nom = "Bob" };
        //Dépôt unDépôt = new Dépôt();
        //unDépôt.AjouterRéponse(réponse);
        readonly DepotBD depot = new DepotBD();
     

        HomeController homeController = new HomeController(depot);
    }
}
