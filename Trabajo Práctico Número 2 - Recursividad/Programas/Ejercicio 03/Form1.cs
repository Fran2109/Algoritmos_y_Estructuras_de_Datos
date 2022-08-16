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
        int n = 0, p = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(textBox1.Text);
                label1.Text = potencia(n, p).ToString();
            } catch (Exception) { }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                p = int.Parse(textBox2.Text);
                label1.Text = potencia(n, p).ToString();
            }
            catch (Exception) { }
        }
        public int potencia(int n, int p)
        {
            if (p == 0)
                return 1;
            else
                return n * potencia(n, p - 1);
        }
    }
}
