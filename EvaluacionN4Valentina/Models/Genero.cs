using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluacionN4Valentina.Models
{
    [Table("Genero")] // Indicar la tabla al que pertenecerá la clase Genero
    public class Genero
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Creacion { get; set; }
        public bool? TopSeller { get; set; }
        public string Descripcion { get; set; }

        // Relaciones
        public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}
