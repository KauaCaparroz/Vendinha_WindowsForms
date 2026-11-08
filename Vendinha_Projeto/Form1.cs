
using Microsoft.EntityFrameworkCore;
using Projeto_Vendinha;
using Projeto_Vendinha.Data;
using Projeto_Vendinha.Models;

namespace Vendinha_Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            if (!DateTime.TryParse(textDATADENASCIMENTO.Text, out DateTime nascimento)
                || nascimento.Date > DateTime.Today)
            {
                MessageBox.Show("Data de nascimento inválida!");
                return;
            }

            if (!string.IsNullOrWhiteSpace(textEMAIL.Text))
            {
                if (!System.Net.Mail.MailAddress.TryCreate(textEMAIL.Text, out var email)
                    || email.Address != textEMAIL.Text
                    || !email.Host.Contains('.'))
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

                var cliente = new Cliente
                {
                    NomeCompleto = textNome.Text.Trim(),
                    CPF = cpf,
                    DataNascimento = nascimento,
                    Email = string.IsNullOrWhiteSpace(textEMAIL.Text)
                        ? null
                        : textEMAIL.Text.Trim()
                };

                banco.Clientes.Add(cliente);
                banco.SaveChanges();

                MessageBox.Show("Cliente cadastrado com sucesso!");

                textNome.Clear();
                textCPF.Clear();
                textDATADENASCIMENTO.Clear();
                textEMAIL.Clear();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
