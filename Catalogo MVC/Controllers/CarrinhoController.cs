using Microsoft.AspNetCore.Mvc;

namespace Catalogo_MVC.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
