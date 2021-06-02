using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

using Data;


using Entities;

namespace Models
{
    public class PedidoRepositorio{
        public bool addPedido(Pedido pedido){
            using (var context = new UsuarioContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();
                context.Pedidos.Add(pedido);

                // Saves changes
                context.SaveChanges();
                return true;
            }
        }

        public Pedido findPedido(int id){
            using (var context = new UsuarioContext())
            {
                var pedidos = context.Pedidos;
                foreach (var ped in pedidos)
                {
                    if(id.Equals(ped.PedidoID)){
                        Console.WriteLine("True");
                        return ped;
                    }
                    //if(string.Compare(email,user.Email)==0 && string.Compare(password,user.Password)==0)
                    
                }
                Console.WriteLine("False");
                return null;
            }
        }

        public List<Pedido> findPedidos(){
            using (var context = new UsuarioContext())
            {
                var pedidos = context.Pedidos;
                return pedidos.ToList();
            }
        }
    }   
}