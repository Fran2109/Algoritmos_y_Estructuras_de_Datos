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

namespace Ejercicio_15
{
    public partial class Form1 : Form
    {
        Cola cola;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cola = new Cola();
            Mostrar(cola, listBox1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(Interaction.InputBox("Encolar"));
                cola.Encolar(numero);
                Mostrar(cola, listBox1);
            } catch (Exception err) { MessageBox.Show(err.Message); } 
        }
        private void Mostrar(Cola cola, ListBox listBox)
        {
            Cola aux = new Cola();
            listBox.Items.Clear();
            while(cola.Ver() != null)
            {
                aux.Encolar(cola.Desencolar().Id);
            }
            while(aux.Ver() != null)
            {
                Nodo nodo = aux.Desencolar();
                cola.Encolar(nodo.Id);
                listBox1.Items.Add(nodo.Id);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = cola.Desencolar().Id;
                Mostrar(cola, listBox1);
            } catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = cola.Ver().Id;
                MessageBox.Show(numero.ToString());
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }
    }
}
