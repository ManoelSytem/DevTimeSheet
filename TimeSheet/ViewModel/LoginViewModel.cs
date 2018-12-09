using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TimeSheet.ViewModel
{
    public class LoginViewModel
    {
            [Required(ErrorMessage = "Preencha o campo Login")]
            [MaxLength(100, ErrorMessage = "Máximo {1} caracteres")]
            [MinLength(3, ErrorMessage = "Mínimo {1} caracteres")]
            public string Username { get; set; }

            [Required(ErrorMessage = "Preencha o campo Senha")]
            [MaxLength(100, ErrorMessage = "Máximo {1} caracteres")]
            [MinLength(6, ErrorMessage = "Mínimo {1} caracteres")]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DisplayName("Permanecer conectado")]
            public bool ManterConectado { get; set; }

            public string ReturnUrl { get; set; }
    }
}
