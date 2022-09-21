using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_07
{
    public class Lista
    {
        Nodo CentinelaPrimero;
        public Lista() { CentinelaPrimero = new Nodo(); }
        public void InsertarFinal(TelemLista telemLista)
        {
            UltimoNodo().Siguiente = new Nodo(telemLista);
        }
        private Nodo UltimoNodo()
        {
            Nodo aux = CentinelaPrimero;
            while (aux.Siguiente != null)
            {
                aux = aux.Siguiente;
            }
            return aux;
        }
        public int Cantidad()
        {
            int cant = 0;
            Nodo aux = CentinelaPrimero;
            while (aux.Siguiente != null)
            {
                cant++;
                aux = aux.Siguiente;
            }
            return cant;
        }
        public TelemLista BuscarPorPosicion(int Posicion)
        {
            Nodo aux = CentinelaPrimero;
            for (int i = 1; i <= Posicion; i++)
            {
                aux = aux.Siguiente;
            }
            return aux.Item;
        }
        public int DepositosEntreFechas(DateTime dateTime1, DateTime dateTime2)
        {
            int rta = 0;
            Nodo aux = CentinelaPrimero;
            while (aux.Siguiente != null)
            {
                aux = aux.Siguiente;
                if (DateTime.Compare(dateTime1, aux.Item.Fecha) <= 0 && DateTime.Compare(aux.Item.Fecha, dateTime2) <= 0 && aux.Item.Tipo == "Deposito")
                {
                    rta++;
                }
            }
            return rta;
        }
        public float DepositosEnAnio(DateTime dateTime)
        {
            float rta = 0;
            Nodo aux = CentinelaPrimero;
            while (aux.Siguiente != null)
            {
                aux = aux.Siguiente;
                if (dateTime.Year == aux.Item.Fecha.Year && aux.Item.Tipo == "Deposito")
                {
                    rta += aux.Item.Monto;
                }
            }
            return rta;
        }
        public float ExtraccionesEnAnio(DateTime dateTime)
        {
            float rta = 0;
            Nodo aux = CentinelaPrimero;
            while (aux.Siguiente != null)
            {
                aux = aux.Siguiente;
                if (dateTime.Year == aux.Item.Fecha.Year && aux.Item.Tipo == "Extraccion")
                {
                    rta += aux.Item.Monto;
                }
            }
            return rta;
        }
        public void Ordenar()
        {
            for (int i = Cantidad(); i > 0; i--)
            {
                for(int j = Cantidad() - 1; j > 0; j--)
                {
                    if (DateTime.Compare(BuscarPorPosicion(j).Fecha, BuscarPorPosicion(j+1).Fecha) > 0)
                    {
                        Swap(j);
                    }
                }
            }
        }
        private Nodo ObtenerPorPosicion(int Posicion)
        {
            Nodo aux = CentinelaPrimero;
            for (int i = 0; i < Posicion; i++)
            {
                aux = aux.Siguiente;
            }
            return aux;
        }
        private void Swap(int pos)
        {
            Nodo aux, aux2, aux3;
            if(pos == 1)
            {
                aux = CentinelaPrimero.Siguiente.Siguiente;
                CentinelaPrimero.Siguiente.Siguiente = aux.Siguiente;
                aux.Siguiente = CentinelaPrimero.Siguiente;
                CentinelaPrimero.Siguiente = aux;
            } 
            else if(pos == Cantidad() - 1)
            {
                aux = ObtenerPorPosicion(Cantidad() - 1);
                aux2 = ObtenerPorPosicion(Cantidad() - 2);
                aux2.Siguiente = UltimoNodo();
                UltimoNodo().Siguiente = aux;
                aux.Siguiente = null;
            }
            else 
            {
                aux3 = ObtenerPorPosicion(pos - 1);
                aux2 = ObtenerPorPosicion(pos + 1);
                aux = ObtenerPorPosicion(pos);
                aux.Siguiente = aux2.Siguiente;
                aux3.Siguiente = aux2;
                aux2.Siguiente = aux;

            }
        }
    }
    public class Nodo
    {
        public TelemLista Item { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo(TelemLista item = null, Nodo siguiente = null)
        {
            Item = item;
            Siguiente = siguiente;
        }

    }
    public class TelemLista
    {
        public DateTime Fecha { get; set; }
        public int Nro_Cta { get; set; }
        public float Monto { get; set; }
        public string Tipo { get; set; }
        public TelemLista(DateTime fecha, int nro_Cta, float monto, string tipo)
        {
            Fecha = fecha;
            Nro_Cta = nro_Cta;
            Monto = monto;
            Tipo = tipo;
        }
        public string toString()
        {
            return $"Fecha: {Fecha}, NroCta: {Nro_Cta}, Monto: {Monto}, Tipo: {Tipo}";
        }
    }
}
