using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10
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
                label1.Text = "";
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (textBox1.Text[i] != '0' && textBox1.Text[i] != '1')
                    {
                        throw new Exception("Lo Ingresado no es Binario.");
                    }
                }
                label1.Text = convertir(textBox1.Text).ToString();
            }
            catch (Exception err) { label1.Text = err.Message; };
        }
        public int convertir(string b, int i = 0)
        {
            if (i == b.Length)
            {
                return 0;
            }
            else
            {
                return (int)(int.Parse(b[b.Length - i - 1].ToString()) * Math.Pow(2, i) + convertir(b, i + 1));
            }
        }
    }
}
