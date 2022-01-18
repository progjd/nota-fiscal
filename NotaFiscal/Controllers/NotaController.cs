using Microsoft.AspNetCore.Mvc;
using NotaFiscal.HttpClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotaFiscal.Models;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace NotaFiscal.Controllers
{
    public class NotaController : Controller
    {
       
        private NotaApiClient _notaapi;

        public NotaController(NotaApiClient notaapi)
        {
            _notaapi = notaapi;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateNota(Notas model)
        {
            if (ModelState.IsValid)
            {
                await _notaapi.PutNotaAsync(model);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }



    }
}
