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

namespace Ejercicio_02
{
    public partial class Form1 : Form
    {
        ListaDE listaDe;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaDe = new ListaDE();
            listaDe.AgregarFinal("1");
            listaDe.AgregarFinal("2");
            listaDe.AgregarFinal("3");
            listaDe.AgregarFinal("4");
            listaDe.AgregarFinal("5");
            Mostrar();
        }
        private void Mostrar()
        {
            listBox1.Items.Clear();
            int c = listaDe.Cantidad();
            if (c > 0)
            {
                for (int x = 1; x <= c; x++)
                {
                    listBox1.Items.Add(listaDe.BuscarPorPosicion(x).Id);
                }
            }
            listaDe.RecorrerInversa(listBox2);
            label1.Text = $"Cantidad de Elementos: {listaDe.Cantidad()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listaDe.AgregarFinal(Interaction.InputBox("Agregar al Final"));
                Mostrar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listaDe.AgregarInicio(Interaction.InputBox("Agregar al Inicio"));
                Mostrar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listaDe.AgregarMedio(Interaction.InputBox($"Agregar en Posicion: {numericUpDown1.Value}"), int.Parse(numericUpDown1.Value.ToString()));
                Mostrar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listaDe.BorrarFinal();
                Mostrar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                listaDe.BorrarInicio();
                Mostrar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                listaDe.BorrarMedio(int.Parse(numericUpDown2.Value.ToString()));
                Mostrar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                listaDe.IntercambiarD(int.Parse(numericUpDown3.Value.ToString()));
                Mostrar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
