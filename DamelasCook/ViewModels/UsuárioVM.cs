namespace DamelasCook.ViewModels;

    public class UsuarioVM
    {
        public string UsuarioId { get; set; }
        public string UserName { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Foto { get; set; }
        public string perfil { get; set; }
        public bool IsAdmin { get; set; }
    }
