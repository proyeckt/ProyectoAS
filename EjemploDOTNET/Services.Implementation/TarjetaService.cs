using System;
using Models;
using Entities;
using Services.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Services.Implementation
{
    public class TarjetaService : ITarjetaService
    {
        public bool saveTarjeta(Tarjeta tarjeta){
            TarjetaRepositorio dataAccess=new TarjetaRepositorio();
            bool added=dataAccess.addTarjeta(tarjeta);
            return added;
        }

        public Tarjeta findTarjeta(int id){
            TarjetaRepositorio dataAccess=new TarjetaRepositorio();
            Tarjeta valido=dataAccess.findTarjeta(id);
            
            if(valido!=null){
                Console.WriteLine("Valido");
            }
            else Console.WriteLine("No Valido");
            return valido;
        }

        public List<Tarjeta> findTarjetas(){
            TarjetaRepositorio dataAccess=new TarjetaRepositorio();
            List<Tarjeta> tarjetas=dataAccess.findTarjetas();
            
            return tarjetas;
        }

    }
}
