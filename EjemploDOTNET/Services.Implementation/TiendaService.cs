using System;
using Models;
using Entities;
using Services.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Services.Implementation
{
    public class TiendaService : ITiendaService 
    {
        public List<Tienda> findTiendas(){
            TiendaRepositorio dataAccess=new TiendaRepositorio();
            List<Tienda> tiendas=dataAccess.findTiendas();
            
            return tiendas;
        }

    }
}
