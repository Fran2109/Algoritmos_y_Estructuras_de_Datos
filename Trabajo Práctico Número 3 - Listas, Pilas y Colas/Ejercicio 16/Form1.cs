using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_16
{
    public partial class Form1 : Form
    {
        Cola colaPendientes;
        Cola colaPagos;
        string textACobrar, textCobrados;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            colaPendientes = new Cola();
            colaPagos = new Cola();
            textACobrar = "Cantidad de Clientes a Cobrar";
            textCobrados = "Cantidad de Clientes Cobrados";
            Mostrar(colaPendientes, listBox1, label1, textACobrar);
            Mostrar(colaPagos, listBox2, label2, textCobrados);
        }
        private void Mostrar(Cola cola, ListBox listBox, Label label, string text)
        {
            Cola aux = new Cola();
            int cant = 0;
            listBox.Items.Clear();
            while(cola.Ver()!=null) aux.Encolar(cola.Desencolar());
            while(aux.Ver()!=null)
            {
                Nodo nodo = aux.Desencolar();
                cola.Encolar(nodo);
                listBox.Items.Add($"{nodo.Id}: {nodo.Monto}");
                cant++;
            }
            label.Text = $"{text}: {cant}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Id"));
                float monto = float.Parse(Interaction.InputBox("Monto"));
                colaPendientes.Encolar(id, monto);
                Mostrar(colaPendientes, listBox1, label1, textACobrar);
            } catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                colaPagos.Encolar(colaPendientes.Desencolar());
                Mostrar(colaPendientes, listBox1, label1, textACobrar);
                Mostrar(colaPagos, listBox2, label2, textCobrados);
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }
        private float obtenerMonto(Cola cola)
        {
            float resultado = 0;
            Cola aux = new Cola();
            while (cola.Ver() != null) aux.Encolar(cola.Desencolar());
            while (aux.Ver() != null)
            {
                Nodo nodo = aux.Desencolar();
                cola.Encolar(nodo);
                resultado += nodo.Monto;
            }
            return resultado;
        }
    }
}
