using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DIContainer.Models;

namespace DIContainer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ContainerCustom<IProduct, Product> _myContainer = new ContainerCustom<IProduct, Product>();
        private readonly ContainerCustom<IProduct<ExportProduct>, TypedProduct<ExportProduct>> _myTypedContainer 
            = new ContainerCustom<IProduct<ExportProduct>, TypedProduct<ExportProduct>>();
        private readonly IProduct _prd;
        private readonly IProduct<ExportProduct> _prdTyped;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _prd = _myContainer.ResolveType();
            _prdTyped = _myTypedContainer.ResolveType();
        }

        public IActionResult Index()
        {
            return Json(new
            {
                TypedProduct = new { Name = _prdTyped.Name, Desc = _prdTyped.Desc },
                NormalProduct = new { Name = _prd.Name, Desc = _prd.Desc }
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
