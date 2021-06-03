using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
//using System.Data.Entity.DbContext;

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

        public Producto updateProducto(Producto producto){
            using (var context = new UsuarioContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();
                Console.WriteLine("Repository "+producto.Cantidad);
                //context.Productos.AddOrUpdate(producto);

                var p = context.Productos.First(prod => prod.ProductoID == producto.ProductoID);
                p.Cantidad = producto.Cantidad;
                
                context.SaveChanges();
                return producto;
            }
            return null;
        }

        public Producto findProducto(int id){
            using (var context = new UsuarioContext())
            {
                var products = context.Productos;
                foreach (var prod in products.ToList())
                {
                    Console.WriteLine(id);
                    Console.WriteLine(prod.ProductoID);
                    if(id.Equals(prod.ProductoID)){
                        Console.WriteLine("True findProducto");
                        return prod;
                    }
                    //if(string.Compare(email,user.Email)==0 && string.Compare(password,user.Password)==0)
                    
                }
                Console.WriteLine("False findProducto");
                return null;
            }
        }

        public Producto findProductoByName(string id){
            using (var context = new UsuarioContext())
            {
                var products = context.Productos;
                foreach (var prod in products.ToList())
                {
                    Console.WriteLine(id);
                    Console.WriteLine(prod.Name);
                    if(id.Equals(prod.Name)){
                        Console.WriteLine("True findProducto");
                        return prod;
                    }
                    //if(string.Compare(email,user.Email)==0 && string.Compare(password,user.Password)==0)
                    
                }
                Console.WriteLine("False findProducto");
                return null;
            }
        }

        public List<Producto> findProductos(){
            using (var context = new UsuarioContext())
            {
                var products = context.Productos;
                
                List<Producto> lista= new List<Producto>();
                //IQueryable<Producto> rtn = from temp  in products select temp;
                Console.WriteLine("Prods:"+products.Count());
                //for(int i =)
                lista=products.ToList<Producto>();
                Console.WriteLine("List:"+lista.Count());
                //var list = rtn.ToList();
                return lista;
            }
        }

        public void dropTable(){
            using (var context = new UsuarioContext())
            {
               /*  var all = from c in context.Productos select c;
                context.Productos.RemoveRange(all);
                context.SaveChanges(); */
                
                //context.ExecuteStoreCommand("TRUNCATE TABLE [Productos]");
            }
        }
    }   
}