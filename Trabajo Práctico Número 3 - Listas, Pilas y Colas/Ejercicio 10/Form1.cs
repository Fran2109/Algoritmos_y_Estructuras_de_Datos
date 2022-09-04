using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10
{
    public partial class Form1 : Form
    {
        Pila pila1;
        Pila pila2;
        Pila pila3;
        int levantado;
        int jugadas;
        int tamanio;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pila1 = new Pila();
            pila2 = new Pila();
            pila3 = new Pila();
            levantado = 0;
            HabilitarDeshabilitarTodasApilar();
            HabilitarDeshabilitarTodasDesapilar();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Limpiar(pila1);
            Limpiar(pila2);
            Limpiar(pila3);
            tamanio = int.Parse(numericUpDown1.Value.ToString());
            for (int i = tamanio; i > 0; i--)
            {
                pila1.Apilar(i);
            }
            Mostrar(pila1, listBox1);
            Mostrar(pila2, listBox2);
            Mostrar(pila3, listBox3);
            HabilitarDeshabilitarDesapilar(pila1, button2);
            HabilitarDeshabilitarDesapilar(pila2, button4);
            HabilitarDeshabilitarDesapilar(pila3, button6);
            button1.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            jugadas = 0;
            label2.Text = $"Numero de Jugadas: {jugadas}";
        }
        private void Mostrar(Pila pila, ListBox listBox)
        {
            Pila aux = new Pila();
            listBox.Items.Clear();
            while (pila.Ver() != null)
            {
                aux.Apilar(pila.Desapilar());
                listBox.Items.Add(aux.Ver().Tam.ToString());
            }
            while (aux.Ver() != null)
            {
                pila.Apilar(aux.Desapilar());
            }
        }
        private void Limpiar(Pila pila)
        {
            while (pila.Ver() != null)
            {
                pila.Desapilar();
            }
        }
        public class Pila
        {
            Nodo centinela;
            public Pila()
            {
                centinela = new Nodo();
            }
            public void Apilar(int tam)
            {
                Nodo aux = new Nodo(tam);
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
            public void Apilar(Nodo pNodo)
            {
                Nodo aux = pNodo;
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
                    nodoRta = new Nodo(centinela.Siguiente.Tam);
                }
                return nodoRta;
            }
        }
        public class Nodo
        {
            public Nodo(int intTam = 0) { Tam = intTam; Siguiente = null; }
            public int Tam { get; }
            public Nodo Siguiente { get; set; }
        }
        private void Desapilar(Pila pila, ListBox listBox, Button button)
        {
            levantado = pila.Desapilar().Tam;
            label1.Text = levantado.ToString();
            Mostrar(pila, listBox);
            DeshabilitarTodasDesapilar();
            HabilitarDeshabilitarTodasApilar();
        }
        private void HabilitarDeshabilitarDesapilar(Pila pila, Button button)
        {
            if (pila.Ver() == null)
            {
                button.Enabled = false;
            }
            else
            {
                button.Enabled = true;
            }
        }
        private void DeshabilitarTodasDesapilar()
        {
            button2.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
        }
        private void HabilitarDeshabilitarTodasDesapilar()
        {
            HabilitarDeshabilitarDesapilar(pila1, button2);
            HabilitarDeshabilitarDesapilar(pila2, button4);
            HabilitarDeshabilitarDesapilar(pila3, button6);
        }
        private void HabilitarDeshabilitarTodasApilar()
        {
            HabilitarDeshabilitarApilar(pila1, button1);
            HabilitarDeshabilitarApilar(pila2, button3);
            HabilitarDeshabilitarApilar(pila3, button5);
        }
        private void HabilitarDeshabilitarApilar(Pila pila, Button button)
        {
            Nodo aux;
            bool estado;
            aux = pila.Ver();
            if (levantado != 0)
            {
                if (aux == null)
                {
                    estado = true;
                }
                else if (aux.Tam > levantado)
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
            }
            else
            {
                estado = false;
            }
            button.Enabled = estado;
        }
        private void Apilar(Pila pila, ListBox listBox, Button button)
        {
            pila.Apilar(levantado);
            Mostrar(pila, listBox);
            HabilitarDeshabilitarTodasDesapilar();
            levantado = 0;
            label1.Text = "Levante";
            HabilitarDeshabilitarTodasApilar();
            actualizarJugadas();
            VerificarGanador();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Desapilar(pila1, listBox1, button2);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Desapilar(pila2, listBox2, button4);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Desapilar(pila3, listBox3, button6);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Apilar(pila1, listBox1, button1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Apilar(pila2, listBox2, button3);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Apilar(pila3, listBox3, button5);
        }
        private void actualizarJugadas()
        {
            jugadas++;
            label2.Text = $"Numero de Jugadas: {jugadas}";
        }
        private void VerificarGanador()
        {
            Pila aux = new Pila();
            Nodo auxN;
            int i = 0;
            bool gano = true;
            while (pila3.Ver() != null)
            {
                auxN = pila3.Desapilar();
                i++;
                if (auxN.Tam != i)
                {
                    gano = false;
                }
                aux.Apilar(auxN);
            }
            if (i != tamanio)
            {
                gano = false;
            }
            while (aux.Ver() != null)
            {
                pila3.Apilar(aux.Desapilar());
            }
            if (gano)
            {
                MessageBox.Show("GANOOOO");
            }
        }
    }
}
