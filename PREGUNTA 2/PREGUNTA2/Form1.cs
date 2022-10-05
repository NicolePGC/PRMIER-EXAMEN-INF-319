using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PREGUNTA2
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void buttoncero_Click(object sender, EventArgs e)
        {
            pantalla.Text= pantalla.Text+"0";
        }

        private void buttondos_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void buttontres_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void buttoncuatro_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void buttoncinco_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void buttonseis_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void buttonssiete_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void buttonocho_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            operacion = "x";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void igual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);
            switch (operacion) { 
                case "+":
                    resultado = primero + segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "x":
                    resultado = primero * segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    pantalla.Text = resultado.ToString();
                    break;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            resultado = 1 / primero;
            pantalla.Text = resultado.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            primero = double.Parse(pantalla.Text);
            resultado = primero*primero;
            pantalla.Text = resultado.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            resultado = Math.Sqrt(primero);
            pantalla.Text = resultado.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }
    }
}
