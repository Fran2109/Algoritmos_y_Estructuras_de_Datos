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

namespace Ejercicio_01
{
    public partial class Form1 : Form
    {
        ListaSE listaSE;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaSE = new ListaSE();
            listaSE.AgregarFinal("1");
            listaSE.AgregarFinal("2");
            listaSE.AgregarFinal("3");
            Mostrar();
        }
        private void Mostrar()
        {
            listBox1.Items.Clear();
            int c = listaSE.Cantidad();
            if (c > 0)
            {
                for (int x = 1; x <= c; x++)
                {
                    listBox1.Items.Add(listaSE.BuscarPorPosicion(x).Id);
                }
            }
            label1.Text = $"Cantidad de Elementos: {listaSE.Cantidad()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listaSE.AgregarFinal(Interaction.InputBox("Agregar al Final"));
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listaSE.AgregarInicio(Interaction.InputBox("Agregar al Inicio"));
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listaSE.AgregarMedio(Interaction.InputBox($"Agregar en posicion: {numericUpDown1.Value}"), int.Parse(numericUpDown1.Value.ToString()));
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listaSE.BorrarFinal();
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                listaSE.BorrarInicio();
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                listaSE.BorrarMedio(int.Parse(numericUpDown2.Value.ToString()));
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                listaSE.IntercambiarD(int.Parse(numericUpDown3.Value.ToString()));
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                listaSE.IntercambiarI(int.Parse(numericUpDown4.Value.ToString()));
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }
    }
}
