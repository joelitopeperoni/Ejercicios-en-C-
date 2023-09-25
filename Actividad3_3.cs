using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoWindowsForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valor1 = Convert.ToBoolean(textBox1.Text);
            bool valor2 = Convert.ToBoolean(textBox2.Text);
            bool valor3 = Convert.ToBoolean(textBox3.Text);


            bool resultadoAND = valor1 && valor2 && valor3;
            bool resultadoOR = valor1 || valor2 || valor3;


            label1.Text = "AND: " + resultadoAND.ToString();
            label2.Text = "OR: " + resultadoOR.ToString();
        }
    }
}
