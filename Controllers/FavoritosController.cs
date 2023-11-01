using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LivroRecomendacao.Data;
using LivroRecomendacao.Models;
using LivroRecomendacao.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Net;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LivroRecomendacao.Controllers
{
    public class FavoritosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public FavoritosController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Favoritos
        public async Task<IActionResult> Index()
        {
            List<Livro> livro = await _context.Livro.ToListAsync();
            List<Autor> autores = await _context.Autor.ToListAsync();
            List<Genero> generos = await _context.Genero.ToListAsync();
            List<Preferencias> preferencias = await _context.Preferencias.ToListAsync();

            string email = User.Identity.Name;

			var userId = await _userManager.FindByEmailAsync(email);

            Preferencias preferenciasObject = preferencias.FirstOrDefault(x => x.UserId == userId.Id); 

            List<LivroListViewModel> livroViewModel = new List<LivroListViewModel>();

            foreach (var item in livro)
            {
                LivroListViewModel livroViewModelObject = new LivroListViewModel()
                {
                    Id = item.Id,
                    Titulo = item.Titulo,
                    Descrico = item.Descrico,
                    AutorId = item.AutorId,
                    LinkFoto = GetImageFromUrl(item.LinkFoto),
                    NomeAutor = autores.Where(x => x.Id == item.AutorId).FirstOrDefault().Nome,
                    GeneroId = item.GeneroId,
                    NomeGenero = generos.Where(x => x.Id == item.GeneroId).FirstOrDefault().Nome
				};

                livroViewModel.Add(livroViewModelObject);
            }

            if (!User.IsInRole("Adm"))
            {
                livroViewModel = livroViewModel.Where(x => x.GeneroId == preferenciasObject.GeneroId || x.AutorId == preferenciasObject.AutorId).ToList();
                ViewBag.AutorPreferencia = livroViewModel.Where(x => x.AutorId == preferenciasObject.AutorId).FirstOrDefault().NomeAutor;
				ViewBag.GeneroPreferencia = livroViewModel.Where(x => x.GeneroId == preferenciasObject.GeneroId).FirstOrDefault().NomeGenero;

			}

			return View(livroViewModel);
        }

        public static string GetImageFromUrl(string url)
        {
            try
            {
                var request = WebRequest.Create(url);
                request.Timeout = 3000; // optional
                using (var response = request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        if (response.ContentType.Contains("image/"))
                        {
                            var imageBytes = new byte[response.ContentLength];
                            using (var memoryStream = new MemoryStream())
                            {
                                stream.CopyTo(memoryStream);
                                imageBytes = memoryStream.ToArray();
                            }
                            string imgBase64Data = Convert.ToBase64String(imageBytes);
                            return $"data:{response.ContentType};base64,{imgBase64Data}";
                        }
                    }
                }
            }
            catch
            {
                // you can throw or ignore 
            }

            return null;
        }

        // GET: Livros/Edit/5
        public async Task<IActionResult> Desfavoritar(int id)
        {
            var favorito = new Favorito()
            {
                Id = id
            };

            if (favorito == null)
            {
                return NotFound();
            }

            _context.Favorito.Remove(favorito);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Favoritos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Favorito == null)
            {
                return NotFound();
            }

            var favorito = await _context.Favorito
                .Include(f => f.Livro)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (favorito == null)
            {
                return NotFound();
            }

            return View(favorito);
        }

        // POST: Favoritos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Favorito == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Favorito'  is null.");
            }
            var favorito = await _context.Favorito.FindAsync(id);
            if (favorito != null)
            {
                _context.Favorito.Remove(favorito);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FavoritoExists(int id)
        {
          return (_context.Favorito?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
