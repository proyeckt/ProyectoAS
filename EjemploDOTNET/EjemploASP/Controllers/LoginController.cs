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
    [Route("loginController")]
    public class LoginController : Controller
    {
        public Usuario usuario{get; set;}

        public LoginController(){
            usuario = new Usuario();
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
                    return View("Bienvenido");
                }
            }
//-----------------------------------------------------------------------------------------------
            Pedido p = new Pedido();
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

            return View("Views/Productos/Productos.cshtml",listaProductos);

            
            //return View("Error");
        }

    
    }
}