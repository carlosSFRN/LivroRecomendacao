namespace LivroRecomendacao.Models
{
    public class Favorito
    {
        public int Id { get; set; }
        public string UserId { get;set; }
        public int LivroId { get; set; }
        public Livro Livro { get; set; }

    }
}
