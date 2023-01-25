using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioCalculadoraDavidGuerrero
{
    public partial class Form1 : Form
    {

        double num1 = 0;
        double num2 = 0;
        char operador;

        List<String> operaciones = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }


        private void btnNumbers_Click(object sender, EventArgs e)
        {
            CrearNumero(((Button)sender).Text);


        }

        private void CrearNumero(string text)
        {

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }
            String textoBoton = text.ToString();
            txtResultado.Text += textoBoton;
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            num1 = Double.Parse(txtResultado.Text);
            operador = char.Parse(boton.Text);

            txtResultado.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtResultado.Text);


            if (operador == '+')
            {
                
                String resultado = (num1 + num2).ToString();
                String operacion = num1.ToString() + " + "+ num2.ToString() +": "+ resultado;
                txtResultado.Text = resultado;
                num1 = double.Parse(txtResultado.Text);
                operaciones.Add(operacion);
                historial();
            }
            else if (operador == '-')
            {
                String resultado = (num1 - num2).ToString();
                String operacion = num1.ToString() + " - " + num2.ToString() + ": " + resultado;
                txtResultado.Text = resultado;
                num1 = double.Parse(txtResultado.Text);
                operaciones.Add(operacion);
                historial();
            }
            else if (operador == '/')
            {
                String resultado = (num1 / num2).ToString();
                String operacion = num1.ToString() + " ÷ " + num2.ToString() + ": " + resultado;
                txtResultado.Text = resultado;
                num1 = double.Parse(txtResultado.Text);
                operaciones.Add(operacion);
                historial();
            }
            else if (operador == 'x')
            {
                String resultado = (num1 * num2).ToString();
                String operacion = num1.ToString() + " x " + num2.ToString() + ": " + resultado;
                txtResultado.Text = resultado;
                num1 = double.Parse(txtResultado.Text);
                operaciones.Add(operacion);
                historial();
            }



        }

        private void btnC_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operador = '\0';
            txtResultado.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }

        private void btnCambioSigno_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtResultado.Text);
            num1 *= -1;
            txtResultado.Text = num1.ToString();
        }


        private void historial()
        {
            lvHistorial.Items.Clear();
            foreach (String operacion in operaciones)
            {
                ListViewItem item = new ListViewItem();
                lvHistorial.Items.Add(operacion);
            }
        }
    }
}
