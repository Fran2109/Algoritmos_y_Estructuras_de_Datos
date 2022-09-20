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

namespace Ejercicio_05
{
    public partial class Form1 : Form
    {
        Lista lista;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lista = new Lista();
            lista.InsertarFinal(new Persona("Pedro", "Filosi", 11, 40, "Masculino"));
            lista.InsertarFinal(new Persona("Leandro", "Filosi", 17, 120, "Masculino"));
            lista.InsertarFinal(new Persona("Nicolas", "Filosi", 19, 60, "Masculino"));
            lista.InsertarFinal(new Persona("Francisco", "Filosi", 21, 100, "Masculino"));
            Mostrar();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lista.InsertarInicio(new Persona(
                    Interaction.InputBox("Nombre"),
                    Interaction.InputBox("Apellido"),
                    int.Parse(Interaction.InputBox("Edad")),
                    float.Parse(Interaction.InputBox("Peso")),
                    Interaction.InputBox("Sexo")
                ));
                Mostrar();
            } catch(Exception err) { MessageBox.Show(err.Message); }
        }
        private void Mostrar()
        {
            listBox1.Items.Clear();
            for(int i = 1; i <= lista.Cantidad(); i++)
            {
                listBox1.Items.Add(lista.BuscarPorPosicion(i).toString());
            }
            label1.Text = $"Promedio de Edades: {lista.PromedioDeEdades()}";
            label2.Text = $"Promedio de Pesos: {lista.PromedioDePesos()}";
            label3.Text = $"Persona mas Anciana: {lista.PersonaMasAnciana().toString()}";
            label4.Text = $"Persona mas Joven: {lista.PersonaMasJoven().toString()}";
            label5.Text = $"Persona mas Delgada: {lista.PersonaMasDelgada().toString()}";
            label6.Text = $"Persona mas Obesa: {lista.PersonaMasObesa().toString()}";
            label7.Text = $"Cantidad de Personas: {lista.Cantidad()}";
            label8.Text = $"Cantidad de Personas Pesadas: {lista.CantidadPersonasPesadas()}";
            label9.Text = $"Cantidad de Personas Mayores: {lista.CantidadPersonasMayores()}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                lista.InsertarFinal(new Persona(
                    Interaction.InputBox("Nombre"),
                    Interaction.InputBox("Apellido"),
                    int.Parse(Interaction.InputBox("Edad")),
                    float.Parse(Interaction.InputBox("Peso")),
                    Interaction.InputBox("Sexo")
                ));
                Mostrar();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }
    }
}
