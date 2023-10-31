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

namespace LivroRecomendacao.Controllers
{
    public class LivrosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LivrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Livros
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
                    LinkFoto = item.LinkFoto,
                    NomeAutor = autores.Where(x => x.Id == item.AutorId).FirstOrDefault().Nome,
                    GeneroId = item.GeneroId,
                    NomeGenero = generos.Where(x => x.Id == item.GeneroId).FirstOrDefault().Nome,
                };

                livroViewModel.Add(livroViewModelObject);
            }

            return View(livroViewModel);
        }

        // GET: Livros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Livro == null)
            {
                return NotFound();
            }

            var livro = await _context.Livro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // GET: Livros/Create
        public IActionResult Create()
        {
            var autores = _context.Autor;
            ViewBag.Autores = new SelectList(autores, "Id", "Nome");
            var generos = _context.Genero;
            ViewBag.Generos = new SelectList(generos, "Id", "Nome");

            return View();
        }

        // POST: Livros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LivroViewModel livroViewModel)
        {
            if (ModelState.IsValid)
            {
                var livro = new Livro()
                {
                    Titulo = livroViewModel.Titulo,
                    Descrico = livroViewModel.Descrico,
                    LinkFoto = livroViewModel.LinkFoto,
                    AutorId = livroViewModel.AutorId,
                    GeneroId = livroViewModel.GeneroId
                };

                _context.Add(livro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(livroViewModel);
        }

        // GET: Livros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Livro == null)
            {
                return NotFound();
            }
            
            var autores = _context.Autor;
            ViewBag.Autores = new SelectList(autores, "Id", "Nome");
            
            var generos = _context.Genero;
            ViewBag.Generos = new SelectList(generos, "Id", "Nome");
            
            var livro = await _context.Livro.FindAsync(id);

            if (livro == null)
            {
                return NotFound();
            }

            var livroViewModel = new LivroViewModel()
            {
                Titulo = livro.Titulo,
                Descrico = livro.Descrico,
                LinkFoto = livro.LinkFoto,
                AutorId = livro.AutorId,
                GeneroId = livro.GeneroId
            };

            return View(livroViewModel);
        }

        // POST: Livros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LivroViewModel livroViewModel)
        {
            if (id != livroViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var livro = new Livro()
                    {
                        Id = livroViewModel.Id,
                        Titulo = livroViewModel.Titulo,
                        Descrico = livroViewModel.Descrico,
                        LinkFoto = livroViewModel.LinkFoto,
                        AutorId = livroViewModel.AutorId,
                        GeneroId = livroViewModel.GeneroId
                    };

                    _context.Update(livro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivroExists(livroViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(livroViewModel);
        }

        // GET: Livros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Livro == null)
            {
                return NotFound();
            }

            var livro = await _context.Livro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Livro == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Livro'  is null.");
            }
            var livro = await _context.Livro.FindAsync(id);
            if (livro != null)
            {
                _context.Livro.Remove(livro);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LivroExists(int id)
        {
          return (_context.Livro?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
