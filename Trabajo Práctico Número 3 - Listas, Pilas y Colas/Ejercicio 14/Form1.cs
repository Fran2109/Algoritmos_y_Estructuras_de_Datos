using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_14
{
    public partial class Form1 : Form
    {
        Pila pila1, pila2, pila3;

        private void Form1_Load(object sender, EventArgs e)
        {
            pila1 = new Pila();
            pila2 = new Pila();
            pila3 = new Pila();
            Random ran = new Random();
            for(int i=0; i<30; i++)
            {
                pila1.Apilar(ran.Next(1, 21));
            }
            Pila aux = new Pila();
            while(pila1.Ver() != null)
            {
                aux.Apilar(pila1.Desapilar());
            }
            while(aux.Ver()!=null)
            {
                Nodo nodo = aux.Desapilar();
                pila1.Apilar(nodo.Id);
                if (nodo.Id % 2 == 0) pila2.Apilar(nodo.Id);
                else pila3.Apilar(nodo.Id);
            }
            Mostrar(pila1, listBox1);
            Mostrar(pila2, listBox2);
            Mostrar(pila3, listBox3);
        }

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
    }
}
