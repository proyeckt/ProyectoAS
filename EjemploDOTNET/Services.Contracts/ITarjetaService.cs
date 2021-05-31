using System;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Services.Contracts
{
    public interface ITarjetaService
    {
        public Tarjeta findTarjeta(int id);
        public bool saveTarjeta(Tarjeta tarjeta);
        public List<Tarjeta> findTarjetas();
    }
}
