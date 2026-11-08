
using Microsoft.EntityFrameworkCore;
using Projeto_Vendinha.Data;
using Projeto_Vendinha.Models;

namespace Projeto_Vendinha
{
    public class ServicoDividas
    {
        private VendinhaContext CriarBanco()
        {
            var opcoes = new DbContextOptionsBuilder<VendinhaContext>()
                .UseSqlite("Data Source=vendinha.db")
                .Options;

            return new VendinhaContext(opcoes);
        }

        public string CadastrarDivida(int clienteId, decimal valor)
        {
            if (valor <= 0)
            {
                return "O valor da dívida deve ser maior que zero.";
            }

            using (var banco = CriarBanco())
            {
                if (!banco.Clientes.Any(c => c.Id == clienteId))
                {
                    return "Cliente não encontrado.";
                }

                if (banco.Dividas.Any(d => d.ClienteId == clienteId && !d.Paga))
                {
                    return "Esse cliente já possui uma dívida em aberto.";
                }

                var divida = new Divida
                {
                    ClienteId = clienteId,
                    Valor = valor,
                    Paga = false,
                    DataCriacao = DateTime.Now,
                    DataPagamento = null
                };

                banco.Dividas.Add(divida);
                banco.SaveChanges();

                return "Dívida cadastrada com sucesso!";
            }
        }

        public List<Divida> ConsultarDividas(int clienteId)
        {
            using (var banco = CriarBanco())
            {
                return banco.Dividas
                    .Where(d => d.ClienteId == clienteId)
                    .OrderByDescending(d => d.DataCriacao)
                    .ToList();
            }
        }

        public string PagarDivida(int dividaId)
        {
            using (var banco = CriarBanco())
            {
                var divida = banco.Dividas.Find(dividaId);

                if (divida == null)
                {
                    return "Dívida não encontrada.";
                }

                if (divida.Paga)
                {
                    return "Essa dívida já foi paga.";
                }

                divida.Paga = true;
                divida.DataPagamento = DateTime.Now;

                banco.SaveChanges();

                return "Dívida paga com sucesso!";
            }
        }
    }
}

