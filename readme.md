# Algoritmos y Estructuras de Datos
## Clase 04/08/2022
### Algoritmo
Series de pasos ordenados, finitos y precisos para lograr una solucion a determinado problema.<br>
Pasos finitos: Algoritmo asociado a un programa. Grupos de codigo finitos.<br>
Tiempo de ejecucion de un algoritmo depende de la cantidad de pasos y desiciones a tomar.<br>
Propiedades:
* Especificacion precisa de la entrada.
* Especificacion precisa de cada instruccion.
* Exactitud y correccion.
* Etapas bien definidas y concretas.
* Numeros finitos de pasos.
* Un algoritmo debe terminar.
* Descripcion del resultado o efecto.
### Complejidad Ciclomatica(CC)
Metrica. Complejidad Ciclomatica(CC).<br>
Sirve para determinar la complejidad logica de un diseño y saber la cantidad minima de pruebas para garantizar que cada camino basico fue probado
* CC = Regiones + 1 Regiones: Areas cerradas del codigo
* CC = Nodos Predicados + 1 Nodos predicados: Grado de salida 2
* CC = Aristas - Nodos + 2  Aristas: Todas las flechas  Nodos: Todos los simbolos
