using Microsoft.EntityFrameworkCore;

namespace EvaluacionN4Valentina.Models
{
    public class EFContext : DbContext
    {
        // 1. Crear atributo que almacene la cadena de conexión a la BD
        private const string ConnectionString = "server=localhost;port=3306;database=pelicula_db;user=root;password=root;Connect Timeout=5;";

        // ToDo: Para revisar con calma, la inclusión y/o modificaciones que se deban hacer
        // para configurar la instancia inicial de MySQL en conexión al proyecto
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString,
                new MySqlServerVersion(new Version(8, 0, 11)));
        }

        // 2. Definir qué clases son modelos desde la base de datos
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }

        // 3. Configurar los modelos 
        // ToDo: Establecer las relaciones y restricciones de la tabla
        // * Definir clave primaria * Establecer las relaciones
        // * Definir cuáles son obligatorios
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definir claves primarias
            modelBuilder.Entity<Pelicula>().HasKey(i => i.Id);
            modelBuilder.Entity<Genero>().HasKey(j => j.Id);

            // Definir relaciones uno a muchos: Canción a Álbum
            modelBuilder.Entity<Pelicula>()
                .HasOne<Genero>(s => s.Genero)
                .WithMany(g => g.Peliculas)
                .HasForeignKey(c => c.GeneroId);

            // Definimos los obligatorios (not null - mandatory) 
            modelBuilder.Entity<Pelicula>().Property(s => s.GeneroId).IsRequired();
            modelBuilder.Entity<Pelicula>().Property(s => s.Titulo).IsRequired();
            modelBuilder.Entity<Pelicula>().Property(s => s.Tiempo).IsRequired();

            modelBuilder.Entity<Genero>().Property(s => s.Titulo).IsRequired();
            modelBuilder.Entity<Genero>().Property(s => s.Creacion)
                .HasDefaultValue(DateTime.Now) // Indicar un valor por defecto
                .IsRequired();
            modelBuilder.Entity<Genero>().Property(s => s.Descripcion).IsRequired();
        }

    }
}
