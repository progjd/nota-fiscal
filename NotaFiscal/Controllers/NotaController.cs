using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotaFiscal.Controllers
{
    public class NotaController : Controller
    {
        private NotaApiClient _notaapi;

        public NotaController(NotaApiClient notaapi)
        {
            _notaapi = notaapi;
        }
        public IActionResult Index()
        {
            return View();
        }

      
    }
}
