using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace DamelasCook.ViewModels;

    public class LoginVM
    {
        [Display(Name = "Email ou Nome de Usuário", Prompt = "Email ou Nome de Usuário" )]
        [Required(ErrorMessage = "Por favor, informe seu email ou nome de usuário")]
        public string Email { get; set; }
        [Display(Name = "Senha de Acesso", Prompt = "Senha de Acesso" )]
        [Required(ErrorMessage = "Por favor, informe sua senha")]

        public string Senha { get; set; }
        [Display(Name = "Manter Conectado?")]
        [Required(ErrorMessage = "Por favor, informe sua senha")]

        public bool Lembrar { get; set; } = false;

        public string UrlRetorno { get; set; }

    }
