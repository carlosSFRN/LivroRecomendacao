using System.ComponentModel.DataAnnotations;

namespace LivroRecomendacao.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        [Compare("Password", ErrorMessage = "As senhas não são iguais.")]
        public string ConfirmPassword { get; set; }

		[Required]
		[Display(Name = "Escolha seu autor preferido")]
		public int AutorId { get; set; }

		[Required]
		[Display(Name = "Escolha seu genêro literário preferido")]
		public int GeneroId { get; set; }
		public int RoleId { get; set; }
    }
}
