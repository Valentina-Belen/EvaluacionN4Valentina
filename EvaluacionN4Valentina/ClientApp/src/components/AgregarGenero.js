import React, { useEffect, useState } from 'react'

const AgregarGenero = () => {
    const fechaActual = new Date()

    // Estados para campos de formulario
    const [titulo, setTitulo] = useState("")
    const [fechaCreacion, setFechaCreacion] = useState(fechaActual.toLocaleDateString('en-CA')) // La fecha debe estar formateada en YYYY-MM-DD
    const [topSeller, setTopSeller] = useState(false)
    const [Descripcion, setDescripcion] = useState("")

    // Estados para uso en lógica
    const [alertaValidacion, setAlertaValidacion] = useState(false)

    // Método para enviar solicitud POST al backend con los datos
    const registrarGenero = async (datos) => {
        await fetch('/generos/nuevo', {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(datos) // conversión a datos
        })
            .then(response => {
                // response.json() // aquí se obtiene la respuesta
                alert("Género ingresado correctamente")
            })
            .catch(error => {
                console.log("error")
                alert("Ocurrió un error, por favor revise los datos")
            })
    }

    /*
     * Función para manejar evento click al agregar álbum
    */
    const handleAgregarGenero = async (evento) => {
        setAlertaValidacion(false)

        if (titulo === "" || Descripcion === "") {
            setAlertaValidacion(true)
        } else {
            // crear objeto json para enviar datos
            const datos = {
                titulo: titulo, // puede acotarse como titulo,
                Creacion: fechaCreacion,
                Descripcion: Descripcion,
                topSeller: topSeller
            }

            await registrarGenero(datos) // se espera la respuesta
        }
    }

    // Salida JSX
    return (
        <>
            <div className="row">
                <div className="col-12 mb-3"><h1>Agregar género</h1></div>

                {/* Control: Título género */}
                <div className="col-4">
                    <div className="mb-3">
                        <label htmlFor="titulo" className="form-label">Título del género</label>
                        <input type="text"
                            className="form-control"
                            id="titulo"
                            placeholder="P.ej: Fantasía"
                            value={titulo}
                            onChange={(evento) => setTitulo(evento.target.value)}
                        />
                    </div>
                </div>

                {/* Control: Fecha Creacion */}
                <div className="col-4">
                    <div className="mb-3">
                        <label htmlFor="Creacion" className="form-label">Fecha creación</label>
                        <input type="date"
                            className="form-control"
                            id="Creacion"
                            placeholder="P.ej: 11-03-1995"
                            value={fechaCreacion}
                            onChange={(evento) => setFechaCreacion(evento.target.value)}
                        />
                    </div>
                </div>

                {/* Control: Nombre de Descripcion */}
                <div className="col-4">
                    <div className="mb-3">
                        <label htmlFor="nombre_Descripcion" className="form-label">Descripción</label>
                        <input type="text"
                            className="form-control"
                            id="nombre_Descripcion"
                            placeholder="P.ej: En el cine y la televisión..."
                            value={Descripcion}
                            onChange={(evento) => setDescripcion(evento.target.value)}
                        />
                    </div>
                </div>

                {/* Control: ¿Es top seller? */}
                <div className="col-12">
                    <div className="form-check">
                        <input type="checkbox"
                            className="form-check-input"
                            value={topSeller}
                            onChange={() => setTopSeller(!topSeller)}
                            id="top_seller"
                        />
                        <label className="form-check-label" htmlFor="top_seller">
                            Es top seller
                        </label>
                    </div>
                </div>

                {/* Control: Botón */}
                <div className="col-12 justify-content-start mt-4">
                    <button type="button"
                        className="btn btn-primary"
                        onClick={handleAgregarGenero}
                    >
                        Guardar nuevo género
                    </button>
                </div>

                {/* Línea horizontal separadora */}
                <hr className="my-4" />

                {/* Alerta mostrada sólo si alertaValidacion === true */}
                {alertaValidacion &&
                    <div className="alert alert-warning d-flex align-items-center" role="alert">
                        <div>
                            ⚠ Algunos campos no pasaron la validación. Por favor revise que estén correctamente ingresados.
                        </div>
                    </div>
                }

            </div>
        </>
    )
}

export default AgregarGenero