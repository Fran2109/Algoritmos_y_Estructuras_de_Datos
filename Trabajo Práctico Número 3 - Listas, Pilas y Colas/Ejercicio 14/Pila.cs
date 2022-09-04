using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public class Pila
    {
        Nodo centinela;
        public Pila()
        {
            centinela = new Nodo();
        }
        public void Apilar(int id)
        {
            Nodo aux = new Nodo(id);
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
                nodoRta = new Nodo(centinela.Siguiente.Id);
            }
            return nodoRta;
        }
    }
    public class Nodo
    {
        public Nodo(int id = 0) { Id = id; Siguiente = null; }
        public int Id { get; }
        public Nodo Siguiente { get; set; }
    }
}
