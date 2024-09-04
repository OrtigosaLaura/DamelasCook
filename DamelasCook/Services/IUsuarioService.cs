using DamelasCook.ViewModels;

namespace DamelasCook.Services;

    public interface IUsuarioService
    {
        Task<UsuarioVM> GetUsuaroLogado();
    }
