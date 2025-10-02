// importa as bibliotecas que serao utilizadas no projeto
using Microsoft.AspNetCore.Mvc;
using ProjetoLoja2DSA.Repositorio;

// define o nome e onde a classe esta usuarioController esta localizada
// namespace ajuda a organizar o codigo e evitar conflitos
namespace ProjetoLoja2DSA.Controllers
{
    // classe usuarioController que está herdando da classe pai Controller
    public class UsuarioController : Controller
    {
        // declara a variavel privada e somente leitura do tipo usuarioRepositorio
        // instancia o _usuarioController para ser atribuido no construtor e interagir com os dados 
        private readonly UsuarioRepositorio _usuarioRepositorio;

        // define o construtor da classe usuarioController
        // recebe a instancia de usuarioRepostorio com parametros
    public UsuarioController(UsuarioRepositorio usuarioRepositorio)
    {
        // o construtor é chamado quando uma nova instância é criada
        _usuarioRepositorio = usuarioRepositorio;
    }

        [HttpGet]
        // interface que representa o resultado da pagina
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario = _usuarioRepositorio.ObterUsuario(email);

            if (usuario != null && usuario.senha != senha)
            {
                return RedirectToAction("Index", "Cliente");
            }
            ModelState.AddModelError("", "Email / senha Inválidos");

        // RETORNA A PAGINA INDEX
        return View();
        }
    }
}
