# SimUDuck
## SimUDuckSolucion1:
Aplicacion de simulacion de patos existente, muestra el pato, emite un sonido y nada.
Ahora se tiene un nuevo requerimiento: los patos necesitan volar para esto se crea la solucion 2
## SimUDuckSolucion2:
Agregando un metodo Fly en la clase Duck le da la posibilidad de volar a todas las clases secundarias, si existe una clase pato de goma tambien tiene la capacidad de volar, para solucionar esto se anula el metodo de la clase enviando un resultado vacio
## SimUDuckSolucion3:
Otra posible solucion es la del uso de interfaces, el problema es que si necesitamos modificar el codigo que se implemento en muchas clases el mantenimiento sera grande.
## SimUDuckSolucion4
Diseñando el comportamiento de los patos, identificamos los aspectos de la aplicacion que varían y las separamos de las que permanecen igual
