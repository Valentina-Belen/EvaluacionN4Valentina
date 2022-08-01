using EvaluacionN4Valentina.Models;

Console.WriteLine("Demostraciones de LinQ: ");

using (EFContext bd = new EFContext())
{
    //1. Ordenar los generos de manera descendiente
    //SELECT * FROM genero WHERE Id >= 1 AND Id <= 3 ORDER BY Id DESC;
    /* var generosOrdenados = bd.Generos
        .Where(x.Id >= 1 && x.Id <= 3)
        .OrderByDescending(x => x.Id)
        .ToList(); */

    //2. Obtener el promedio del tiempo de cada película
    //SELECT AVG(Tiempo) FROM pelicula;
    /* double promedioTiempo = db.Peliculas.Average(x => x.Tiempo); */

    //3. Mostrar registro desde un rango de fecha de la columna date/datetime
    //SELECT * FROM `genero` WHERE `creacion` BETWEEN '1982-07-22' AND '1997-02-10';

    //4. Insertar registro
    //INSERT INTO `genero` (`Id`, `Titulo`, `Creacion`, `TopSeller`, `Descripcion`) VALUES
    //(4, 'Accion', '2022-07-31 12:46:46', 1, 'El llamado cine de acción es un género
    //cinematográfico donde prima la espectacularidad de las imágenes por medio de efectos
    //especiales de estilo "clásico".');
    /* Genero nuevoGenero = new Genero()
       {
            Id = 4,
            Titulo = "Accion",
            Creacion = Convert.ToDateTime("2022-07-31"),
            TopSeller = 1,
            Descripcion = "El llamado cine de acción es un género
            cinematográfico donde prima la espectacularidad de las imágenes por medio de efectos
            especiales de estilo "clásico"."
       };
        
       bd.Generos.Add(nuevoGenero);
       bd.SaveChanges(); */

    //5. Actualizar título de un género de "Accion" a "Drama"
    //UPDATE genero SET titulo = `Drama` WHERE Id = 4;
    /* var generoEditar = bd.Generos.FirstOrDefault(x => x.Id == 4);
       generoEditar.Titulo = "Drama";
       bd.Generos.Update(generoEditar);
       bd.SaveChanges();
     */

    //6. Actualizar la descripcion de "Accion" a "Drama"
    //UPDATE genero SET descripcion = `El drama es un género que trata situaciones
    //generalmente no épicas en un contexto serio, con un tono y una orientación
    //más susceptible de inspirar tristeza y compasión.` WHERE Id = 4;
    /* var generoEditar = bd.Generos.FirstOrDefault(x => x.Id == 4);
       generoEditar.Titulo = "El drama es un género que trata situaciones
    //generalmente no épicas en un contexto serio, con un tono y una orientación
    //más susceptible de inspirar tristeza y compasión.";
       bd.Generos.Update(generoEditar);
       bd.SaveChanges();
     */

    //7. Eliminar un dato de pelicula "Ella" Id = 30;
    //DELETE FROM `pelicula` WHERE Id=30;
    /* var peliculaEliminar = bd.Peliculas.FirstOrDefault(x => x.Id == 30);
       bd.Peliculas.Remove(peliculaEliminar);
       bd.SaveChanges();
     */
}
