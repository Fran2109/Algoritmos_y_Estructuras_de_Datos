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

namespace Ejercicio_11
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
                Double number = Double.Parse(Interaction.InputBox("Numero"));
                string numberS = number.ToString();
                for(int i = numberS.Length; i > 0; i--)
                {
                    pilaOrg.Apilar(int.Parse(numberS[i-1].ToString()));
                }
                Pila aux = new Pila();
                while (pilaOrg.Ver() != null)
                {
                    Nodo nodo = pilaOrg.Desapilar();
                    aux.Apilar(nodo.Id);
                    pilaNew.Apilar(nodo.Id);
                }
                while(aux.Ver() != null)
                {
                    pilaOrg.Apilar(aux.Desapilar().Id);
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
                listBox.Items.Add(aux.Ver().Id.ToString());
            }
            while (aux.Ver() != null)
            {
                pila.Apilar(aux.Desapilar());
            }
        }
    }
}
