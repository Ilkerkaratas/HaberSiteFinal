using HaberSiteFinal.Models;
using HaberSiteFinal.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSiteFinal.Controllers
{
    public class HomeController : Controller
    {
        HaberRepository haberRepository = new HaberRepository();
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(haberRepository.TList());
        }
        [AllowAnonymous]
        public IActionResult CategoryDetails(int id)
        {
            ViewBag.x = id;
            return View();
        }
       
        
    }
}

