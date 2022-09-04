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

namespace Ejercicio_12
{
    public partial class Form1 : Form
    {
        Pila pilaOrg;
        Pila pilaNew;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                pilaOrg = new Pila();
                pilaNew = new Pila();
                string palabra = Interaction.InputBox("Palabra");
                for (int i = palabra.Length; i > 0; i--)
                {
                    pilaOrg.Apilar(palabra[i - 1]);
                }
                Pila aux = new Pila();
                while (pilaOrg.Ver() != null)
                {
                    Nodo nodo = pilaOrg.Desapilar();
                    aux.Apilar(nodo.Letra);
                    pilaNew.Apilar(nodo.Letra);
                }
                while (aux.Ver() != null)
                {
                    pilaOrg.Apilar(aux.Desapilar().Letra);
                }
                Mostrar(pilaOrg, listBox1);
                Mostrar(pilaNew, listBox2);
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }
        private void Mostrar(Pila pila, ListBox listBox)
        {
            Pila aux = new Pila();
            listBox.Items.Clear();
            while (pila.Ver() != null)
            {
                aux.Apilar(pila.Desapilar());
                listBox.Items.Add(aux.Ver().Letra);
            }
            while (aux.Ver() != null)
            {
                pila.Apilar(aux.Desapilar());
            }
        }

    }
}
