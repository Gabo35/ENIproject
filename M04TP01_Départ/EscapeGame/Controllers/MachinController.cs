﻿using EscapeGame.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EscapeGame.Controllers
{
    public class MachinController : Controller
    {
        private readonly ILogger<MachinController> _logger;

        public MachinController(ILogger<MachinController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Truc()
        {
            return View();
        }

        public IActionResult Bidule(int id) 
        {
            ViewBag.Id = id;
            return View();
        }
        

        public IActionResult Fin(int v1, int v2)
        {
            ViewBag.Valeur = v1 * v2;
            return View();
        }

        public IActionResult Jo()
        {
            return View();
        }

        public IActionResult Suite()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}