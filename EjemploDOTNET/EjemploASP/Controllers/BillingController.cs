
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Entities;
using Services.Implementation;
using Services.Contracts;

namespace EjemploASP.Controllers
{
    [Route("billingController")]
    public class BilligController : Controller
    {
        [Route("Pay")]
        //[HttpPost]
        public IActionResult BillResponse()
        {
            Console.WriteLine("Pagar");
            return View("Bienvenido");
        }

        [Route("GoBack")] 
        public IActionResult BillGoBack()
        {
            return View("Error");
        }
    }
}