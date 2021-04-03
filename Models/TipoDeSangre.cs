using System.ComponentModel.DataAnnotations;

namespace Tarea9.Models{
    public class tipoDeSangre{

        [Key]
        public int id {get; set;}

        public string SangreTipo {get; set;}

    }
}