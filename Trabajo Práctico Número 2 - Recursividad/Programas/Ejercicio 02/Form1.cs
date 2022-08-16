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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            label1.Text = concat(int.Parse(textBox1.Text));
        }
        public string concat(int n)
        {
            string respuesta = "";
            if (n != 0)
            {
                respuesta += $"{concat(n - 1)}-{n * 2}";
            }
            return respuesta;
        }
    }
}
