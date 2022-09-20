using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_02
{
    public class ListaDE
    {
        Nodo CentinelaPrimero;
        public ListaDE() { CentinelaPrimero = new Nodo("", null, null); }
        public void AgregarFinal(string Dato)
        {
            if (Cantidad() == 0) CentinelaPrimero.Siguiente = new Nodo(Dato);
            else
            {
                Nodo aux = BuscarUltimo();
                aux.Siguiente = new Nodo(Dato, null, aux);
            }
        }
        public void AgregarInicio(string Dato)
        {
            if (Cantidad() == 0) CentinelaPrimero.Siguiente = new Nodo(Dato);
            else
            {
                Nodo aux = CentinelaPrimero.Siguiente;
                CentinelaPrimero.Siguiente = new Nodo(Dato, aux, null);
                aux.Anterior = CentinelaPrimero.Siguiente;
            }
        }
        public void AgregarMedio(string Dato, int Posicion)
        {
            if (Posicion == 1) AgregarInicio(Dato);
            else if (Posicion == Cantidad()) AgregarFinal(Dato);
            else if (Posicion > 1 && Posicion < Cantidad())
            {
                Nodo aux = BuscarPorPosicionP(Posicion);
                aux.Anterior = new Nodo(Dato, aux, aux.Anterior);
                aux.Anterior.Anterior.Siguiente = aux.Anterior;
            }
            else throw new Exception("Posicion Invalida");
        }
        public void BorrarFinal()
        {
            if (CentinelaPrimero.Siguiente == null) throw new Exception("Posicion Invalida");
            else if (Cantidad() == 1) CentinelaPrimero.Siguiente = null;
            else
            {
                Nodo Aux = BuscarPorPosicionP(Cantidad());
                Aux.Anterior.Siguiente = null;
            }
        }
        public void BorrarInicio()
        {
            if (CentinelaPrimero.Siguiente == null) throw new Exception("Posicion Invalida");
            else if (Cantidad() == 1) CentinelaPrimero.Siguiente = null;
            else
            {
                Nodo aux = CentinelaPrimero.Siguiente;
                CentinelaPrimero.Siguiente = aux.Siguiente;
                CentinelaPrimero.Anterior = null;
            }
        }
        public void BorrarMedio(int Posicion)
        {
            if (Posicion < 1 || Posicion > Cantidad()) throw new Exception("Posicion Invalida");
            else if (Posicion == 1) BorrarInicio();
            else if (Posicion == Cantidad()) BorrarFinal();
            else
            {
                Nodo aux = BuscarPorPosicionP(Posicion);
                aux.Anterior.Siguiente = aux.Siguiente;
                aux.Siguiente.Anterior = aux.Anterior;
            }
        }
        public void IntercambiarD(int Posicion)
        {
            if (Posicion < 1 || Posicion >= Cantidad()) throw new Exception("Posicion Invalida");
            else if(Posicion == 1)
            {
                Nodo aux = CentinelaPrimero.Siguiente;
                CentinelaPrimero.Siguiente = aux.Siguiente;
                aux.Siguiente = aux.Siguiente.Siguiente;
                aux.Siguiente.Anterior = aux;
                CentinelaPrimero.Siguiente.Siguiente = aux;
                aux.Anterior = CentinelaPrimero.Siguiente;
            }
            else if(Posicion == Cantidad() - 1)
            {
                Nodo aux = BuscarPorPosicionP(Posicion);
                aux.Anterior.Siguiente = aux.Siguiente;
                aux.Anterior.Anterior = aux.Anterior;
                aux.Siguiente.Siguiente = aux;
                aux.Siguiente = aux.Siguiente.Siguiente;
                aux.Anterior.Siguiente.Siguiente = aux;
                aux.Anterior = aux.Anterior.Siguiente;
            }
            else
            {
                Nodo aux = BuscarPorPosicionP(Posicion);
                aux.Anterior.Siguiente = aux.Siguiente;
                aux.Siguiente.Anterior = aux.Anterior;
                aux.Anterior = aux.Anterior.Siguiente;
                aux.Siguiente= aux.Siguiente.Siguiente;
                aux.Anterior.Siguiente = aux;
            }
        }
        public void IntercambiarI(int Posicion)
        {
            if (Posicion < 1 || Posicion >= Cantidad()) throw new Exception("Posicion Invalida");
            else
            {

            }
        }
        public Nodo BuscarPorPosicion(int Posicion)
        {
            Nodo rta = null;
            Nodo aux;
            if (Posicion <= Cantidad() && Posicion > 0)
            {
                aux = CentinelaPrimero;
                for (int x = 0; x < Posicion; x++)
                {
                    aux = aux.Siguiente;
                }
                rta = new Nodo(aux.Id);
            }
            return rta;
        }
        private Nodo BuscarPorPosicionP(int Posicion)
        {
            Nodo rta = null;
            if (Posicion <= Cantidad() && Posicion > 0)
            {
                rta = CentinelaPrimero;
                for (int x = 0; x < Posicion; x++)
                {
                    rta = rta.Siguiente;
                }
            }
            return rta;
        }
        private Nodo BuscarUltimo()
        {
            Nodo rta = null;
            if(CentinelaPrimero.Siguiente != null)
            {
                rta = CentinelaPrimero;
                for (int i = 0; i < Cantidad(); i++)
                {
                    rta = rta.Siguiente;
                }
            }
            return rta;
        }
        public int Cantidad() 
        {
            int c = 0;
            Nodo aux = CentinelaPrimero.Siguiente;
            while (aux != null)
            {
                c++;
                aux = aux.Siguiente;
            }
            return c;
        }
        public void RecorrerInversa(ListBox listBox)
        {
            listBox.Items.Clear();
            Nodo nodo = BuscarUltimo();
            while(nodo.Anterior != null)
            {
                listBox.Items.Add(nodo.Id);
                nodo = nodo.Anterior;
            }
            listBox.Items.Add(nodo.Id);
        }
    }
    public class Nodo
    {
        public Nodo(string pId, Nodo pSiguiente = null, Nodo pAnterior = null)
        {
            Id = pId; Siguiente = pSiguiente; Anterior = pAnterior;
        }
        public string Id { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo Anterior { get; set; }
    }
}
