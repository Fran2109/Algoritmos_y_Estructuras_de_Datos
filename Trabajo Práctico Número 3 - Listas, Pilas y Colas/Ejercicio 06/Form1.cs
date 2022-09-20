using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_06
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
            lista.InsertarFinal(new TelemLista(DateTime.Parse("21/09/2010"), 1, 463, "Deposito"));
            lista.InsertarFinal(new TelemLista(DateTime.Parse("21/10/2011"), 2, 789, "Deposito"));
            lista.InsertarFinal(new TelemLista(DateTime.Parse("18/02/2015"), 3, 587, "Extraccion"));
            lista.InsertarFinal(new TelemLista(DateTime.Parse("05/05/2019"), 4, 890, "Deposito"));
            lista.InsertarFinal(new TelemLista(DateTime.Parse("21/09/2019"), 5, 546, "Extraccion"));
            lista.InsertarFinal(new TelemLista(DateTime.Parse("22/10/2019"), 6, 89, "Deposito"));

            Mostrar();
        }
        private void Mostrar()
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= lista.Cantidad(); i++)
            {
                listBox1.Items.Add(lista.BuscarPorPosicion(i).toString());
            }
            label1.Text = $"Depositos: {lista.DepositosEntreFechas(dateTimePicker1.Value, dateTimePicker2.Value)}";
            label2.Text = $"Depositos: $ {lista.DepositosEnAnio(dateTimePicker3.Value)}";
            label3.Text = $"Extracciones: $ {lista.ExtraccionesEnAnio(dateTimePicker3.Value)}";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
