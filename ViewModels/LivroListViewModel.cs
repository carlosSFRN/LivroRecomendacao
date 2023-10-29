using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LivroRecomendacao.ViewModels
{
    public class LivroListViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        [Display(Name = "Autor")]
        public int AutorId { get; set; }
        public string NomeAutor { get; set; }
        [Display(Name = "Genêro")]
        public int GeneroId { get; set; }
        public string NomeGenero { get; set; }
        public string Descrico { get; set; }
    }
}
