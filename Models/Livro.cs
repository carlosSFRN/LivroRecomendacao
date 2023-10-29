namespace LivroRecomendacao.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Autor Autor { get; set; }
        public Genero Genero { get; set; }
        public string Descrico { get; set; }
    }
}
