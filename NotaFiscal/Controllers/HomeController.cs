using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotaFiscal.HttpClients;
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

            return View();
          //return RedirectToAction("Detalhes", "Nota");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string owner)
        {
          
            var model = await _notaapi.postNotas(owner);

            if (model == null)
            {
                return NotFound();
            }
  
                return View(model.data);
         }
       

        public IActionResult Privacy()
        {
            return View();
        }
     

    }
}
