using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Text = mayusculas(textBox1.Text, textBox1.Text.Length - 1);
            }
            catch (Exception err) { }
        }
        public string mayusculas(string m, int p)
        {
            if (p == -1)
            {
                return "";
            }
            else
            {
                return $"{mayusculas(m, p - 1)}{char.ToUpper(m[p])}";
            }
        }
    }
}
