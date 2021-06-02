
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
using System.Web.Helpers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EjemploASP.Controllers
{
    [Route("productController")]
    public class ProductController : Controller
    {

        //List<Producto> cart = new List<Producto>();

        [Route("AddToCart")]
        //nombre es el ID, la palabra ID esta reservada
        public IActionResult AddToCart(int nombre, string json, double costo)
        {
            Console.WriteLine(json);
            
            List<Producto> productos =  JsonSerializer.Deserialize<List<Producto>>(json);
            IProductoService productoService = new ProductoService();
            Producto producto = productoService.findProducto(nombre);
            if (producto.Cantidad > 0)
            {
                productos.Add(producto);
                costo += producto.Precio;
            }
            else
                ViewBag.Message = "No hay disponibilidad de este sanduche";
            
            Console.WriteLine(costo);
            List<Producto> listaProductos = new List<Producto>();
            listaProductos = productoService.findProductos();

            ViewData["Cart"] = productos;
            ViewData["Costo"] = costo; 
            return View ("Views/Productos/productos.cshtml",listaProductos); 
        }
/* 

        public Tarjeta tarjeta{get; set;}

        public BilligController(){
            tarjeta = new Tarjeta();
        } */

        [Route("Pay")]
        //[HttpPost]
        public IActionResult Pay(string json, double costo)
        {
            if(costo == 0)
            {
                ViewBag.Message = "El carrito se encuentra vacio";
                List<Producto> listaProductos = new List<Producto>();
                IProductoService productoService = new ProductoService();
                listaProductos = productoService.findProductos();
                List<Producto> listaVacia = new List<Producto>();
                ViewData["Cart"] = listaVacia;
                ViewData["Costo"] = costo; 
                return View ("Views/Productos/productos.cshtml",listaProductos); 
            }
            Console.WriteLine(json);
            List<Producto> productos =  JsonSerializer.Deserialize<List<Producto>>(json);
            ViewData["Precio"] = costo;
            ViewData["Cart"] = productos;
            return View("Views/CheckOut/Billing.cshtml");
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
            return View("Views/Login/Error.cshtml");
        }

    }
}