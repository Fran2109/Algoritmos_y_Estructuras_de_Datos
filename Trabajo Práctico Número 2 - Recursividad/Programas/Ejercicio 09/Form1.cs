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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(int.TryParse(textBox1.Text, out int n))
                {
                    label1.Text = convertir(n);
                }
            }
            catch (Exception err) { }
        }
        public string convertir(int n)
        {
            if (n == 0)
            {
                return "";
            } else if(n % 2 == 0)
            {
                return $"{convertir(n/2)}0";
            }
            else
            {
                return $"{convertir((n-1)/2)}1";
            }
        }
    }
}
