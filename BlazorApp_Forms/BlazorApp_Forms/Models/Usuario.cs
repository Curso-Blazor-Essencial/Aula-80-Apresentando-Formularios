using System.ComponentModel.DataAnnotations;

namespace BlazorApp_Forms.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "É necessário informar um nome")]
        [StringLength(10, ErrorMessage = "O nome não pode exceder 10 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É necessário informar um sobrenome")]
        [StringLength(10, ErrorMessage = "O nome não pode exceder 10 caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "É necessário informar uma idade")]
        [Range(18, 100, ErrorMessage = "A idade deve ser maior que 18 e menor que 100")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "É necessário informar um login")]
        [MinLength(4, ErrorMessage = "É necessário que o login tenha mais de 4 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "É necessário informar um email")]
        [EmailAddress(ErrorMessage = "É necessário que o email tenha um formato válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "É necessário escolher um perfil")]
        public string Perfil { get; set; }

        [Required(ErrorMessage = "É necessário informar uma senha")]
        [MinLength(8, ErrorMessage = "É necessário que a senha tenha pelo menos 8 caracteres")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "É necessário confirmar a senha")]
        [Compare(nameof(Password), ErrorMessage = "A senha inserida não é a mesma da senha informada")]

        public string ConfirmaPassword { get; set; } = string.Empty;
    }
}
