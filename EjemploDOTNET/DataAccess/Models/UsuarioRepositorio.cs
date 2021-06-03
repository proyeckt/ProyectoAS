using System;

using Microsoft.EntityFrameworkCore;
using System.Text;

using Data;
using System.Linq;
using System.Collections.Generic;
using Entities;

namespace Models
{
    public class UsuarioRepositorio{

        public bool addUsuario(Usuario usuario){
            using (var context = new UsuarioContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                // Adds some users
                /*context.Usuarios.Add(new User
                {
                    ID = 1,
                    Email = "edwin@mail",
                    Password = "edwinmail",
                    Name = "Edwin"
                });*/
                var users = context.Usuarios;
                var lista = users.ToList<Usuario>();
                usuario.ID = lista.Count() + 1;
                //usuario.ID = context.Usuarios.ToList<Producto>().Count() + 1;
                context.Usuarios.Add(usuario);

                // Saves changes
                context.SaveChanges();
                return true;
            }
        }

        public bool findUsuario(string email,string password){
            // Gets and prints all users in database
            using (var context = new UsuarioContext())
            {
                var users = context.Usuarios;
                foreach (var user in users)
                {
                    var data = new StringBuilder();
                    data.AppendLine($"ID: {user.ID}");
                    data.AppendLine($"Name: {user.Name}");
                    data.AppendLine($"Email: {user.Email}");
                    data.AppendLine($"Password: {user.Password}");
                    Console.WriteLine(data.ToString());
                    if(email.Equals(user.Email) && password.Equals(user.Password)){
                        Console.WriteLine("True");
                        return true;
                    }
                    //if(string.Compare(email,user.Email)==0 && string.Compare(password,user.Password)==0)
                    
                }
                Console.WriteLine("False");
                return false;
            }
        }
    }   
}