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

using System.Net;
using System.IO;
using System.Text;

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
        public IActionResult PayBill(PedidoVirtual pedido)
        {
            Console.WriteLine(pedido.Tarjeta.NumeroTarjeta);

            if (pedido.Tarjeta.NumeroTarjeta ==  null || pedido.Tarjeta.FechaExpiracion == null || pedido.Tarjeta.CVV == null)
            {
                return View ("Views/Validation/ErrorTarjeta.cshtml");
            }
            RemoteServices rm = new RemoteServices();
            bool validate=rm.serviceValidarTarjeta(pedido.Tarjeta.NumeroTarjeta,pedido.Tarjeta.FechaExpiracion,pedido.Tarjeta.CVV);
        
            //bool validate = IsCreditCardInfoValid(tarjeta.NumeroTarjeta,tarjeta.FechaExpiracion,tarjeta.CVV );
            
            if (validate){

                IProductoService ps = new ProductoService();
                
                foreach (var p in pedido.Productos){
                    Console.WriteLine("Foreach Name"+p.Name);
                    Producto pr = ps.findProductoByName(p.Name);
                    Console.WriteLine("forEach  "+p.Cantidad);
                    if (pr != null)
                        {pr.Cantidad = pr.Cantidad - 1;
                        Producto pp = ps.updateProducto(pr);
                    }

                }
                IPedidoService ps2 = new PedidoService();
                Pedido pd = new Pedido();
                pd.Valor = pedido.Precio;
                pd.Fecha = DateTime.Now;
                ps2.savePedido(pd);


                ITiendaService ts = new TiendaService();
                List<Tienda> tiendas = new List<Tienda>();
                tiendas = ts.findTiendas();
                ViewData["Tiendas"] = tiendas;

                return View ("Views/CheckOut/Tiendas.cshtml",pedido);
            }
            else{
                return View ("Views/Validation/ErrorTarjetaCredito.cshtml");
            }
        }

        

        [Route("Next")] 
        [HttpPost]
        public IActionResult Next(PedidoVirtual pedido)
        {
            
            Console.WriteLine("pedido.TipoEntrega -- "+pedido.TipoEntrega);
            Console.WriteLine("pedido.MetodoPago -- "+pedido.MetodoPago);
            Console.WriteLine("pedido.Costo -- "+pedido.Precio);
            Console.WriteLine("pedido.Productos.Count() -- "+pedido.Productos.Count());
            if(pedido.TipoEntrega == null)
            {
                ViewBag.Message = "Seleccione el tipo de entrega";
                return View ("Views/CheckOut/Billing.cshtml",pedido);
            }
            else if (pedido.MetodoPago == null)
            {
                ViewBag.Message = "Seleccione el metodo de pago";
                ViewData["Pedido"] = pedido;
                return View ("Views/CheckOut/Billing.cshtml",pedido);
            } 
            else
            {
                return View ("Views/CheckOut/Domicilio.cshtml",pedido);   
            }

            /*else if(pedido.TipoEntrega  "Domicilio")
            {
                return View ("Views/CheckOut/Domicilio.cshtml",pedido);   
            }
            else 
            {   
                if (pedido.MetodoPago == "Tarjeta de credito")
                    return View ("Views/CheckOut/Pay.cshtml",pedido);
                else
                {
                    IProductoService ps = new ProductoService();
                
                    foreach (var p in pedido.Productos){
                        Console.WriteLine("Foreach Name"+p.Name);
                        Producto pr = ps.findProductoByName(p.Name);
                        Console.WriteLine("forEach  "+p.Cantidad);
                        if (pr != null)
                            {pr.Cantidad = pr.Cantidad - 1;
                            Producto pp = ps.updateProducto(pr);
                        }

                    }
                    IPedidoService ps2 = new PedidoService();
                    Pedido pd = new Pedido();
                    pd.Valor = pedido.Precio;
                    pd.Fecha = DateTime.Now;
                    ps2.savePedido(pd);
                    return View ("Views/CheckOut/FinalizarPedido.cshtml",pedido);
                }
            } */
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

        [Route("Domicilio")]
        [HttpPost]
        public IActionResult Domicilio(PedidoVirtual pedido)
        {
            Console.WriteLine(pedido.Direccion);
            Console.WriteLine(pedido.Productos[0].ProductoID);
            Console.WriteLine("MetodoPago"+pedido.MetodoPago);
            Console.WriteLine("Precio"+pedido.Precio);
            
            if (pedido.MetodoPago == "Tarjeta de credito")
            {
                return View("Views/CheckOut/Pay.cshtml",pedido);
            }
            else 
            {
                IProductoService ps = new ProductoService();
                
                foreach (var p in pedido.Productos){
                    Console.WriteLine("Foreach Name"+p.Name);
                    Producto pr = ps.findProductoByName(p.Name);
                    Console.WriteLine("forEach  "+p.Cantidad);
                    if (pr != null)
                        {pr.Cantidad = pr.Cantidad - 1;
                        Producto pp = ps.updateProducto(pr);
                    }

                }
                IPedidoService ps2 = new PedidoService();
                Pedido pd = new Pedido();
                pd.Valor = pedido.Precio;
                pd.Fecha = DateTime.Now;
                ps2.savePedido(pd);

                //---------------------------------- TIENDAS ----------------
                ITiendaService ts = new TiendaService();
                List<Tienda> tiendas = new List<Tienda>();
                tiendas = ts.findTiendas();
                ViewData["Tiendas"] = tiendas;


                return View ("Views/CheckOut/Tiendas.cshtml",pedido);
                //return View("Views/CheckOut/FinalizarPedido.cshtml");
            }
        }

        [Route("tiendaSeleccionada")]
        [HttpPost]
        public IActionResult tiendaSeleccionada(PedidoVirtual pedido)
        {

            Console.WriteLine(pedido.Direccion);
            Console.WriteLine(pedido.DireccionTienda);
            RemoteServices rs = new RemoteServices();
            string respuesta = rs.serviceRuta(pedido.Direccion,pedido.DireccionTienda);
            ViewData["distancia"] = respuesta;
            return View ("Views/Validation/PedidoRealizado.cshtml");
        }
    }
}