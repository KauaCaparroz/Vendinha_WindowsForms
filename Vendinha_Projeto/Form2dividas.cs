
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projeto_Vendinha;

namespace Vendinha_ProjetoWindowsForms
{
    public partial class Form2dividas : Form
    {
        private readonly ServicoDividas servicoDividas = new ServicoDividas();

        public Form2dividas()
        {
            InitializeComponent();

            btnCadastrarDivida.Click += btnCadastrarDivida_Click;
            btnConsultarDividas.Click += btnConsultarDividas_Click;
            btnPagarDivida.Click += btnPagarDivida_Click;

            gridDividas.ReadOnly = true;
            gridDividas.AllowUserToAddRows = false;
            gridDividas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCadastrarDivida_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(idcliente.Text, out int clienteId))
            {
                MessageBox.Show("Digite um ID de cliente válido.");
                return;
            }

            if (!decimal.TryParse(valordivida.Text, out decimal valor))
            {
                MessageBox.Show("Digite um valor de dívida válido.");
                return;
            }

            string mensagem = servicoDividas.CadastrarDivida(clienteId, valor);
            MessageBox.Show(mensagem);

            ConsultarDividasNaTabela();
        }

        private void btnConsultarDividas_Click(object sender, EventArgs e)
        {
            ConsultarDividasNaTabela();
        }

        private void btnPagarDivida_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(iddivida.Text, out int dividaId))
            {
                MessageBox.Show("Digite um ID de dívida válido.");
                return;
            }

            string mensagem = servicoDividas.PagarDivida(dividaId);
            MessageBox.Show(mensagem);

            if (int.TryParse(idcliente.Text, out int clienteId))
            {
                ConsultarDividasNaTabela();
            }
        }

        private void ConsultarDividasNaTabela()
        {
            if (!int.TryParse(idcliente.Text, out int clienteId))
            {
                MessageBox.Show("Digite o ID do cliente para consultar as dívidas.");
                return;
            }

            var dividas = servicoDividas.ConsultarDividas(clienteId);

            gridDividas.Rows.Clear();

            foreach (var divida in dividas)
            {
                gridDividas.Rows.Add(
                    divida.Id,
                    divida.ClienteId,
                    divida.Valor,
                    divida.DataCriacao.ToString("dd/MM/yyyy"),
                    divida.Paga ? "Sim" : "Não"
                );
            }

            if (dividas.Count == 0)
            {
                MessageBox.Show("Nenhuma dívida encontrada para esse cliente.");
            }
        }

        private void Form2dividas_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
