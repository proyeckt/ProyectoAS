using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
namespace Services.Contracts
{
    public interface IInventarioService
    {
        public Inventario findInventario(int id);
        public bool saveInventario(Inventario Inventario);
        public List<Inventario> findInventarios();

    }
}
