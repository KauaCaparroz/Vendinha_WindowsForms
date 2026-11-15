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
        public Cliente? Cliente { get; set; }// o porque do ? em ciliente é que Permite que os dados completos do cliente fiquem nulos
                                             // quando ainda não forem carregados pelo sistema pois antes de puxar todas as informações do cliente é puxado o id que contem apenas o numero e quem é.
    }
}