using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    public class Cola
    {
        Nodo CentinelaPrimero;
        public Cola()
        {
            CentinelaPrimero = new Nodo();
        }
        private Nodo BuscarUltimo(Nodo pNodo)
        {
            Nodo Nodorta = pNodo;
            if (pNodo.Siguiente != null) Nodorta = BuscarUltimo(pNodo.Siguiente);
            return Nodorta;
        }
        public void Encolar(int pId, int paginas )
        {
            Nodo aux = new Nodo(pId, paginas);
            if (CentinelaPrimero.Siguiente == null) CentinelaPrimero.Siguiente = aux;
            else BuscarUltimo(CentinelaPrimero.Siguiente).Siguiente = aux;
        }
        public void Encolar(Nodo pNodo)
        {
            Nodo aux = pNodo;
            if (CentinelaPrimero.Siguiente == null) CentinelaPrimero.Siguiente = aux;
            else BuscarUltimo(CentinelaPrimero.Siguiente).Siguiente = aux;
        }
        public Nodo Desencolar()
        {
            Nodo nodoRta = CentinelaPrimero.Siguiente;
            if (CentinelaPrimero.Siguiente != null)
            {
                Nodo aux = nodoRta.Siguiente;
                nodoRta.Siguiente = null;
                CentinelaPrimero.Siguiente = aux;
            }
            return nodoRta;
        }
        public Nodo Ver()
        {
            Nodo nodoRta = null;
            if (CentinelaPrimero.Siguiente != null) nodoRta = new Nodo(CentinelaPrimero.Siguiente.Id, CentinelaPrimero.Siguiente.Paginas);
            return nodoRta;
        }
    }
    public class Nodo
    {
        public Nodo(int pId = 0, int pPaginas = 0) { Id = pId; Paginas = pPaginas; Siguiente = null; }
        public int Id { get; set; }
        public int Paginas { get; set; }
        public Nodo Siguiente { get; set; }
    }
}
