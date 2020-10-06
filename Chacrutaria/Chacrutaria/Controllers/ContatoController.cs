using Microsoft.AspNetCore.Mvc;

namespace Chacrutaria.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Login", "Account");
        }
    }
}
