using Catalogo_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace Catalogo_MVC.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly Contexto _contexto;

        public UsuariosController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NovoUsuario(Usuarios usuario)
        {
            await _contexto.Usuarios.AddAsync(usuario);
            await _contexto.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
