
using System;
using System.Linq;
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
            gridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridClientes.MultiSelect = false;

            MostrarClientes();
        }

        private void MostrarClientes()
        {
            var clientes = servico.ConsultarClientes(textPesquisa.Text.Trim(), pagina);

            gridClientes.Rows.Clear();

            foreach (var cliente in clientes)
            {
                decimal total = cliente.Dividas
                    .Where(d => !d.Paga)
                    .Sum(d => d.Valor);

                gridClientes.Rows.Add(
                    cliente.Id,
                    cliente.NomeCompleto,
                    cliente.Idade,
                    total.ToString("C")
                );
            }

            gridClientes.ClearSelection();
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
            int total = servico.ContarClientes(textPesquisa.Text.Trim());

            if (pagina * 10 < total)
            {
                pagina++;
                MostrarClientes();
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (gridClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente.");
                return;
            }

            int id = Convert.ToInt32(gridClientes.SelectedRows[0].Cells[0].Value);
            var cliente = servico.BuscarCliente(id);

            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado.");
                return;
            }

            string nome = Microsoft.VisualBasic.Interaction.InputBox(
                "Nome completo:", "Editar Cliente", cliente.NomeCompleto);

            if (nome.Trim() == "")
                return;

            string cpf = Microsoft.VisualBasic.Interaction.InputBox(
                "CPF:", "Editar Cliente", cliente.CPF);

            if (cpf.Trim() == "")
                return;

            string data = Microsoft.VisualBasic.Interaction.InputBox(
                "Data de nascimento (dd/MM/aaaa):",
                "Editar Cliente",
                cliente.DataNascimento.ToString("dd/MM/yyyy"));

            if (!DateTime.TryParseExact(
                data, "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime nascimento))
            {
                MessageBox.Show("Data inválida!");
                return;
            }

            string email = Microsoft.VisualBasic.Interaction.InputBox(
                "Email (opcional):", "Editar Cliente", cliente.Email ?? "");

            string mensagem = servico.EditarCliente(id, nome, cpf, nascimento, email);

            MessageBox.Show(mensagem);
            MostrarClientes();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (gridClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente.");
                return;
            }

            int id = Convert.ToInt32(gridClientes.SelectedRows[0].Cells[0].Value);

            DialogResult resposta = MessageBox.Show(
                "Deseja excluir este cliente?",
                "Excluir Cliente",
                MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show(servico.ExcluirCliente(id));

                if (pagina > 1 &&
                    servico.ConsultarClientes(textPesquisa.Text.Trim(), pagina).Count == 0)
                {
                    pagina--;
                }

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
