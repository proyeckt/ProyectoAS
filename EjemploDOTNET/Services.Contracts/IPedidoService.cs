using System;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Services.Contracts
{
    public interface IPedidoService
    {
        public Pedido findPedido(int id);
        public bool savePedido(Pedido pedido);
        public List<Pedido> findPedidos();
    }
}
