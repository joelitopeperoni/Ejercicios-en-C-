using System;
using System.Windows.Forms;

namespace ProyectoWindowsForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                double discriminante = b * b - 4 * a * c;

                if (discriminante < 0)
                {
                    label1.Text = "No tiene soluciones reales";
                }
                else if (discriminante == 0)
                {
                    double x = -b / (2 * a);
                    label1.Text = $"Raíz doble: x = {x}";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                    label1.Text = $"Raíces: x1 = {x1}, x2 = {x2}";
                }
            }

    }
}
