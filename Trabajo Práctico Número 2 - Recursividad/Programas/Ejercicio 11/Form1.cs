using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_11
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
                if(palindromo(textBox1.Text))
                {
                    label1.Text = "Es un Palindromo";
                } else
                {
                    label1.Text = "No es Palindromo";
                }
            } catch(Exception err) { }
        }
        public bool palindromo(string p, int i = 0)
        {
            if(i == p.Length) {
                return true;
            } else if (p[i] == p[p.Length - 1 - i]) {
                return palindromo(p, i + 1);
            } else {
                return false;
            }
        }
    }
}
