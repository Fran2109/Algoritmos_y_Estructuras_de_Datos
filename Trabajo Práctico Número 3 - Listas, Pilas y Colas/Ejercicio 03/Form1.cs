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

namespace Ejercicio_03
{
    public partial class Form1 : Form
    {
        ListaCSE listaCSE;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaCSE = new ListaCSE();
            listaCSE.AgregarFinal("1");
            listaCSE.AgregarFinal("2");
            listaCSE.AgregarFinal("3");
            listaCSE.AgregarFinal("4");
            listaCSE.AgregarFinal("5");
            Mostrar();
        }
        private void Mostrar()
        {
            listBox1.Items.Clear();
            int c = listaCSE.Cantidad();
            if (c > 0)
            {
                for (int x = 1; x <= c; x++)
                {
                    listBox1.Items.Add(listaCSE.BuscarPorPosicion(x).Id);
                }
            }
            label1.Text = $"Cantidad de Elementos: {listaCSE.Cantidad()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listaCSE.AgregarFinal(Interaction.InputBox("Agregar al Final"));
                Mostrar();
            }catch(Exception err) { MessageBox.Show(err.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listaCSE.AgregarInicio(Interaction.InputBox("Agregar al Inicio"));
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listaCSE.AgregarMedio(Interaction.InputBox($"Agregar en posicion: {numericUpDown1.Value}"), int.Parse(numericUpDown1.Value.ToString()));
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listaCSE.BorrarFinal();
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                listaCSE.BorrarInicio();
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                listaCSE.BorrarMedio(int.Parse(numericUpDown2.Value.ToString()));
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }
    }
}
