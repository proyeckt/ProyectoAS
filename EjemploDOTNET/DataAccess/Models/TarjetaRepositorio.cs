using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

using Data;


using Entities;

namespace Models
{
    public class TarjetaRepositorio{
        public bool addTarjeta(Tarjeta tarjeta){
            using (var context = new UsuarioContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();
                context.Tarjetas.Add(tarjeta);

                // Saves changes
                context.SaveChanges();
                return true;
            }
        }

        public Tarjeta findTarjeta(int id){
            using (var context = new UsuarioContext())
            {
                var tarjetas = context.Tarjetas;
                foreach (var tarj in tarjetas)
                {
                    if(id.Equals(tarj.ID)){
                        Console.WriteLine("True");
                        return tarj;
                    }
                    //if(string.Compare(email,user.Email)==0 && string.Compare(password,user.Password)==0)
                    
                }
                Console.WriteLine("False");
                return null;
            }
        }

        public List<Tarjeta> findTarjetas(){
            using (var context = new UsuarioContext())
            {
                var tarjetas = context.Tarjetas;
                return tarjetas.ToList();
            }
        }
    }   
}