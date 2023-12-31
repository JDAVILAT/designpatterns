using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using singleton.mvc.Configuration;
using singleton.mvc.Models;
using singleton.mvc.tools;
using System.Diagnostics;

namespace singleton.mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MyConfig> _config;

        public HomeController(IOptions<MyConfig> config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            log.GetInstance(_config.Value.PathLog).Save("Ingreso a index");
            return View();
        }

        public IActionResult Privacy()
        {
            log.GetInstance(_config.Value.PathLog).Save("Ingreso a privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}