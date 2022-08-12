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
## Clase 11/08/2022
### Recursividad
Una funcion que se llama a si misma
Dos Partes: Caso Base y Caso Recursivo.
```cSharp
int factorial (int n)
{
  int resultado;
  if(n==0)
    resultado = 1;
  else
    resultado = n * factorial(n-1);
  return (resultado);
}
int potencia (int base, int exp)
{
  if(exp == 0)
    return 1;
  else
    return base * potencia(base, exp-1);
}
```
```cSharp
private void textBox1_TextChanged(object sender, EventArgs e)
{
    if(textBox1.Text.Length>0)
    label1.Text = sumar(int.Parse(textBox1.Text)).ToString();
}
public int sumar(int n)
{
    if (n == 0)
        return 0;
    else
        return n - 1 + sumar(n - 1);
}
```
```cSharp
private void textBox1_TextChanged(object sender, EventArgs e)
{
    if(textBox1.Text.Length>0)
    label1.Text = concat(int.Parse(textBox1.Text));
}
public string concat(int n)
{
    string respuesta = "";
    if(n != 0)
    {
        respuesta += $"{concat(n - 1)}-{n * 2}";
    }
    return respuesta;
}
```
