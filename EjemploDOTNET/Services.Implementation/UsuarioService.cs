using System;
using Models;
using Entities;
using Services.Contracts;

namespace Services.Implementation
{
    public class UsuarioService : IUsuarioService
    {
        public bool register(Usuario usuario){
            UsuarioRepositorio dataAccess=new UsuarioRepositorio();
            bool added=dataAccess.addUsuario(usuario);
            //bool added=true;
            return added;
        }

        public bool validarUsuario(string email, string password){
            UsuarioRepositorio dataAccess=new UsuarioRepositorio();
            bool valido=dataAccess.findUsuario(email,password);
            //bool valido=true;
            if(valido){
                Console.WriteLine("Valido");
            }
            else Console.WriteLine("No Valido");
            return valido;
        }

    }
}
