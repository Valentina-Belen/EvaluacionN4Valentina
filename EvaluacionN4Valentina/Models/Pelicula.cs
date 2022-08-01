using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluacionN4Valentina.Models
{
    [Table("Pelicula")] // Indicar la tabla al que pertenecerá la clase Pelicula
    public class Pelicula
    {
        public int Id { get; set; }
        public int GeneroId { get; set; }
        public string Titulo { get; set; }
        public int Tiempo { get; set; }

        // Relaciones
        public virtual Genero Genero { get; set; }
    }
}
