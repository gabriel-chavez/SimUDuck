# Bitacora
## Estructura actual.
Se puede observar que la aplicación no es extendible, por lo que al añadir un metodo mas a la clase principal puede causar efectos secundarios en la simulación.
## Nuevo requerimiento.
Simplemente agregando un método Fly da la funcionalidad a las subclases, y se toma la decisión de anular o sobreescribir el metodo a las clases que no le corresponden, en esta parte se puede observar un mal olor en el codigo, teniendo metodos que no son útiles para algunos objetos.
Se puede observar que la herencia no es la mejor solucion para este caso ya que sera necesario anular algunos metodos.
## Usando Interfaces.
Si decidimos cambiar el comportamiendo de vuelo del pato, estamos obligados a cambiar en las subclases que tengan implementada la interfas IFlyable
El mantenimento podria ser necesario en todas las clases que implementen las interfaces donde necesitamos realizar modificaciones.
## Separamos aspectos de la aplicacion que varian
Con este nuevo diseño se puede mantener la aplicacion flexible, cambiar el comportamiento del pato dinamicamente y ademas con este enfoque podemos adaptarnos a cambios futuros.