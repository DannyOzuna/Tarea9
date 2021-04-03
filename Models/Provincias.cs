using System.ComponentModel.DataAnnotations;

namespace Tarea9.Models{
    public class Provincias{
        [Key]
        public int ProvinciaID {get; set;}
        public string nombre {get; set;}
    }
}