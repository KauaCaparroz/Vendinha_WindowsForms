namespace Projeto_Vendinha.Models
{
    public class Divida
    {
        // Identificador da dívida
        public int Id { get; set; }

        public decimal Valor { get; set; }

        public bool Paga { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataPagamento { get; set; }

        public int ClienteId { get; set; }

        // Cliente relacionado à dívida
        public Cliente? Cliente { get; set; }// Permite acessar os dados do cliente relacionado à dívida.
                                             // O ? permite que Cliente seja null quando não estiver carregado.

    }
}