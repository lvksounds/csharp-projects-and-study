using formteste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace formteste.Controllers
{
    [BindProperties]
    public class HomeController : Controller
    {
        public PersonModel Person { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]        
        public IActionResult Post()
        {            
            return Ok($"EMail: {this.Person.Email}, password: {this.Person.Email}");
        }

        public IActionResult Data(PersonModel model)
        {
            return View(model);
        }

       
    }
}
