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
        char[,] matriz;
        int i, j;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matriz = new char[5, 5];
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = ' ';
                }
            }
            i = 0;
            for (j = 0; j < matriz.GetLength(0); j++)
            {
                matriz[i, j] = '*';
                if(j<2)
                {
                    i++;
                }
                else
                {
                    i--;
                }
            }
            string resultado = "";
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
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
