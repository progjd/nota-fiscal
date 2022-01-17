using Microsoft.AspNetCore.Mvc;
using NotaFiscal.HttpClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotaFiscal.Models;

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
         //criar metodo atualizar no httpclient put nota async
          public async Task<IActionResult> UpdateNota(Notas model)
        {

            if (ModelState.IsValid)
            {
              await _notaapi.PutNotaAsync(model);
                return NotFound();
            }
            return View(model);
        }

      
    }
}
