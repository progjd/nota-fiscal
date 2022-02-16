using Microsoft.AspNetCore.Mvc;
using NotaFiscal.HttpClients;
using System.Threading.Tasks;
using NotaFiscal.Models;


namespace NotaFiscal.Controllers
{
   
    public class NotaController : Controller
    {

        private NotaApiClient _notaapi;

        public NotaController( NotaApiClient notaapi)
        {
            _notaapi = notaapi;
        }

        [HttpGet]
        public async Task<IActionResult> Detalhes(string id)
        {
            var model = await _notaapi.GetNotas(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model.data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string owner)
        {
            var model = await _notaapi.postNotas(owner);
            if (model != null)
            {
                return View(model.data);
            }
                     
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Detalhes(Data model)
        {
            ViewData["message"] = "atualiza aaqu";
            if (ModelState.IsValid)
            {
                await _notaapi.PutNotaSharp(model);
                return RedirectToAction("Index", "Nota");
            }
            return View(model);
        }

    }
}
