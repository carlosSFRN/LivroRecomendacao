using LivroRecomendacao.Data;
using LivroRecomendacao.Models;
using LivroRecomendacao.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LivroRecomendacao.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Livro> livro = await _context.Livro.ToListAsync();
            List<Autor> autores = await _context.Autor.ToListAsync();
            List<Genero> generos = await _context.Genero.ToListAsync();
            List<LivroListViewModel> livroViewModel = new List<LivroListViewModel>();

            foreach (var item in livro)
            {
                LivroListViewModel livroViewModelObject = new LivroListViewModel()
                {
                    Id = item.Id,
                    Titulo = item.Titulo,
                    Descrico = item.Descrico,
                    AutorId = item.AutorId,
                    NomeAutor = autores.Where(x => x.Id == item.AutorId).FirstOrDefault().Nome,
                    GeneroId = item.GeneroId,
                    NomeGenero = generos.Where(x => x.Id == item.GeneroId).FirstOrDefault().Nome,
                };

                livroViewModel.Add(livroViewModelObject);
            }

            return View(livroViewModel); ;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}