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
            usuario.ID = 2;
            usuario.Password = "abc";
            usuario.Name = "David";
            return View("Error",usuario);

            
            //return View("Error");
        }

    
    }
}