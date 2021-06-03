using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Entities
{
    public class PedidoVirtual
    {
        public int PedidoID { get; set; }
        //public Usuario Cliente { get; set; }
        public string MetodoPago { get; set; }
        public double Precio { get; set; }
        public string TipoEntrega { get; set; }
        public string Direccion { get; set; }
        public List<Producto> Productos { get; set; }
        public Tarjeta Tarjeta { get; set; }
        

        //public DateTime EnrollmentDate { get; set; }
        
    }   
        
}
    
