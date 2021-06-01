using System;
using Models;
using Entities;
using Services.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Services.Implementation
{
    public class PedidoService : IPedidoService
    {
        public bool savePedido(Pedido pedido){
            PedidoRepositorio dataAccess=new PedidoRepositorio();
            bool added=dataAccess.addPedido(pedido);
            return added;
        }

        public Pedido findPedido(int id){
            PedidoRepositorio dataAccess=new PedidoRepositorio();
            Pedido valido=dataAccess.findPedido(id);
            
            if(valido!=null){
                Console.WriteLine("Valido");
            }
            else Console.WriteLine("No Valido");
            return valido;
        }

        public List<Pedido> findPedidos(){
            PedidoRepositorio dataAccess=new PedidoRepositorio();
            List<Pedido> pedidos=dataAccess.findPedidos();
            
            return pedidos;
        }

    }
}
