using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(textBox1.Text);
                label1.Text = fibonacci(n);
            }
            catch (Exception) { }
        }
        public string fibonacci(int n, int b=0, int c=1)
        {
            if(n == 0)
                return "";
            else 
                return  $"{b}-" + fibonacci(n - 1, c, b+c);
        }
    }
}
