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
            List<Favorito> favorito = await _context.Favorito.ToListAsync();

            string? email = HttpContext.User.Identity?.Name;

            var userId = await _userManager.FindByEmailAsync(email);

            favorito = favorito.Where(x => x.UserId == userId.Id).ToList();

            List<LivroListViewModel> livroViewModel = new List<LivroListViewModel>();

            foreach (var item in favorito)
            {
                int idAutor = livro.Where(x => x.Id == item.LivroId).FirstOrDefault().AutorId;

                LivroListViewModel livroViewModelObject = new LivroListViewModel()
                {
                    Id = item.Id,
                    LinkFoto = livro.Where(x => x.Id == item.LivroId).FirstOrDefault().LinkFoto,
                    Titulo = livro.Where(x => x.Id == item.LivroId).FirstOrDefault().Titulo,
                    Descrico = livro.Where(x => x.Id == item.LivroId).FirstOrDefault().Descrico,
                    NomeAutor = autores.Where(x => x.Id == idAutor).FirstOrDefault().Nome
                };

                livroViewModel.Add(livroViewModelObject);
            }


            return View(livroViewModel);
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
