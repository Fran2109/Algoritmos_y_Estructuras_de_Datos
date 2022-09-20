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

namespace Ejercicio_08
{
    public partial class Form1 : Form
    {
        Lista lista;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista = new Lista();
            lista.InsertarFinal(new TelemLista(1, 3));
            lista.InsertarFinal(new TelemLista(2, 6));
            lista.InsertarFinal(new TelemLista(3, 1));
            lista.InsertarFinal(new TelemLista(4, 4));
            Mostrar();
        }
        private void Mostrar()
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= lista.Cantidad(); i++)
            {
                listBox1.Items.Add(lista.BuscarPorPosicion(i).toString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Agregar();
            Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista.Quitar(int.Parse(Interaction.InputBox("Quitar")));
            Mostrar();
        }
    }
}
