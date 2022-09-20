using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    public class Lista
    {
        Nodo CentinelaPrimero;
        public Lista()
        {
            CentinelaPrimero = new Nodo();
        }
        public void InsertarFinal(Persona persona)
        {
            UltimoNodo().Siguiente = new Nodo(persona);
        }
        public void InsertarInicio(Persona persona)
        {
            if(Cantidad() != 0)
            {
                CentinelaPrimero.Siguiente = new Nodo(persona, CentinelaPrimero.Siguiente);
            }
            else
            {
                CentinelaPrimero.Siguiente = new Nodo(persona);
            }
        }
        private Nodo UltimoNodo()
        {
            Nodo rta = CentinelaPrimero;
            if(Cantidad() != 0)
            {
                for(int i = 0; i<Cantidad(); i++)
                {
                    rta = rta.Siguiente;
                }
            }
            return rta;
        }
        public int Cantidad()
        {
            int cant = 0;
            if(CentinelaPrimero.Siguiente != null)
            {
                cant = RCantidad(CentinelaPrimero);
            }
            return cant;
        }
        private int RCantidad(Nodo nodo)
        {
            int cant;
            if (nodo.Siguiente == null) cant = 0;
            else cant = 1 +RCantidad(nodo.Siguiente);
            return cant;
        }
        public Persona BuscarPorPosicion(int posicion)
        {
            Nodo aux = CentinelaPrimero;
            for(int i = 0; i<posicion; i++)
            {
                aux = aux.Siguiente;
            }
            return aux.Persona;
        }
        public float PromedioDeEdades()
        {
            float sum = 0;
            Nodo aux = CentinelaPrimero;
            for(int i = 0; i<Cantidad(); i++)
            {
                aux = aux.Siguiente;
                sum += aux.Persona.Edad;
            }
            return sum / Cantidad();
        }
        public float PromedioDePesos()
        {
            float sum = 0;
            Nodo aux = CentinelaPrimero;
            for (int i = 0; i < Cantidad(); i++)
            {
                aux = aux.Siguiente;
                sum += aux.Persona.Peso;
            }
            return sum / Cantidad();
        }
        public Persona PersonaMasAnciana()
        {
            Persona persona = new Persona("", "", 0, 0, "");
            Nodo aux = CentinelaPrimero;
            for (int i = 0; i < Cantidad(); i++)
            {
                aux = aux.Siguiente;
                if (persona.Edad < aux.Persona.Edad) persona = aux.Persona;
            }
            return persona;
        }
        public Persona PersonaMasJoven()
        {
            Persona persona = CentinelaPrimero.Siguiente.Persona;
            Nodo aux = CentinelaPrimero;
            for (int i = 0; i < Cantidad(); i++)
            {
                aux = aux.Siguiente;
                if (persona.Edad > aux.Persona.Edad) persona = aux.Persona;
            }
            return persona;
        }
        public Persona PersonaMasDelgada()
        {
            Persona persona = CentinelaPrimero.Siguiente.Persona;
            Nodo aux = CentinelaPrimero;
            for (int i = 0; i < Cantidad(); i++)
            {
                aux = aux.Siguiente;
                if (persona.Peso < aux.Persona.Peso) persona = aux.Persona;
            }
            return persona;
        }
        public Persona PersonaMasObesa()
        {
            Persona persona = CentinelaPrimero.Siguiente.Persona;
            Nodo aux = CentinelaPrimero;
            for (int i = 0; i < Cantidad(); i++)
            {
                aux = aux.Siguiente;
                if (persona.Peso > aux.Persona.Peso) persona = aux.Persona;
            }
            return persona;
        }
        public int CantidadPersonasMayores()
        {
            int rta = 0;
            Nodo aux = CentinelaPrimero;
            for (int i = 0; i < Cantidad(); i++)
            {
                aux = aux.Siguiente;
                if (50 < aux.Persona.Edad) rta++;
            }
            return rta;
        }
        public int CantidadPersonasPesadas()
        {
            int rta = 0;
            Nodo aux = CentinelaPrimero;
            for (int i = 0; i < Cantidad(); i++)
            {
                aux = aux.Siguiente;
                if (60 < aux.Persona.Peso) rta++;
            }
            return rta;
        }
    }
    public class Nodo
    {
        public Nodo Siguiente { get; set; }
        public Persona Persona { get; set; }
        public Nodo(Persona persona = null, Nodo siguiente = null)
        {
            Persona = persona;
            Siguiente = siguiente;
        }
    }
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public float Peso { get; set; }
        public string Sexo { get; set; }
        public Persona(string nombre, string apellido, int edad, float peso, string sexo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Peso = peso;
            Sexo = sexo;
        }
        public string toString()
        {
            return $"{Nombre} {Apellido}, {Edad} años, {Peso} kilos, {Sexo}";
        }
    }
}
