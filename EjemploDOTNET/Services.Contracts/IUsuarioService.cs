using System;
using Entities;

namespace Services.Contracts
{
    public interface IUsuarioService
    {
        public bool validarUsuario(string email, string password);
        public bool register(Usuario usuario);
    }
}
