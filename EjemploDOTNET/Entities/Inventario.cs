using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Inventario
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public Item Item { get; set; }
        public int Cantidad { get; set; }
        //public DateTime EnrollmentDate { get; set; }

        //public ICollection<Enrollment> Enrollments { get; set; }
    }
}
