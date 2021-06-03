using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Spatial;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Entities;
using Services.Implementation;
using Services.Contracts;
using EjemploASP.Modelo;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Text.RegularExpressions;


using GoogleApi.Entities.Common;
using GoogleApi.Entities.Maps.Directions.Request;
using GoogleApi.Entities.Maps.Directions.Response;

//using GoogleSigned;

namespace EjemploASP.Controllers
{
    [Route("loginController")]
    public class LoginController : Controller
    {
        public Usuario usuario{get; set;}

        public LoginController(){
            usuario = new Usuario();
        }


        [Route("Registrarse")]
        public IActionResult Registrarse()
        {
            return View ("Views/Login/Register.cshtml");
        }

        [Route("Register")]
        [HttpPost]
        public IActionResult Register(Usuario usuario)
        {
             if (usuario.Email != null && usuario.Password != null && usuario.Name != null)
            {
                Console.WriteLine("Email" + usuario.Email);
                Console.WriteLine("Password" + usuario.Password);

                IUsuarioService userService = new UsuarioService();
                userService.register(usuario);
                return View ("Views/Home/Index.cshtml");
            }
            return View ("Views");
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            if (usuario.Email != null && usuario.Password != null)
            {
                Console.WriteLine("Email" + usuario.Email);
                Console.WriteLine("Password" + usuario.Password);

                IUsuarioService userService = new UsuarioService();
                bool loginBool = userService.validarUsuario(usuario.Email,usuario.Password);
                if (loginBool)
                {
                    //RemoteServices rm=new RemoteServices();
                    //rm.service1();
                    IProductoService productoService = new ProductoService();
                    List<Producto> listaProductos = new List<Producto>();
                    //CREA LOS PRODUCTOS EN LA BASE DE DATOS
                    //InitializeProducts(productoService);

// --------------------------------------------------------------------------------------------
                    //string url = @"https://maps.googleapis.com/maps/api/directions/json?origin=75+9th+Ave+New+York,+NY&destination=MetLife+Stadium+1+MetLife+Stadium+Dr+East+Rutherford,+NJ+07073&key=AIzaSyCPgGBVtdIdcO6tbwimh0fWnT6A3AgFtJ4";
                    var url = "https://maps.googleapis.com/maps/api/distancematrix/json?origins=75+9th+Ave+New+York,+NY&destinations=MetLife+Stadium+1+MetLife+Stadium+Dr+East+Rutherford,+NJ+07073&sensor=false&key=AIzaSyCPgGBVtdIdcO6tbwimh0fWnT6A3AgFtJ4";
                    WebRequest request = WebRequest.Create(url);

                    WebResponse response = request.GetResponse();

                    Stream data = response.GetResponseStream();

                    StreamReader reader = new StreamReader(data);

                    // json-formatted string from maps api
                    string responseFromServer = reader.ReadToEnd();

                    Console.WriteLine(responseFromServer);

                    RequestCepViewModel viewModel = JsonConvert.DeserializeObject<RequestCepViewModel>(responseFromServer);

                    Console.WriteLine("ViewModel: -- "+viewModel.rows[0].elements[0].distance.text);

                    response.Close();
// --------------------------------------------------------------------------------------------
                    ITiendaService ts = new TiendaService();
                    List<Tienda> tiendas = new List<Tienda>();
                    tiendas = ts.findTiendas();
                    Console.WriteLine("SIZE TIENDAS: "+tiendas.Count());
                    Console.WriteLine("");

//---------------------------------------------------------------------------------------------
                    listaProductos = productoService.findProductos();
                    List<Producto> cart = new List<Producto>();
                    ViewData["Cart"] = cart;
                    ViewData["Costo"] = 0;
                    
                    return View("Views/Productos/Productos.cshtml",listaProductos);
                }
            }
//-----------------------------------------------------------------------------------------------
            /*Pedido p = new Pedido();
            p.ID = 2;
            p.Precio = 3000;
            p.MetodoPago = "Efectivo";
            Producto pr1 = new Producto();
            Producto pr2 = new Producto();
            ICollection<Producto> prs = new List<Producto>();

            
            pr1.Name = "Basura";
            pr2.Name = "Mojarra";
            prs.Add(pr1);
            prs.Add(pr2);
            p.Productos = prs;

// -----------------------------------------------------------------------------------------------
            Producto producto1 = new Producto();
            producto1.Name = " Aguacate";
            producto1.Precio = 23000;
            producto1.ID = 1;
            Producto producto2 = new Producto();
            producto2.ID = 3;
            producto2.Name = " Patos";
            producto2.Precio = 4000;

            List<Producto> listaProductos = new List<Producto>();
            listaProductos.Add(producto1);
            listaProductos.Add(producto2);
            */
            //return View("Views/Productos/Productos.cshtml",listaProductos);
            
            return View("Error");
        }

        public void InitializeProducts(IProductoService productoService)
        {
            //productoService.dropTable();

            Producto pr1=new Producto();
            pr1.ProductoID = 1;
            pr1.Name="Sandwich Cubano";
            pr1.Precio=12000;
            pr1.Cantidad = 3;
            Producto pr2=new Producto();
            pr2.ProductoID = 2;
            pr2.Name="Sandwich Paisa";
            pr2.Precio=24000;
            pr1.Cantidad = 2;
            Producto pr3=new Producto();
            pr3.ProductoID = 3;
            pr3.Name="Sandwich de lentejas";
            pr3.Precio=22000;
            pr3.Cantidad = 5;
            Producto pr4=new Producto();
            pr4.ProductoID = 4;
            pr4.Name="Sandwich pesto";
            pr4.Precio=15000;
            pr4.Cantidad = 1;

            productoService.saveProducto(pr1);
            productoService.saveProducto(pr2);
            productoService.saveProducto(pr3);
            productoService.saveProducto(pr4);
        } 

    
    }
}