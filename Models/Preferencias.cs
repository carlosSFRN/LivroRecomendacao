namespace LivroRecomendacao.Models
{
    public class Preferencias
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
    }
}
