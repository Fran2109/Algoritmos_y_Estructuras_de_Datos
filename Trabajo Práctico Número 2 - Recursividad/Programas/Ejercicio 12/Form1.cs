using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_12
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
                label1.Text = f(int.Parse(textBox1.Text)).ToString();
            } catch (Exception err) { }
        }
        public int f(int x)
        {
            if (x > 100) { return (x - 10); }
            else { return (f(f(x + 11))); }
        }
    }
}
