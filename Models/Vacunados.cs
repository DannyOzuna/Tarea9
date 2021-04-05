using System;
using System.ComponentModel.DataAnnotations;

namespace Tarea9.Models{
    public class Vacunados{
        [Key]
        public int id {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        [MaxLength(length:11)]
        public string cedula {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string nombre {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string apellido {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string telefono {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string email {get; set;}
        [Required]
        public int tipo_sangre {get; set;}
        [Required]
        public int provincia {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string direccion {get; set;}
        public string latitud {get; set;}
        public string longitud {get; set;}
        public int covid {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string justificacion {get; set;}
    }
}