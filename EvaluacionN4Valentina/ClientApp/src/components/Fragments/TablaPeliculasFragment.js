import React, { useState, useEffect } from 'react'

const TablaPeliculasFragment = ({ peliculas }) => {

    return (
        <>
            <table className="table table-stripped">
                <thead>
                    <tr>
                        <th>Título de la pélicula</th>
                        <th>Duración</th>
                        <th>Género</th>
                    </tr>
                </thead>
                <tbody>
                    {/* Iteración entre albumes, renderizando filas de la tabla */}
                    {peliculas.map((pelicula, indice) => (
                        <tr key={indice}>
                            <td>{pelicula.Titulo}</td>
                            <td>{pelicula.Tiempo} minuto(s)</td>
                            <td>{pelicula.Genero.Titulo}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </>
    )
}

export default TablaPeliculasFragment