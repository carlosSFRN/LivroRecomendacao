using System.ComponentModel;

namespace LivroRecomendacao.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descrico { get; set; }
        public string LinkFoto { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
    }
}
