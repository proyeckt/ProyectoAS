using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

using Data;


using Entities;

namespace Models
{
    public class ProductoRepositorio{
        public bool addProducto(Producto producto){
            using (var context = new UsuarioContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();
                context.Productos.Add(producto);

                // Saves changes
                context.SaveChanges();
                return true;
            }
        }

        public Producto findProducto(int id){
            using (var context = new UsuarioContext())
            {
                var products = context.Productos;
                foreach (var prod in products)
                {
                    if(id.Equals(prod.ID)){
                        Console.WriteLine("True");
                        return prod;
                    }
                    //if(string.Compare(email,user.Email)==0 && string.Compare(password,user.Password)==0)
                    
                }
                Console.WriteLine("False");
                return null;
            }
        }

        public List<Producto> findProductos(){
            using (var context = new UsuarioContext())
            {
                var products = context.Productos;
                return products.ToList();
            }
        }
    }   
}