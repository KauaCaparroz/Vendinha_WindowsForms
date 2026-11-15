
using Microsoft.EntityFrameworkCore;
using Projeto_Vendinha.Data;
using Projeto_Vendinha.Models;

namespace Projeto_Vendinha
{
    public class ServicoClientes
    {
        private VendinhaContext CriarBanco()
        {
            var opcoes = new DbContextOptionsBuilder<VendinhaContext>()
                .UseSqlite("Data Source=vendinha.db")
                .Options;

            return new VendinhaContext(opcoes);
        }

        public List<Cliente> ConsultarClientes(string nome = "", int pagina = 1)
        {
            using (var banco = CriarBanco())
            {
                var clientes = banco.Clientes
                    .Include(c => c.Dividas)
                    .Where(c => c.NomeCompleto.Contains(nome))
                    .ToList();

                clientes = clientes
                    .OrderByDescending(c => c.Dividas.Where(d => !d.Paga).Sum(d => d.Valor))
                    .ThenBy(c => c.NomeCompleto)
                    .Skip((Math.Max(1, pagina) - 1) * 10)
                    .Take(10)
                    .ToList();

                return clientes;
            }
        }

        public int ContarClientes(string nome = "")
        {
            using (var banco = CriarBanco())
            {
                return banco.Clientes.Count(c => c.NomeCompleto.Contains(nome));
            }
        }

        public Cliente? BuscarCliente(int id)
        {
            using (var banco = CriarBanco())
            {
                return banco.Clientes.Find(id);
            }
        }

        public string EditarCliente(int id, string nome, string cpf,
            DateTime nascimento, string email)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return "O nome é obrigatório!";

            if (!ValidadorCPF.Validar(cpf))
                return "CPF inválido!";

            if (nascimento > DateTime.Today)
                return "A data de nascimento não pode ser futura!";

            email = email.Trim();

            if (email != "")
            {
                bool valido = System.Net.Mail.MailAddress.TryCreate(email, out var endereco);

                if (!valido || endereco == null ||
                    endereco.Address != email || !endereco.Host.Contains('.'))
                    return "Email inválido!";
            }

            cpf = cpf.Replace(".", "").Replace("-", "").Trim();

            using (var banco = CriarBanco())
            {
                var cliente = banco.Clientes.Find(id);

                if (cliente == null)
                    return "Cliente não encontrado.";

                if (banco.Clientes.Any(c => c.CPF == cpf && c.Id != id))
                    return "Esse CPF já está cadastrado!";

                cliente.NomeCompleto = nome.Trim();
                cliente.CPF = cpf;
                cliente.DataNascimento = nascimento;
                cliente.Email = email == "" ? null : email;

                banco.SaveChanges();

                return "Cliente editado com sucesso!";
            }
        }

        public string ExcluirCliente(int id)
        {
            using (var banco = CriarBanco())
            {
                var cliente = banco.Clientes
                    .Include(c => c.Dividas)
                    .FirstOrDefault(c => c.Id == id);

                if (cliente == null)
                    return "Cliente não encontrado.";

                banco.Dividas.RemoveRange(cliente.Dividas);
                banco.Clientes.Remove(cliente);
                banco.SaveChanges();

                return "Cliente excluído com sucesso!";
            }
        }
    }
}
