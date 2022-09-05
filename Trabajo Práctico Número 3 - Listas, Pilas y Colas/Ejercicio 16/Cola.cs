using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
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
        public void Encolar(int pId, float monto)
        {
            Nodo aux = new Nodo(pId, monto);
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
            if (centinelaPrimero.Siguiente != null) nodoRta = new Nodo(centinelaPrimero.Siguiente.Id, centinelaPrimero.Siguiente.Monto);
            return nodoRta;
        }
    }
    public class Nodo
    {
        public Nodo(int pId = 0, float pMonto = 0) { Id = pId; Monto = pMonto;  Siguiente = null; }
        public int Id { get; }
        public float Monto { get; }
        public Nodo Siguiente { get; set; }
    }
}
