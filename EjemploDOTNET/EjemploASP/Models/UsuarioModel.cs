using System;

//using Microsoft.AspNetCore.Mvc.ModelBinding;
//using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace EjemploASP.Models
{
    public class UsuarioModel
    {
        [Required(ErrorMessage = "Nombre de usuario es requerido")]
        [StringLength(12, ErrorMessage = "Logitud máxima 12")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Clave es requerida")]
        [StringLength(10, ErrorMessage = "Logitud máxima 10")]
        public string Password { get; set; }

    }
}