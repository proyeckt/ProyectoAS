using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Tienda
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TiendaID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        
        //public DateTime EnrollmentDate { get; set; }

        //public ICollection<Enrollment> Enrollments { get; set; }
    }
}
