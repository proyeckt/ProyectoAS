
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
    [Route("productController")]
    public class ProductController : Controller
    {

        List<Producto> cart = new List<Producto>();

        [Route("AddToCart")]
        public IActionResult AddToCart(int nombre)
        {

            Console.WriteLine(nombre);
            IProductoService productoService = new ProductoService();
            Producto producto = productoService.findProducto(nombre);
            cart.Add(producto);
            
            ViewData["Cart"] = cart;

            return View ("Views/Login/Error.cshtml"); 
        }
/* 

        public Tarjeta tarjeta{get; set;}

        public BilligController(){
            tarjeta = new Tarjeta();
        } */

        [Route("Pay")]
        //[HttpPost]
        public IActionResult BillResponse()
        {
            Console.WriteLine("Pagar");
            return View("Views/CheckOut/Pay.cshtml");
        }

        [Route("GoBack")] 
        public IActionResult GoBack()
        {
            return View("Views/Login/Error.cshtml");
        }

        [Route("PayBill")] 
        [HttpPost]
        public IActionResult PayBill(Tarjeta tarjeta)
        {
            Console.WriteLine("PayBill");
            Console.WriteLine(tarjeta.CVV);
            Console.WriteLine(tarjeta.FechaExpiracion);
            return View("Views/Login/Error.cshtml");
        }
    }
}