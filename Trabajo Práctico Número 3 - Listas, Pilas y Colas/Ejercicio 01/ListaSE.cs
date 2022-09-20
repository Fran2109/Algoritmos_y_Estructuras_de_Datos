using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public class ListaSE
    {
        Nodo CentinelaPrimero;
        public ListaSE() { CentinelaPrimero = new Nodo("", null); }
        public void AgregarFinal(string Dato)
        {
            if (Cantidad() == 0)
            {
                CentinelaPrimero.Siguiente = new Nodo(Dato);
            }
            else
            {
                UltimoNodo().Siguiente = new Nodo(Dato);
            }
        }
        public void AgregarInicio(string Dato)
        {
            if(Cantidad() == 0)
            {
                CentinelaPrimero.Siguiente = new Nodo(Dato);
            }
            else
            {
                Nodo aux = CentinelaPrimero.Siguiente;
                CentinelaPrimero.Siguiente = new Nodo(Dato, aux);
            }
        }
        public void AgregarMedio(string Dato, int Posicion)
        {
            if (Posicion > Cantidad() || Posicion < 1) throw new Exception("Posicion no valida");
            else if (Posicion == 1) AgregarInicio(Dato);
            else if (Posicion == Cantidad()) AgregarFinal(Dato);
            else
            {
                Nodo aux = BuscarPorPosicionP(Posicion);
                Nodo aux2 = BuscarPorPosicionP(Posicion - 1);
                aux2.Siguiente = new Nodo(Dato, aux);
            }
        }
        public void BorrarFinal()
        {
            if(Cantidad() != 0)
            {
                Nodo aux = BuscarPorPosicionP(Cantidad() - 1);
                aux.Siguiente = null;
            }
            else
            {
                throw new Exception("Lista Vacia");
            }
        }
        public void BorrarInicio()
        {
            if (Cantidad() != 0)
            {
                Nodo aux = CentinelaPrimero.Siguiente;
                CentinelaPrimero.Siguiente = aux.Siguiente;
            }
            else
            {
                throw new Exception("Lista Vacia");
            }
        }
        public void BorrarMedio(int Posicion)
        {
            if (Posicion == 1) BorrarInicio();
            else if (Posicion == Cantidad()) BorrarFinal();
            else
            {
                Nodo aux = BuscarPorPosicionP(Posicion);
                Nodo aux2 = BuscarPorPosicionP(Posicion - 1);
                aux2.Siguiente = aux.Siguiente;
            }
        }
        public void IntercambiarD(int Posicion)
        {
            Nodo auxAnt;
            Nodo aux;
            Nodo auxSig;
            if (Posicion == 1)
            {
                aux = CentinelaPrimero.Siguiente;
                auxSig = aux.Siguiente;
                CentinelaPrimero.Siguiente = auxSig;
                aux.Siguiente = auxSig.Siguiente;
                auxSig.Siguiente = aux;
            }
            else if (Posicion == Cantidad()) throw new Exception("Posicion no valida");
            else
            {
                auxAnt = BuscarPorPosicionP(Posicion - 1);
                aux = auxAnt.Siguiente;
                auxSig = aux.Siguiente;
                auxAnt.Siguiente = auxSig;
                aux.Siguiente = auxSig.Siguiente;
                auxSig.Siguiente = aux;
            }
        }
        public void IntercambiarI(int Posicion)
        {
            Nodo auxAnt;
            Nodo aux;
            Nodo auxSig;
            if(Posicion == Cantidad())
            {
                auxAnt = BuscarPorPosicionP(Posicion - 2);
                aux = auxAnt.Siguiente;
                auxSig = aux.Siguiente;
                auxAnt.Siguiente = auxSig;
                auxSig.Siguiente = aux;
                aux.Siguiente = null;
            }
            else if (Posicion == 1) throw new Exception("Posicion no valida");
            else if(Posicion == 2)
            {
                auxAnt = CentinelaPrimero.Siguiente;
                aux = auxAnt.Siguiente;
                auxSig = aux.Siguiente;
                auxAnt.Siguiente = auxSig;
                aux.Siguiente = auxAnt;
                CentinelaPrimero.Siguiente = aux;
            }
            else
            {
                auxAnt = BuscarPorPosicionP(Posicion - 2);
                aux = auxAnt.Siguiente;
                auxSig = aux.Siguiente;
                auxAnt.Siguiente = auxSig;
                aux.Siguiente = auxSig.Siguiente;
                auxSig.Siguiente = aux;
            }
        }
        public int Cantidad()
        {
            int rta = 0;
            if (CentinelaPrimero.Siguiente != null)
            {
                rta = RecursivaCantidad(CentinelaPrimero);
            }
            return rta;
        }
        private int RecursivaCantidad(Nodo pNodo)
        {
            int rta = 0;
            if (pNodo.Siguiente != null)
            { rta = 1 + RecursivaCantidad(pNodo.Siguiente); }
            return rta;
        }
        private Nodo UltimoNodo()
        {
            Nodo rta = null;
            if (CentinelaPrimero.Siguiente != null)
            {
                rta = RecursivaUltimoNodo(CentinelaPrimero);
            }
            return rta;
        }
        private Nodo RecursivaUltimoNodo(Nodo pNodo)
        {
            Nodo _nodo = null;
            if (pNodo.Siguiente == null)
            { _nodo = pNodo; }
            else
            {
                _nodo = RecursivaUltimoNodo(pNodo.Siguiente);
            }
            return _nodo;
        }
        public Nodo BuscarPorPosicion(int pPosicion)
        {
            Nodo rta = null;
            Nodo aux;
            if (pPosicion <= Cantidad() && pPosicion > 0)
            {
                aux = CentinelaPrimero;
                for (int x = 0; x < pPosicion; x++)
                {
                    aux = aux.Siguiente;
                }
                rta = new Nodo(aux.Id);
            }
            return rta;
        }
        private Nodo BuscarPorPosicionP(int posicion)
        {
            Nodo rta = null;
            if (posicion <= Cantidad() && posicion > 0)
            {
                rta = CentinelaPrimero;
                for (int x = 0; x < posicion; x++)
                {
                    rta = rta.Siguiente;
                }
            }
            return rta;
        }
    }
    public class Nodo
    {
        public Nodo(string pId, Nodo pSiguiente = null)
        {
            Id = pId; Siguiente = pSiguiente;
        }
        public string Id { get; set; }
        public Nodo Siguiente { get; set; }
    }
}
