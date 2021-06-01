using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

using Data;


using Entities;

namespace Models
{
    public class InventarioRepositorio{
        public bool addInventario(Inventario inventario){
            using (var context = new UsuarioContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();
                context.Inventarios.Add(inventario);

                // Saves changes
                context.SaveChanges();
                return true;
            }
        }

        public Inventario findInventario(int id){
            using (var context = new UsuarioContext())
            {
                var inventarios = context.Inventarios;
                foreach (var inv in inventarios)
                {
                    if(id.Equals(inv.ID)){
                        Console.WriteLine("True");
                        return inv;
                    }
                    //if(string.Compare(email,user.Email)==0 && string.Compare(password,user.Password)==0)
                    
                }
                Console.WriteLine("False");
                return null;
            }
        }

        public List<Inventario> findInventarios(){
            using (var context = new UsuarioContext())
            {
                var inventarios = context.Inventarios;
                return inventarios.ToList();
            }
        }
    }   
}