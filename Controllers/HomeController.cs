using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using System.Linq;
using Adicionando.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? id)
        {
            // var item = new Igredientes();
            // if (id.HasValue)
            // {
            //     if (Igredientes.Listagem.Any(u => u.Id == id)){
            //         item = Igredientes.Listagem.Single(u => u.Id == id);
            //     }
            // }
            return View(Igredientes.Listagem);
        }

        public IActionResult igredientes()
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