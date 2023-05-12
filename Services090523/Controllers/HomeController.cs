using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services090523.Models;
using Services090523.Servives;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Services090523.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRandomNumber RandomNumeri;

        public HomeController(ILogger<HomeController> logger, IRandomNumber RandomNumeri)
        {
            _logger = logger;
            this.RandomNumeri = RandomNumeri;
        }

        public IActionResult RandomNumberPage()
        {
            RandomNumberPageModel model = new RandomNumberPageModel();
            model.RandomNum = this.RandomNumeri.GeneratoreRandom();
            return View(model);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
