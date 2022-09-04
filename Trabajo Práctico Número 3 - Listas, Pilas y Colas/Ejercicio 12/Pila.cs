using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    public class Pila
    {
        Nodo centinela;
        public Pila()
        {
            centinela = new Nodo();
        }
        public void Apilar(char letra)
        {
            Nodo aux = new Nodo(letra);
            if (centinela.Siguiente == null)
            {
                centinela.Siguiente = aux;
            }
            else
            {
                aux.Siguiente = centinela.Siguiente;
                centinela.Siguiente = aux;
            }
        }
        public void Apilar(Nodo nodo)
        {
            Nodo aux = nodo;
            if (centinela.Siguiente == null)
            {
                centinela.Siguiente = aux;
            }
            else
            {
                aux.Siguiente = centinela.Siguiente;
                centinela.Siguiente = aux;
            }
        }
        public Nodo Desapilar()
        {
            Nodo nodoRta = centinela.Siguiente;
            if (centinela.Siguiente != null)
            {
                Nodo aux = nodoRta.Siguiente;
                nodoRta.Siguiente = null;
                centinela.Siguiente = aux;
            }
            return nodoRta;
        }
        public Nodo Ver()
        {
            Nodo nodoRta = null;
            if (centinela.Siguiente != null)
            {
                nodoRta = new Nodo(centinela.Siguiente.Letra);
            }
            return nodoRta;
        }
    }
    public class Nodo
    {
        public Nodo() { Siguiente = null; }
        public Nodo(char letra) { Letra = letra; Siguiente = null; }
        public char Letra { get; }
        public Nodo Siguiente { get; set; }
    }
}
