using System;
using Models;
using Entities;
using Services.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Services.Implementation
{
    public class InventarioService : IInventarioService
    {
        public bool saveInventario(Inventario Inventario){
            InventarioRepositorio dataAccess=new InventarioRepositorio();
            bool added=dataAccess.addInventario(Inventario);
            return added;
        }

        public Inventario findInventario(int id){
            InventarioRepositorio dataAccess=new InventarioRepositorio();
            Inventario valido=dataAccess.findInventario(id);
            
            if(valido!=null){
                Console.WriteLine("Valido");
            }
            else Console.WriteLine("No Valido");
            return valido;
        }

        public List<Inventario> findInventarios(){
            InventarioRepositorio dataAccess=new InventarioRepositorio();
            List<Inventario> Inventarios=dataAccess.findInventarios();
            
            return Inventarios;
        }

    }
}
