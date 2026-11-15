
using System;
using System.Windows.Forms;
using Projeto_Vendinha;

namespace Vendinha_ProjetoWindowsForms
{
    public partial class Form3Clientes : Form
    {
        private ServicoClientes servico = new ServicoClientes();
        private int pagina = 1;

        public Form3Clientes()
        {
            InitializeComponent();

            btnPesquisar.Click -= btnPesquisar_Click;
            btnPesquisar.Click += btnPesquisar_Click;

            btnAnterior.Click += btnAnterior_Click;
            btnProximo.Click += btnProximo_Click;

            gridClientes.ReadOnly = true;
            gridClientes.AllowUserToAddRows = false;

            MostrarClientes();
        }

        private void MostrarClientes()
        {
            string nome = textPesquisa.Text.Trim();

            var clientes = servico.ConsultarClientes(nome, pagina);

            gridClientes.Rows.Clear();

            foreach (var cliente in clientes)
            {
                decimal totalDevido = cliente.Dividas
                    .Where(d => !d.Paga)
                    .Sum(d => d.Valor);

                gridClientes.Rows.Add(
                    cliente.Id,
                    cliente.NomeCompleto,
                    cliente.Idade,
                    totalDevido.ToString("C")
                );
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pagina = 1;
            MostrarClientes();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (pagina > 1)
            {
                pagina--;
                MostrarClientes();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            int totalClientes = servico.ContarClientes(textPesquisa.Text.Trim());

            if (pagina * 10 < totalClientes)
            {
                pagina++;
                MostrarClientes();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3Clientes_Load(object sender, EventArgs e)
        {

        }

        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

