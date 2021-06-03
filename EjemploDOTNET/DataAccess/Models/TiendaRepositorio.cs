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
    public class TiendaRepositorio{
        
        public List<Tienda> findTiendas(){
            using (var context = new UsuarioContext())
            {
                var tiendas = context.Tiendas;
                
                List<Tienda> lista= new List<Tienda>();
                //IQueryable<Tienda> rtn = from temp  in tiendas select temp;
                Console.WriteLine("Tiends: "+tiendas.Count());
                //for(int i =)
                lista=tiendas.ToList<Tienda>();
                Console.WriteLine("List: "+lista.Count());
                //var list = rtn.ToList();
                return lista;
            }
        }
    }   
}