using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LivroRecomendacao.ViewModels
{
    public class LivroListViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AutorId { get; set; }
        [Display(Name = "Autor")]
        public string NomeAutor { get; set; }
        public int GeneroId { get; set; }
        [Display(Name = "Genêro")]
        public string NomeGenero { get; set; }
        public string Descrico { get; set; }
        public string LinkFoto { get; set; }
    }
}
