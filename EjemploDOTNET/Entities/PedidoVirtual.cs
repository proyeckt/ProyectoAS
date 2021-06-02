using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class PedidoVirtual
    {
        public int PedidoID { get; set; }
        //public Usuario Cliente { get; set; }
        public string MetodoPago { get; set; }
        public ICollection<Producto> Productos { get; set; }
        public double Precio { get; set; }
        public string TipoEntrega { get; set; }
        

        //public DateTime EnrollmentDate { get; set; }

        
    }
}
