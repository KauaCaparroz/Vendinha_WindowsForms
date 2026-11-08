
using Microsoft.EntityFrameworkCore;
using Projeto_Vendinha.Data;
using Vendinha_Projeto;

namespace Vendinha_ProjetoWindowsForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Configura o banco de dados SQLite
            var opcoes = new DbContextOptionsBuilder<VendinhaContext>()
                .UseSqlite("Data Source=vendinha.db")
                .Options;

            using (var banco = new VendinhaContext(opcoes))//Vai criar o banco e as tabelas caso ainda não existam
            {
                banco.Database.EnsureCreated();
            }

            Application.Run(new Form1());//Abre a tela principal do programa
        }
    }
}
