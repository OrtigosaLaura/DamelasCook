using DamelasCook.Data;
using DamelasCook.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DamelasCook.Services;

    public class UsuarioService : IUsuarioService {
    private AppDbContext _context;
    private SignInManager<IdentityUser> _singInManager;
    private UserManager<IdentityUser> _userManager;

private IHttpContextAccessor _httpContextAccessor;
    public UsuarioService(
        AppDbContext context, 
        SignInManager<IdentityUser> signInManager, 
        UserManager<IdentityUser> userManager,
        IHttpContextAccessor httpContextAccessor)

    
        
        {
            _context = context;
            _singInManager = signInManager;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public Task< UsuarioVM > GetUsuaroLogado()
        {
            throw new NotImplementedException();
        }
    
    }