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
        int nIn, j, i, x;
        bool primo;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                x = 0;
                label1.Text = "";
                nIn = int.Parse(textBox1.Text);
                for (i = 2; x < nIn; i++)
                {
                    primo = true;
                    for (j = i - 1; j > 1; j--)
                    {
                        if (i % j == 0)
                            primo = false;
                    }
                    if (primo)
                    {
                        x++;
                        label1.Text += $"{i}-";
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
