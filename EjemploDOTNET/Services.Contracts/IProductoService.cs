﻿using System;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Services.Contracts
{
    public interface IProductoService
    {
        public Producto findProducto(int id);
        public Producto findProductoByName(string id);
        public bool saveProducto(Producto producto);
        public List<Producto> findProductos();
        public void dropTable();
        public Producto updateProducto(Producto producto);
    }
}
