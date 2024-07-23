using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculadora : Form
    {
        double total, ultimonumero;
        string operador;
        
        private void Limpar()
        {
            total = 0;
            ultimonumero = 0;
            operador = "+";
            txtresult.Text = "0";
        }
        private void Calcular()
        {
            switch (operador)
            {
                case "+": total = total + ultimonumero;
                    break;
                case "-":total = total - ultimonumero;
                    break;
                case "x":total = total * ultimonumero;
                    break;
                case "/":total = total / ultimonumero;
                    break;
            }
            ultimonumero = 0;
            txtresult.Text = total.ToString();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void gerarnumero(object sender, EventArgs e)
        {
            if (ultimonumero == 0)
            {
                txtresult.Text = (sender as Button).Text;
            }
            else
            {
                txtresult.Text = txtresult.Text + (sender as Button).Text;
            }
            ultimonumero = Convert.ToDouble(txtresult.Text);
        }

        private void operadores(object sender, EventArgs e)
        {
            ultimonumero = Convert.ToDouble(txtresult.Text);
            Calcular();
            operador = (sender as Button).Text;
        }

        private void btresult_Click(object sender, EventArgs e)
        {
            ultimonumero = Convert.ToDouble(txtresult.Text);
            Calcular();
            operador = "+";
            total = 0;
        }


        public Calculadora()
        {
            InitializeComponent();
            Limpar();
        }

        private void fechar_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Desejas sair da aplicação?","Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
           Application.Exit();
        }

       
       

    }
}
