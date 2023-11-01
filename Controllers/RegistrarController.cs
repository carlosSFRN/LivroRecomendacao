using LivroRecomendacao.Data;
using LivroRecomendacao.Migrations;
using LivroRecomendacao.Models;
using LivroRecomendacao.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static System.Formats.Asn1.AsnWriter;

namespace LivroRecomendacao.Controllers
{
    public class RegistrarController : Controller
    {
        // GET: RegistrarController
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public RegistrarController(ApplicationDbContext context, UserManager<IdentityUser> userManager) 
        {
            _context = context;
            _userManager = userManager;
        }    
		public IActionResult Create()
		{
			var autores = _context.Autor;
			ViewBag.Autores = new SelectList(autores, "Id", "Nome");
			var generos = _context.Genero;
			ViewBag.Generos = new SelectList(generos, "Id", "Nome");

			return View();
		}

		// POST: RegistrarController/Create
		[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _userManager.FindByEmailAsync(registerViewModel.Email) == null)
                {
                    var user = new IdentityUser();
                    user.UserName = registerViewModel.Email;
                    user.Email = registerViewModel.Email;

                    await _userManager.CreateAsync(user, registerViewModel.Password);

                    await _userManager.AddToRoleAsync(user, "Membro");

                    var userId = await _userManager.FindByEmailAsync(registerViewModel.Email);

                    Preferencias preferencias = new Preferencias();

                    preferencias = new Preferencias()
                    {
                        AutorId = registerViewModel.AutorId,
                        GeneroId = registerViewModel.GeneroId,
                        UserId = userId.Id
                        
                    };

                    _context.Preferencias.Add(preferencias);
                    await _context.SaveChangesAsync();
                    return RedirectToRoute(new { controller = "Home", action = "Index"});
				}
            }
			return View(registerViewModel);
		}
        
    }
}
