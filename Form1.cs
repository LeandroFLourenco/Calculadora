using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Cadastramento
{
    public partial class Calculadora : Form
    {
        double numAnterior = 0;
        string operacao = "";
        bool limparDisplay = false;

        public Calculadora()
        {
            InitializeComponent();
        }
        private void leituraBotoes(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            if (botao != null)
            {
                tbConta.Text += botao.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbConta.Text, out numAnterior))
            {
                operacao = "+";

            }
        }

        private void tbConta_Enter(object sender, EventArgs e)
        {
            if (tbConta.Text == "Conta")
            {
                tbConta.Text = "";
                tbConta.ForeColor = Color.Black;  // texto normal
            }
        }

        private void tbConta_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbConta.Text))
            {
                tbConta.Text = "Conta";
                tbConta.ForeColor = Color.Gray;  // cor de placeholder
            }
        }

        private void tbConta_TextChanged(object sender, EventArgs e)
        {
            // Se o texto for diferente de "conta" e o TextBox está cinza, limpa o placeholder
            if (tbConta.ForeColor == Color.Gray && tbConta.Text != "Conta")
            {
                tbConta.ForeColor = Color.Black;
                tbConta.Text = tbConta.Text.Substring(tbConta.Text.Length - 1);  // mantém só a tecla digitada
                tbConta.SelectionStart = tbConta.Text.Length;  // posiciona o cursor no final
            }

            // Se o TextBox ficar vazio, volta o placeholder (isso será tratado no Leave)
        }
    }
}
