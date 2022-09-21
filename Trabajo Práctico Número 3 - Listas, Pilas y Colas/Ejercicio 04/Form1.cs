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

namespace Ejercicio_04
{
    public partial class Form1 : Form
    {
        ListaCDE listaCDE;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaCDE = new ListaCDE();
            listaCDE.AgregarFinal("1");
            listaCDE.AgregarFinal("2");
            listaCDE.AgregarFinal("3");
            listaCDE.AgregarFinal("4");
            listaCDE.AgregarFinal("5");
            Mostrar();
        }
        private void Mostrar()
        {
            listBox1.Items.Clear();
            int c = listaCDE.Cantidad();
            if (c > 0)
            {
                for (int x = 1; x <= c; x++)
                {
                    listBox1.Items.Add(listaCDE.BuscarPorPosicion(x).Id);
                }
            }
            label1.Text = $"Cantidad de Elementos: {listaCDE.Cantidad()}";
            listaCDE.RecorrerInversa(listBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listaCDE.AgregarFinal(Interaction.InputBox("Agregar al Final"));
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listaCDE.AgregarInicio(Interaction.InputBox("Agregar al Inicio"));
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listaCDE.AgregarMedio(Interaction.InputBox($"Agregar en posicion: {numericUpDown1.Value}"), int.Parse(numericUpDown1.Value.ToString()));
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listaCDE.BorrarFinal();
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                listaCDE.BorrarInicio();
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                listaCDE.BorrarMedio(int.Parse(numericUpDown2.Value.ToString()));
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }
    }
}
