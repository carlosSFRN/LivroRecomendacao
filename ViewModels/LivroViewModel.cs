using LivroRecomendacao.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LivroRecomendacao.ViewModels
{
    public class LivroViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe um titulo")]
        public string Titulo { get; set; }
        [Display(Name = "Autor")]
        [Required(ErrorMessage = "Escolha um autor")]
        public int AutorId { get; set; }
        [Display(Name = "Genêro")]
        [Required(ErrorMessage = "Escolha um genêro")]
        public int GeneroId { get; set; }
        [Required(ErrorMessage = "Informe uma descrição")]
        public string Descrico { get; set; }
        [Display(Name = "Link da Foto")]
        [Required(ErrorMessage = "Informe uma foto")]
        public string LinkFoto { get; set; }
    }
}
