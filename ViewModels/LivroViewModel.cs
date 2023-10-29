using LivroRecomendacao.Models;

namespace LivroRecomendacao.ViewModels
{
    public class LivroViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AutorId { get; set; }
        public int GeneroId { get; set; }
        public string Descrico { get; set; }
    }
}
