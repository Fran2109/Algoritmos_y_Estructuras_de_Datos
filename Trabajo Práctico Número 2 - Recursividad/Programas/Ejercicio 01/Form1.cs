﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            label1.Text = sumar(int.Parse(textBox1.Text)).ToString();
        }
        public int sumar(int n)
        {
            if (n == 0)
                return 0;
            else
                return n - 1 + sumar(n - 1);
        }
    }
}
