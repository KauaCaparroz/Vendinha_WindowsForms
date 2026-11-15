
using Microsoft.EntityFrameworkCore;
using Projeto_Vendinha;
using Projeto_Vendinha.Data;
using Projeto_Vendinha.Models;
using Vendinha_ProjetoWindowsForms;

namespace Vendinha_Projeto
{
    public partial class Form1Cadastro : Form
    {
        public Form1Cadastro()
        {
            InitializeComponent();

            btnGerenciarDividas.Click -= btnGerenciarDividas_Click;
            btnGerenciarDividas.Click += btnGerenciarDividas_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNome.Text))
            {
                MessageBox.Show("O nome é obrigatório!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textCPF.Text))
            {
                MessageBox.Show("O CPF é obrigatório!");
                return;
            }

            if (!ValidadorCPF.Validar(textCPF.Text))
            {
                MessageBox.Show("CPF inválido!");
                return;
            }

            DateTime nascimento = dtpNascimento.Value.Date;

            if (nascimento > DateTime.Today)
            {
                MessageBox.Show("A data de nascimento não pode ser futura!");
                return;
            }

            string email = textEMAIL.Text.Trim();

            if (email != "")
            {
                bool emailValido = System.Net.Mail.MailAddress.TryCreate(email, out var endereco);

                if (!emailValido || endereco == null || endereco.Address != email || !endereco.Host.Contains('.'))
                {
                    MessageBox.Show("Email inválido!");
                    return;
                }
            }

            var opcoes = new DbContextOptionsBuilder<VendinhaContext>()
                .UseSqlite("Data Source=vendinha.db")
                .Options;

            using (var banco = new VendinhaContext(opcoes))
            {
                string cpf = textCPF.Text.Replace(".", "").Replace("-", "").Trim();

                if (banco.Clientes.Any(c => c.CPF == cpf))
                {
                    MessageBox.Show("Esse CPF já está cadastrado!");
                    return;
                }

                Cliente cliente = new Cliente();

                cliente.NomeCompleto = textNome.Text.Trim();
                cliente.CPF = cpf;
                cliente.DataNascimento = nascimento;
                cliente.Email = email == "" ? null : email;

                banco.Clientes.Add(cliente);
                banco.SaveChanges();

                MessageBox.Show("Cliente cadastrado com sucesso!");

                textNome.Clear();
                textCPF.Clear();
                textEMAIL.Clear();
                dtpNascimento.Value = DateTime.Today;
            }
        }

        private void btnGerenciarDividas_Click(object sender, EventArgs e)
        {
            Form2dividas telaDividas = new Form2dividas();
            telaDividas.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textDATADENASCIMENTO_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
