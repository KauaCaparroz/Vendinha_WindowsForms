
using Microsoft.EntityFrameworkCore;
using Projeto_Vendinha.Data;
using Projeto_Vendinha.Models;

namespace Projeto_Vendinha
{
    public class ServicoClientes
    {
        public List<Cliente> ConsultarClientes()
        {
            var opcoes = new DbContextOptionsBuilder<VendinhaContext>()
                .UseSqlite("Data Source=vendinha.db")
                .Options;

            using (var banco = new VendinhaContext(opcoes))
            {
                return banco.Clientes.ToList();
            }
        }
    }
}
