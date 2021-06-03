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
        public double  Valor { get; set; }
        //public ICollection<Producto> Productos { get; set; }
        public DateTime Fecha { get; set; }
        //public bool TipoEntrega { get; set; }
        //public string DireccionTienda  { get; set; }
        //public DateTime EnrollmentDate { get; set; }

        
    }
}
