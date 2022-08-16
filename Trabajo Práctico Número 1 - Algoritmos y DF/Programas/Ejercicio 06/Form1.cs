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

namespace Ejercicio_06
{
    public partial class Form1 : Form
    {
        int a, b, c, x, y, z;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(Interaction.InputBox("Ingrese el Primer Numero"));
                b = int.Parse(Interaction.InputBox("Ingrese el Segundo Numero"));
                c = int.Parse(Interaction.InputBox("Ingrese el Tercer Numero"));
                if (a < b)
                {
                    if (a < c)
                    {
                        x = a;
                        if(b<c)
                        {
                            y = b;
                            z = c;
                        }
                        else
                        {
                            y = c;
                            z = b;
                        }
                    }
                    else
                    {
                        x = c;
                        y = a;
                        z = b;
                    }
                }
                else
                {
                    if (c < a)
                    {
                        z = a;
                        if(b < c)
                        {
                            y = c;
                            x = b;
                        }
                        else
                        {
                            y = b;
                            x = c;
                        }
                    }
                    else
                    {
                        x = b;
                        y = a;
                        z = c;
                    }
                }
                MessageBox.Show($"El primer numero es {x}");
                MessageBox.Show($"El segundo numero es {y}");
                MessageBox.Show($"El tercer numero es {z}");
            }
            catch (Exception err) 
            {
                MessageBox.Show(err.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
