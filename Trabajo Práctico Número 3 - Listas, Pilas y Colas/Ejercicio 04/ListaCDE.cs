using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_04
{
    public class ListaCDE
    {
        Nodo CentinelaPrimero;
        public ListaCDE()
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
            for (int i = 0; i < pos; i++)
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
            if (nodo.Siguiente != null)
            {
                do
                {
                    nodo = nodo.Siguiente;
                    cant++;
                } while (CentinelaPrimero != nodo.Siguiente);
            }
            return cant;
        }
        public void AgregarFinal(string Dato)
        {
            if (CentinelaPrimero.Siguiente == null)
            {
                Nodo aux = new Nodo(Dato, CentinelaPrimero, CentinelaPrimero);
                CentinelaPrimero.Siguiente = aux;
                CentinelaPrimero.Anterior = aux;
            }
            else
            {
                Nodo aux = BuscarUltimo();
                aux.Siguiente = new Nodo(Dato, CentinelaPrimero, aux);
                CentinelaPrimero.Anterior = aux.Siguiente;
            }
        }
        public void AgregarInicio(string Dato)
        {
            if (CentinelaPrimero.Siguiente == null)
            {
                Nodo aux = new Nodo(Dato, CentinelaPrimero, CentinelaPrimero);
                CentinelaPrimero.Siguiente = aux;
                CentinelaPrimero.Anterior = aux;
            }
            else
            {
                Nodo aux = CentinelaPrimero.Siguiente;
                CentinelaPrimero.Siguiente = new Nodo(Dato, aux, CentinelaPrimero);
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
                Nodo aux2 = BuscarPorPosicionP(Posicion - 1);
                aux2.Siguiente = new Nodo(Dato, aux, aux2);
                aux.Anterior = aux2.Siguiente;
            }
            else throw new Exception("Posicion Invalida");
        }
        public void BorrarFinal()
        {
            if (CentinelaPrimero.Siguiente == null) throw new Exception("Posicion Invalida");
            else if (Cantidad() == 1)
            {
                CentinelaPrimero.Siguiente = null;
                CentinelaPrimero.Anterior = null;
            }
            else
            {
                Nodo Aux = BuscarPorPosicionP(Cantidad() - 1);
                Aux.Siguiente = CentinelaPrimero;
                CentinelaPrimero.Anterior = Aux;
            }
        }
        public void BorrarInicio()
        {
            if (CentinelaPrimero.Siguiente == null) throw new Exception("Posicion Invalida");
            else if (Cantidad() == 1)
            {
                CentinelaPrimero.Siguiente = null;
                CentinelaPrimero.Anterior = null;
            }
            else
            {
                CentinelaPrimero.Siguiente = CentinelaPrimero.Siguiente.Siguiente;
                CentinelaPrimero.Siguiente.Anterior = CentinelaPrimero;
            }
        }
        public void BorrarMedio(int Posicion)
        {
            if (Posicion < 1 || Posicion > Cantidad()) throw new Exception("Posicion Invalida");
            else if (Posicion == 1) BorrarInicio();
            else if (Posicion == Cantidad()) BorrarFinal();
            else
            {
                Nodo aux = BuscarPorPosicionP(Posicion - 1);
                aux.Siguiente = aux.Siguiente.Siguiente;
                aux.Siguiente.Anterior = aux;
            }
        }
        public void RecorrerInversa(ListBox listBox)
        {
            listBox.Items.Clear();
            Nodo nodo = CentinelaPrimero;
            if(nodo.Anterior != null)
            {
                do
                {
                    nodo = nodo.Anterior;
                    listBox.Items.Add(nodo.Id);
                } while (CentinelaPrimero != nodo.Anterior);
            }
        }
    }
    public class Nodo
    {
        public string Id { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo Anterior { get; set; }
        public Nodo(string id = "", Nodo siguiente = null, Nodo anterior = null)
        {
            Id = id;
            Siguiente = siguiente;
            Anterior = anterior;
        }
    }
}
