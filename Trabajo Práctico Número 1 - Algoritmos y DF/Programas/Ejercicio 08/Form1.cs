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
        int n, a, b, c, x;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "";
                n = int.Parse(textBox1.Text);
                a = 0;
                b = 0;
                c = 0;
                x= 0;
                label1.Text += $"{c}";
                c = 1;
                x++;
                while (x < n)
                {
                    label1.Text += $"-{c}";
                    a = b;
                    b = c;
                    c = a + b;
                    x++;
                }
            }
            catch (Exception) { }
        }
    }
}
