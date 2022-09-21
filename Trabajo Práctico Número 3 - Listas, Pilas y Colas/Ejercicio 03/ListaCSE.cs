using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    public class ListaCSE
    {
        Nodo CentinelaPrimero;
        public ListaCSE()
        {
            CentinelaPrimero = new Nodo();
        }
        private Nodo BuscarUltimo()
        {
            Nodo nodo = CentinelaPrimero;
            do
            {
                nodo = nodo.Siguiente;
            } while (CentinelaPrimero != nodo.Siguiente);
            return nodo;
        }
        public Nodo BuscarPorPosicion(int pos)
        {
            Nodo nodo = CentinelaPrimero;
            for(int i = 0; i<pos; i++)
            {
                nodo = nodo.Siguiente;
            }
            return new Nodo(nodo.Id);
        }
        private Nodo BuscarPorPosicionP(int pos)
        {
            Nodo nodo = CentinelaPrimero;
            for (int i = 0; i < pos; i++)
            {
                nodo = nodo.Siguiente;
            }
            return nodo;
        }
        public int Cantidad()
        {
            int cant = 0;
            Nodo nodo = CentinelaPrimero;
            do
            {
                nodo = nodo.Siguiente;
                cant++;
            } while (CentinelaPrimero != nodo.Siguiente);
            return cant;
        }
        public void AgregarFinal(string Dato)
        {
            if (CentinelaPrimero.Siguiente == null) CentinelaPrimero.Siguiente = new Nodo(Dato, CentinelaPrimero);
            else
            {
                Nodo aux = BuscarUltimo();
                aux.Siguiente = new Nodo(Dato, CentinelaPrimero);
            }
        }
        public void AgregarInicio(string Dato)
        {
            if (CentinelaPrimero.Siguiente == null) CentinelaPrimero.Siguiente = new Nodo(Dato, CentinelaPrimero);
            else
            {
                Nodo aux = CentinelaPrimero.Siguiente;
                CentinelaPrimero.Siguiente = new Nodo(Dato, aux);
                BuscarUltimo().Siguiente = CentinelaPrimero;
            }
        }
        public void AgregarMedio(string Dato, int Posicion)
        {
            if (Posicion == 1) AgregarInicio(Dato);
            else if (Posicion == Cantidad()) AgregarFinal(Dato);
            else if (Posicion > 1 && Posicion < Cantidad())
            {
                Nodo aux = BuscarPorPosicionP(Posicion);
                Nodo aux2 = BuscarPorPosicionP(Posicion - 1);
                aux2.Siguiente = new Nodo(Dato, aux);
            }
            else throw new Exception("Posicion Invalida");
        }
        public void BorrarFinal()
        {
            if (CentinelaPrimero.Siguiente == null) throw new Exception("Posicion Invalida");
            else if (Cantidad() == 1) CentinelaPrimero.Siguiente = null;
            else
            {
                Nodo Aux = BuscarPorPosicionP(Cantidad()-1);
                Aux.Siguiente = CentinelaPrimero;
            }
        }
        public void BorrarInicio()
        {
            if (CentinelaPrimero.Siguiente == null) throw new Exception("Posicion Invalida");
            else if (Cantidad() == 1) CentinelaPrimero.Siguiente = null;
            else
            {
                CentinelaPrimero.Siguiente = CentinelaPrimero.Siguiente.Siguiente;
            }
        }
        public void BorrarMedio(int Posicion)
        {
            if (Posicion < 1 || Posicion > Cantidad()) throw new Exception("Posicion Invalida");
            else if (Posicion == 1) BorrarInicio();
            else if (Posicion == Cantidad()) BorrarFinal();
            else
            {
                Nodo aux = BuscarPorPosicionP(Posicion-1);
                aux.Siguiente = aux.Siguiente.Siguiente;
            }
        }
    }
    public class Nodo
    {
        public string Id { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo(string id = "", Nodo siguiente = null)
        {
            Id = id;
            Siguiente = siguiente;
        }
    }
}
