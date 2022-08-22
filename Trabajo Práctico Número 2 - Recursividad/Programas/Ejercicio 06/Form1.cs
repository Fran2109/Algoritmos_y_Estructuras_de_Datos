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

namespace Ejercicio_06
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
                if (int.TryParse(textBox1.Text, out int n))
                {
                    label1.Text = sumaPares(n).ToString();
                }
                else
                {
                    label1.Text = "0";
                }
            }
            catch (Exception err) { MessageBox.Show(err.Message); }

        }

        public int sumaPares(int n)
        {
            if (n % 2 == 1)
            {
                throw new Exception("Ingrese un Numero Par");
            }
            else if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + sumaPares(n - 2);
            }
        }
    }
}
