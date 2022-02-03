using Microsoft.AspNetCore.Mvc;
using NotaFiscal.HttpClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotaFiscal.Models;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using RestSharp;
using RestSharp.Authenticators.OAuth2;
using Microsoft.AspNetCore.Authorization;

namespace NotaFiscal.Controllers
{
   
    public class NotaController : Controller
    {

        private NotaApiClient _notaapi;

        public NotaController(NotaApiClient notaapi)
        {
            _notaapi = notaapi;
        }
        [HttpGet]
        public async Task<IActionResult> GetNota(string id)
        {

            
            var model = await _notaapi.GetNotas(id);
           
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
          //  return RedirectToAction("GetNota", "Nota");
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Atualiza(Notas model)
        //{
        //    ViewData["message"] = "atualiza aaqu";
        //    if (ModelState.IsValid)
        //    {
        //        await _notaapi.PutNotaSharp(model);
        //        return RedirectToAction("Index", "Home");
        //    }
        //    return View(model);
        //}


        public IActionResult Atualiza()
        {
            ViewData["message"] = "atualiza aaqi";
            return View();
        }

    }
}
