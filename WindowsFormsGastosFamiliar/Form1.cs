using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGastosFamiliar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Entrada de dados

            double Renda = double.Parse(txtRenda.Text);

            double Energia = double.Parse(txtEnergia.Text);
            double Agua = double.Parse(txtAgua.Text);
            double TV = double.Parse(txtTV.Text);
            double Alimentacao = double.Parse(txtAlimentacao.Text);
            double Outros = double.Parse(txtOutros.Text);

            //Processamento

            double Resultado = Renda - (Energia + Agua + TV + Alimentacao + Outros);

            //Saida de dados

            lblGastos.Text = Resultado.ToString();

            //Saldo final

            double saldo = Renda - Resultado;

            lblSaldo.Text = saldo.ToString();


        }
    }
}
