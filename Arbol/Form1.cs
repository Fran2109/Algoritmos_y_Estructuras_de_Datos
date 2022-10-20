using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol
{
    public partial class Form1 : Form
    {
        Arbol arbol;
        public Form1()
        {
            InitializeComponent();
        }

        public class Arbol
        {
            Nodo centinela;
            public Arbol()
            {
                centinela = null;
            }
            public void llenar()
            {
                Nodo d = new Nodo(new Persona("Pedro", 11, "57489342"));
                Nodo b = new Nodo(new Persona("Nicolas", 19, "37489342"), null, d);
                Nodo e = new Nodo(new Persona("Francisco", 21, "59760435"));
                Nodo f = new Nodo(new Persona("Leandro", 17, "43565434"));
                Nodo c = new Nodo(new Persona("Monica", 47, "43567823"), e, f);
                Nodo a = new Nodo(new Persona("Osvaldo", 51, "324345344"), b, c);
                centinela = a;
            }
            public void mostrar(TreeView treeView)
            {
                treeView.Nodes.Clear();
                recursiva(treeView.Nodes, centinela);
                treeView.ExpandAll();
            }
            private void recursiva(TreeNodeCollection nodes, Nodo nodo)
            {
                if(nodo!= null)
                {
                    nodes.Add(nodo.persona.toString());
                    recursiva(nodes[0].Nodes, nodo.izquierda);
                    recursiva(nodes[nodes.Count-1].Nodes, nodo.derecha);
                }
            }
            public bool buscar(string dni, Label label1)
            {
                List<string> lista = new List<string>();
                amplitud(lista, new List<Nodo>() { centinela });
                label1.Text = String.Join(" - ", lista.ToArray());
                return (lista.Exists(item => item == dni));
            }
            private void amplitud(List<String> nodos, List<Nodo> aux)
            {
                List<Nodo> aux2 = new List<Nodo>();
                foreach (Nodo nodo in aux)
                {
                    nodos.Add(nodo.persona.DNI);
                    if(nodo.izquierda!=null)
                        aux2.Add(nodo.izquierda);
                    if(nodo.derecha!=null)
                        aux2.Add(nodo.derecha);
                }
                if (aux2.Count > 0)
                    amplitud(nodos, aux2);
            }
        }

        public class Nodo
        {
            public Persona persona { get; set; }
            public Nodo izquierda { get; set; }
            public Nodo derecha { get; set; }
            public Nodo(Persona per, Nodo iz = null, Nodo der = null)
            {
                persona = per;
                izquierda = iz;
                derecha = der;
            }
        }
        public class Persona
        {
            public string Name { get; set; }
            public int Edad { get; set; }
            public string DNI { get; set; }
            public Persona(string name = "", int edad=0, string dni = "")
            {
                Name = name;
                Edad = edad;
                DNI = dni;
            }
            public string toString()
            {
                return $"{DNI}: {Name}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arbol = new Arbol();
            arbol.llenar();
            arbol.mostrar(treeView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = arbol.buscar(textBox1.Text, label1)? "El DNI Existe" : "El DNI no Existe";
        }
    }
}
