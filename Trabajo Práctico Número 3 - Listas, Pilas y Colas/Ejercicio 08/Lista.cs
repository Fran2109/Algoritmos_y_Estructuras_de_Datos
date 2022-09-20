using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    public class Lista
    {
        Nodo<TelemLista> CentinelaPrimero;
        public Lista() { CentinelaPrimero =  new Nodo<TelemLista>(); }
        public void InsertarFinal(TelemLista telemLista)
        {
            UltimoNodo().Siguiente = new Nodo<TelemLista>(telemLista);
        }
        private Nodo<TelemLista> UltimoNodo()
        {
            Nodo<TelemLista> aux = CentinelaPrimero;
            while(aux.Siguiente != null)
            {
                aux = aux.Siguiente;
            }
            return aux;
        }
        public int Cantidad()
        {
            int cant = 0;
            Nodo<TelemLista> aux = CentinelaPrimero;
            while(aux.Siguiente != null)
            {
                cant++;
                aux = aux.Siguiente;
            }
            return cant;
        }
        public TelemLista BuscarPorPosicion(int Posicion)
        {
            Nodo<TelemLista> aux = CentinelaPrimero;
            for(int i = 1; i <= Posicion; i++)
            {
                aux = aux.Siguiente;
            }
            return aux.Item;
        }
        public void Agregar()
        {
            Nodo<TelemLista> aux = CentinelaPrimero;
            Nodo<TelemLista> aux2 = CentinelaPrimero.Siguiente;
            while (aux.Siguiente != null)
            {
                aux = aux.Siguiente;
                if (aux2.Item.CantTareas > aux.Item.CantTareas) { aux2 = aux; }
            }
            aux2.Item.CantTareas++;
        }
        public void Quitar(int id)
        {
            Nodo<TelemLista> aux = CentinelaPrimero;
            while (aux.Siguiente != null)
            {
                aux = aux.Siguiente;
                if (aux.Item.Codigo == id) { break; }
            }
            aux.Item.CantTareas--;
        }
    }
    public class Nodo<Tipo>
    {
        public Tipo Item { get; set; }
        public Nodo<Tipo> Siguiente { get; set; }
        public Nodo(Tipo item, Nodo<Tipo> siguiente)
        {
            Item = item;
            Siguiente = siguiente;
        }
        public Nodo(Tipo item)
        {
            Item = item;
            Siguiente = null;
        }
        public Nodo()
        {
            Item = default(Tipo);
            Siguiente = null;
        }
        
    }
    public class TelemLista
    {
        public int Codigo { get; set; }
        public int CantTareas { get; set; }
        public TelemLista(int codigo, int cantTareas)
        {
            Codigo = codigo;
            CantTareas = cantTareas;
        }
        public string toString()
        {
            return $"Codigo de Empleado: {Codigo}, Cantidad de Tareas= {CantTareas}";
        }
    }
}
