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

namespace Ejercicio_07
{
    public partial class Form1 : Form
    {
        List<char> chars = new List<char>();
        List<int> ints = new List<int>();
        List<string> strings = new List<string>();
        int largo = 10;
        string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < largo; i++)
            {
                chars.Add(characters[random.Next(characters.Length)]);
                ints.Add(random.Next(largo));
            }
            strings = aparear(chars, ints);
            label1.Text = "[ ";
            label2.Text = "[ ";
            label3.Text = "[ ";
            for (int i = 0; i < largo-1; i++)
            {
                label1.Text += $"{chars[i]}, ";
                label2.Text += $"{ints[i]}, ";
                label3.Text += $"{strings[i]}, ";
            }
            label1.Text += $"{chars[largo-1]} ]";
            label2.Text += $"{ints[largo-1]} ]";
            label3.Text += $"{strings[largo-1]} ]";
        }
        public List<string> aparear(List<char> chars, List<int> ints, int largo = 0, List<string> strings = null)
        {
            strings = strings ?? new List<string>();
            if(largo == chars.Count)
            {
                return strings;
            }
            else
            {
                strings.Add($"({ints[largo]}, '{chars[largo]}')");
                return aparear(chars, ints, largo+1, strings);
            }
        }
    }
}
