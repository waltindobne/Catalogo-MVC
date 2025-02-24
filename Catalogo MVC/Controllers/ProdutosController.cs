using Microsoft.AspNetCore.Mvc;

namespace Catalogo_MVC.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
