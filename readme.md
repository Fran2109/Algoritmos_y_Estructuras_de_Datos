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
Ejercicio 06
```cSharp
private void textBox1_TextChanged(object sender, EventArgs e)
{
    try
    {
        if (int.TryParse(textBox1.Text, out int n))
        {
            label1.Text = sumaPares(n).ToString();
        }
        else
        {
            label1.Text = "0";
        }
    } catch (Exception err){ MessageBox.Show(err.Message); }

}

public int sumaPares(int n)
{
    if(n%2 == 1)
    {
        throw new Exception("Ingrese un Numero Par");
    } else if(n == 0)
    {
        return 0;
    } else
    {
        return n + sumaPares(n - 2);
    }
}
```
## Clase 18/08/2022
### Pilas
Apilar<br>
Desapilar<br>
Leer<br>
### Colas
### Listas

