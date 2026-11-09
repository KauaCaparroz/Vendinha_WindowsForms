
using Microsoft.EntityFrameworkCore;
using Projeto_Vendinha.Data;
using Projeto_Vendinha.Models;

namespace Projeto_Vendinha
{
    public class ServicoClientes
    {
        public List<Cliente> ConsultarClientes(string nome = "", int pagina = 1)
        {
            var opcoes = new DbContextOptionsBuilder<VendinhaContext>()
                .UseSqlite("Data Source=vendinha.db")
                .Options;

            using (var banco = new VendinhaContext(opcoes))
            {
                return banco.Clientes
                    .Include(c => c.Dividas)
                    .Where(c => c.NomeCompleto.Contains(nome))
                    .ToList()
                    .OrderByDescending(c => c.Dividas
                        .Where(d => !d.Paga)
                        .Sum(d => d.Valor))
                    .ThenBy(c => c.NomeCompleto)
                    .Skip((Math.Max(1, pagina) - 1) * 10)
                    .Take(10)
                    .ToList();
            }
        }
    }
}
