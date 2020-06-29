using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendasWebMVC.Services;

namespace VendasWebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerAervice)
        {
            _sellerService = sellerAervice;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();

            return View(list);
        }
    }
}