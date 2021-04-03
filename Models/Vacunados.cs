using System;
using System.ComponentModel.DataAnnotations;

namespace Tarea9.Models{
    public class Vacunados{
        [Key]
        public int id {get; set;}
        public string cedula {get; set;}
        public string nombre {get; set;}
        public string apellido {get; set;}
        public string telefono {get; set;}
        public string email {get; set;}
        public int tipo_sangre {get; set;}
        public int provincia {get; set;}
        public string direccion {get; set;}
        public string latitud {get; set;}
        public string longitud {get; set;}
        public bool covid {get; set;}
        public string justificacion {get; set;}
    }
}