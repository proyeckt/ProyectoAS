using System;
using Models;
using Entities;
using Services.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Services.Implementation
{
    public class ProductoService : IProductoService
    {
        public bool saveProducto(Producto producto){
            ProductoRepositorio dataAccess=new ProductoRepositorio();
            bool added=dataAccess.addProducto(producto);
            return added;
        }

        public Producto findProducto(int id){
            ProductoRepositorio dataAccess=new ProductoRepositorio();
            Producto valido=dataAccess.findProducto(id);
            
            if(valido!=null){
                Console.WriteLine("Valido");
            }
            else Console.WriteLine("No Valido");
            return valido;
        }

        public List<Producto> findProductos(){
            ProductoRepositorio dataAccess=new ProductoRepositorio();
            List<Producto> productos=dataAccess.findProductos();
            
            return productos;
        }

        public void dropTable(){
            ProductoRepositorio dataAccess=new ProductoRepositorio();
            dataAccess.dropTable();
        }

    }
}
