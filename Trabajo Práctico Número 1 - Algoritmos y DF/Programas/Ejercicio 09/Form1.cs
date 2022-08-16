using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_09
{
    public partial class Form1 : Form
    {
        int nIn, j, i;
        bool primo;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "";
                nIn = int.Parse(textBox1.Text);
                if (!(nIn > 1)) MessageBox.Show("Ingrese un numero mayor");
                for (i = 2; i < nIn; i++)
                {
                    primo = true;
                    for (j = i - 1; j > 1; j--)
                    {
                        if(i % j == 0)
                            primo = false;
                    }
                    if(primo)
                    {
                        label1.Text += $"{i}-";
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
