﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    /*
    - Creare nella pagina Javascript.cshtml un nuovo tasto che
    chiami un endpoint di tipo GET GetMusicModels che restituisca
    una lista di oggetti di tipo MusicModel (da creare nella
    folder models).
    - la classe Music ha due properties:
        - string Cantante
        - string Canzone
    - Loggare in console e scrivere in pagina il risultato ottenuto 
    dall'endpoint
     
     */
    /*
     - Creare una nuova view (InputUtente.cshtml) con un input html.
     - tramite un button mandare il valore dell'input al backend
    tramite un endpoint GetFormValue
     - restituire al client il messaggio "Input ricevuto correttamente"
     - nel frontend stampare su schermo il messaggio ricevuto dal backend
     */
    /*
     - Creare una nuova view (RandomNumber.cshtml) con un button che
    chiami un endpoint GetRandomNumber sul backend
     - tramite l'endpoint restituire al client un numero casuale qualsiasi
     - nel frontend stampare su schermo il numero ricevuto dal backend
     */
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ContactViewModel model = new ContactViewModel();
            model.Nome = "Vane";
            model.Cognome = "Dleu";
     
            return View(model);
        }

        public IActionResult Javascript()
        {
            return View();
        }

        public IActionResult InputUtente()
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
