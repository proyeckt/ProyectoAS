using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Tarjeta
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        public string NumeroTarjeta { get; set; }
        public string FechaExpiracion { get; set; }

        public string CVV { get; set; }

        //public ICollection<Enrollment> Enrollments { get; set; }
    }
}
