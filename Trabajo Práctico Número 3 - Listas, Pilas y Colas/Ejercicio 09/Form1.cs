using Microsoft.VisualBasic;
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
        Pila pila;
        public Form1()
        {
            InitializeComponent();
        }
        private void Mostrar(Pila pila, ListBox listBox)
        {
            Pila aux = new Pila();
            listBox.Items.Clear();
            while (pila.Ver() != null)
            {
                aux.Apilar(pila.Desapilar());
                listBox.Items.Add(aux.Ver().Id.ToString());
            }
            while (aux.Ver() != null)
            {
                pila.Apilar(aux.Desapilar());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pila.Apilar(int.Parse(Interaction.InputBox("Apilar")));
                Mostrar(pila, listBox1);
            } catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(pila.Desapilar().Id.ToString());
                Mostrar(pila, listBox1);
            } catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(pila.Ver().Id.ToString());
            } catch (Exception err) { MessageBox.Show(err.Message); }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pila = new Pila();
            Mostrar(pila, listBox1);
        }
    }
}
