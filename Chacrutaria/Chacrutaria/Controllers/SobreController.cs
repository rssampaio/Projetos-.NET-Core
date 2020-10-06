using Microsoft.AspNetCore.Mvc;

namespace Chacrutaria.Controllers
{
    public class SobreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
