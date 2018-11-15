using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HackFest.Controllers
{
    public sealed class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}