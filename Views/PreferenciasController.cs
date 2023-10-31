using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LivroRecomendacao.Data;
using LivroRecomendacao.Models;

namespace LivroRecomendacao.Views
{
    public class PreferenciasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PreferenciasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Preferencias
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Preferencias.Include(p => p.Autor).Include(p => p.Genero);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Preferencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Preferencias == null)
            {
                return NotFound();
            }

            var preferencias = await _context.Preferencias
                .Include(p => p.Autor)
                .Include(p => p.Genero)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (preferencias == null)
            {
                return NotFound();
            }

            return View(preferencias);
        }

        // GET: Preferencias/Create
        public IActionResult Create()
        {
            ViewData["AutorId"] = new SelectList(_context.Autor, "Id", "Id");
            ViewData["GeneroId"] = new SelectList(_context.Genero, "Id", "Id");
            return View();
        }

        // POST: Preferencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,AutorId,GeneroId")] Preferencias preferencias)
        {
            if (ModelState.IsValid)
            {
                _context.Add(preferencias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutorId"] = new SelectList(_context.Autor, "Id", "Id", preferencias.AutorId);
            ViewData["GeneroId"] = new SelectList(_context.Genero, "Id", "Id", preferencias.GeneroId);
            return View(preferencias);
        }

        // GET: Preferencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Preferencias == null)
            {
                return NotFound();
            }

            var preferencias = await _context.Preferencias.FindAsync(id);
            if (preferencias == null)
            {
                return NotFound();
            }
            ViewData["AutorId"] = new SelectList(_context.Autor, "Id", "Id", preferencias.AutorId);
            ViewData["GeneroId"] = new SelectList(_context.Genero, "Id", "Id", preferencias.GeneroId);
            return View(preferencias);
        }

        // POST: Preferencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,AutorId,GeneroId")] Preferencias preferencias)
        {
            if (id != preferencias.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(preferencias);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PreferenciasExists(preferencias.Id))
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
            ViewData["AutorId"] = new SelectList(_context.Autor, "Id", "Id", preferencias.AutorId);
            ViewData["GeneroId"] = new SelectList(_context.Genero, "Id", "Id", preferencias.GeneroId);
            return View(preferencias);
        }

        // GET: Preferencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Preferencias == null)
            {
                return NotFound();
            }

            var preferencias = await _context.Preferencias
                .Include(p => p.Autor)
                .Include(p => p.Genero)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (preferencias == null)
            {
                return NotFound();
            }

            return View(preferencias);
        }

        // POST: Preferencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Preferencias == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Preferencias'  is null.");
            }
            var preferencias = await _context.Preferencias.FindAsync(id);
            if (preferencias != null)
            {
                _context.Preferencias.Remove(preferencias);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PreferenciasExists(int id)
        {
          return (_context.Preferencias?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
