using Microsoft.AspNetCore.Mvc;
using DamelasCook.ViewModels;
using DamelasCook.Services;

namespace DamelasCook.Controllers;

    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IUsuarioService _usuarioService;

        public AccountController(
            ILogger<AccountController> logger,
            IUsuarioService usuarioService
            )
        {
            //Url.Action
            _logger = logger;
            _usuarioService = usuarioService;
            
        }
        [HttpGet]

        public IActionResult Login( string returnUrl)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
