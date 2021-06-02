using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Producto
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoID { get; set; }
        public string Name { get; set; }
        public ICollection<Item> Items { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        //public DateTime EnrollmentDate { get; set; }

        //public ICollection<Enrollment> Enrollments { get; set; }
    }
}
