
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
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using EjemploASP.Modelo;
namespace EjemploASP.Controllers
{
    [Route("billingController")]
    public class BilligController : Controller
    {

        [Route("Pay")]
        //[HttpPost]
        public IActionResult Pay()
        {
            Console.WriteLine("Pagar");
            return View("Views/CheckOut/Pay.cshtml");
        }

        [Route("GoBack")] 
        public IActionResult GoBack()
        {
            IProductoService productoService = new ProductoService();
            List<Producto> listaProductos = new List<Producto>();
            listaProductos = productoService.findProductos();
            List<Producto> listaVacia = new List<Producto>();
            ViewData["Cart"] = listaVacia;
            ViewData["Precio"] = 0;
            return View("Views/Productos/Productos.cshtml",listaProductos);
        }

        [Route("VerMenu")] 
        public IActionResult VerMenu()
        {
            List<Producto> listaProductos = new List<Producto>();
            IProductoService productoService = new ProductoService();
            listaProductos = productoService.findProductos();
            List<Producto> listaVacia = new List<Producto>();
            ViewData["Cart"] = listaVacia;
            ViewData["Costo"] = 0; 
            return View ("Views/Productos/productos.cshtml",listaProductos); 
        }

        [Route("PayBill")] 
        [HttpPost]
        public IActionResult PayBill(Tarjeta tarjeta)
        {
            Console.WriteLine("PayBill");
            Console.WriteLine(tarjeta.CVV);
            Console.WriteLine(tarjeta.FechaExpiracion);
            if (tarjeta.NumeroTarjeta ==  null || tarjeta.FechaExpiracion == null || tarjeta.CVV == null)
            {
                return View ("Views/Validation/ErrorTarjeta.cshtml");
            }
            RemoteServices rm = new RemoteServices();
            bool validate=rm.serviceValidarTarjeta(tarjeta.NumeroTarjeta,tarjeta.FechaExpiracion,tarjeta.CVV);
        
            //bool validate = IsCreditCardInfoValid(tarjeta.NumeroTarjeta,tarjeta.FechaExpiracion,tarjeta.CVV );
            
            if (validate){
                
                //------------------------------------------------------------------------
                //Save in the database
                //------------------------------------------------------------------------
                return View ("Views/Validation/PedidoRealizado.cshtml");
            }
            else{
                return View ("Views/Validation/ErrorTarjetaCredito.cshtml");
            }
        }
        
        [Route("Next")] 
        public IActionResult Next(PedidoVirtual pedido)
        {
            //PedidoVirtual pedido = new PedidoVirtual();
            //PedidoVirtual pedido = JsonConvert.DeserializeObject<PedidoVirtual>(json);
            Console.WriteLine("pedido.TipoEntrega -- "+pedido.TipoEntrega);
            Console.WriteLine("pedido.MetodoPago -- "+pedido.MetodoPago);
            
            if(pedido.TipoEntrega == "Domicilio")
            {
                return View ("Views/CheckOut/Domicilio.cshtml");   
            }
            else 
            {
                return View ("Views/CheckOut/Recoger.cshtml");   
            }
        }

        public static bool IsCreditCardInfoValid(string cardNo, string expiryDate, string cvv)
        {
            //var cardCheck = new Regex(@"^(1298|1267|4512|4567|8901|8933)([\-\s]?[0-9]{4}){3}$");
            var cardCheck = new Regex(@"^\d{16}$");
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            var cvvCheck = new Regex(@"^\d{3}$");

            if (!cardCheck.IsMatch(cardNo)) // <1>check card number is valid
                return false;
            if (!cvvCheck.IsMatch(cvv)) // <2>check cvv is valid as "999"
                return false;

            var dateParts = expiryDate.Split('/'); //expiry date in from MM/yyyy            
            if (!monthCheck.IsMatch(dateParts[0]) || !yearCheck.IsMatch(dateParts[1])) // <3 - 6>
                return false; // ^ check date format is valid as "MM/yyyy"

            var year = int.Parse(dateParts[1]);
            var month = int.Parse(dateParts[0]);            
            var lastDateOfExpiryMonth = DateTime.DaysInMonth(year, month); //get actual expiry date
            var cardExpiry = new DateTime(year, month, lastDateOfExpiryMonth, 23, 59, 59);

            //check expiry greater than today & within next 6 years <7, 8>>
            return (cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6));
        }
    }
}