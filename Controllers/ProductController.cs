using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Html_Helper_Asp.net.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace Html_Helper_Asp.net.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Category> categories = new List<Category>{
                new Category {Id = 1, Name = "Electronics"},
                new Category {Id = 2, Name = "Health & Beauty"},
                new Category {Id = 3, Name = "Books & Stationery"},
                new Category {Id = 4, Name = "Clothing & Apparel"},
                new Category {Id = 5, Name = "Home & Kitchen"},
            };
            //SelectList -> generates SelectListItem....
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}