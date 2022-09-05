using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class Cola
    {
        Nodo centinelaPrimero;
        public Cola()
        {
            centinelaPrimero = new Nodo();
        }
        private Nodo BuscarUltimo(Nodo pNodo)
        {
            Nodo Nodorta = pNodo;
            if (pNodo.Siguiente != null) Nodorta = BuscarUltimo(pNodo.Siguiente);
            return Nodorta;
        }
        public void Encolar(int pId)
        {
            Nodo aux = new Nodo(pId);
            if (centinelaPrimero.Siguiente == null) centinelaPrimero.Siguiente = aux;
            else BuscarUltimo(centinelaPrimero.Siguiente).Siguiente = aux;
        }
        public void Encolar(Nodo pNodo)
        {
            Nodo aux = pNodo;
            if (centinelaPrimero.Siguiente == null) centinelaPrimero.Siguiente = aux;
            else BuscarUltimo(centinelaPrimero.Siguiente).Siguiente = aux;
        }
        public Nodo Desencolar()
        {
            Nodo nodoRta = centinelaPrimero.Siguiente;
            if (centinelaPrimero.Siguiente != null)
            {
                Nodo aux = nodoRta.Siguiente;
                nodoRta.Siguiente = null;
                centinelaPrimero.Siguiente = aux;
            }
            return nodoRta;
        }
        public Nodo Ver()
        {
            Nodo nodoRta = null;
            if (centinelaPrimero.Siguiente != null) nodoRta = new Nodo(centinelaPrimero.Siguiente.Id);
            return nodoRta;
        }
    }
    public class Nodo
    {
        public Nodo(int pId = 0) { Id = pId; Siguiente = null; }
        public int Id { get; }
        public Nodo Siguiente { get; set; }
    }
}
