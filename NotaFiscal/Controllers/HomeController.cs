using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotaFiscal.HttpClients;
using NotaFiscal.Models;
using System.Threading.Tasks;

namespace NotaFiscal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NotaApiClient _notaapi;

        public HomeController(ILogger<HomeController> logger, NotaApiClient notaapi)
        {
            _logger = logger;
            _notaapi = notaapi;
        }
        [HttpGet]
        public IActionResult Index()
        {

            return View(new Data());
          //return RedirectToAction("Detalhes", "Nota");
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
