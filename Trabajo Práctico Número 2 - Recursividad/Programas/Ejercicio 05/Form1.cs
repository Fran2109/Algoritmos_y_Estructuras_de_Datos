using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_05
{
    public partial class Form1 : Form
    {
        int d, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                c = int.Parse(textBox1.Text);
                label1.Text = SumaHasta(c, d).ToString();
            } catch(Exception) { d = 0; }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                d = int.Parse(textBox2.Text);
                label1.Text = SumaHasta(c, d).ToString();
            }
            catch (Exception) { c = 0; }
        }
        public int SumaHasta(int c, int d)
        {
            if (c == 0)
                return 0;
            else
                return d + c - 1 + SumaHasta(c - 1, d);
        }
    }
}
