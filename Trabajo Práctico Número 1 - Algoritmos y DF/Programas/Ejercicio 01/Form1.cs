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
        char[,] matriz;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matriz = new char[5, 5];
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        matriz[i, j] = '*';
                    } 
                    else
                    {
                        matriz[i, j] = ' ';
                    }
                }
            }
            string resultado = "";
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    resultado += matriz[i, j];
                    if (j == matriz.GetLength(1) - 1)
                    {
                        resultado += Environment.NewLine;
                    }
                }
            }
            textBox1.Text = resultado;
        }
    }
}
