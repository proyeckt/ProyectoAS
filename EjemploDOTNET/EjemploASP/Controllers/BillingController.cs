
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
        public IActionResult BillResponse(Usuario)
        {
            Console.WriteLine("Pagar");
            return View("Views/CheckOut/Pay.cshtml",Usuario);
        }

        [Route("GoBack")] 
        public IActionResult GoBack()
        {
            return View("Views/Login/Error.cshtml");
        }

        [Route("PayBill")] 
        public IActionResult PayBill()
        {
            //Tarjeta int, cvv

            return View("Views/Login/Error.cshtml");
        }

    }
}