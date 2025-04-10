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
    }
}
