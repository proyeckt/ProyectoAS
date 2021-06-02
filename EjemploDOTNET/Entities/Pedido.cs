using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Pedido
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PedidoID { get; set; }
        //public Usuario Cliente { get; set; }
        public string MetodoPago { get; set; }
        //public ICollection<Producto> Productos { get; set; }
        public double Precio { get; set; }
        

        //public DateTime EnrollmentDate { get; set; }

        
    }
}
