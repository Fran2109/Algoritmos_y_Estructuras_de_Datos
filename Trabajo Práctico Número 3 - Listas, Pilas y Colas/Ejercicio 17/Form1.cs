using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_17
{
    public partial class Form1 : Form
    {
        Cola colaPares, colaImpares;
        int id = 0, interval = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colaPares = new Cola();
            colaImpares = new Cola();
            timer1.Start();
            Mostrar(listBox1, colaPares, label1, label3);
            Mostrar(listBox2, colaImpares, label2, label4);
        }
        private void Mostrar(ListBox listBox, Cola cola, Label label, Label label2)
        {
            listBox.Items.Clear();
            Cola aux = new Cola();
            int cant = 0;
            int tiempo = 0;
            while(cola.Ver() != null)
            {
                Nodo nodo = cola.Desencolar();
                listBox.Items.Insert(0, $"{nodo.Id}: {nodo.Paginas}");
                aux.Encolar(nodo);
                cant++;
                tiempo += nodo.Paginas * interval;
            }
            while (aux.Ver() != null)
            {
                cola.Encolar(aux.Desencolar());
            }
            label.Text = $"Pendientes: {cant}";
            label2.Text = $"Tiempo restante: {tiempo/1000} segs";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            colaPares.Desencolar();
            if (colaPares.Ver() != null)
            {
                timer2.Interval = colaPares.Ver().Paginas * interval;
            }
            else
            {
                timer2.Stop();
            }
            Mostrar(listBox1, colaPares, label1, label3);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            colaImpares.Desencolar();
            if(colaImpares.Ver() != null)
            {
                timer3.Interval = colaImpares.Ver().Paginas * interval;
            }
            else
            {
                timer3.Stop();
            }
            Mostrar(listBox2, colaImpares, label2, label4);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int valor = ran.Next(1, 11);
            id++;
            if (valor % 2 == 0)
            {
                if (colaPares.Ver() == null)
                {
                    timer2.Start();
                }
                colaPares.Encolar(id, valor);
                Mostrar(listBox1, colaPares, label1, label3);
            }
            else
            {
                if(colaImpares.Ver() == null)
                {
                    timer3.Start();
                }
                colaImpares.Encolar(id, valor);
                Mostrar(listBox2, colaImpares, label2, label4);
            }
        }
    }
}
