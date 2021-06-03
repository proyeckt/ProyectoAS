using System;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Services.Contracts
{
    public interface ITiendaService
    {
        public List<Tienda> findTiendas();
    }
}
