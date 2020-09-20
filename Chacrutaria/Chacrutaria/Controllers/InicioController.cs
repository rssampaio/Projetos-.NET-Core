using System;
using Microsoft.AspNetCore.Mvc;
using Chacrutaria.ViewModels;

namespace Chacrutaria.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
