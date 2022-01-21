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

            var client = new RestClient();
            var model = await _notaapi.GetNotas(id);
            client.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
            "Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6Ik9taWUgIHRlc3RlIChUUklBTCkiLCJQSUQiOiIzY2ZlZTRkNy03NzM3LTRhNzQtYTRmNy05NGUwNjBhOTRmNjciLCJSb2xlIjoiQ3VzdG9tZXIiLCJuYmYiOjE2NDIwOTYxODMsImV4cCI6MTY3MzYzMjE4MywiaWF0IjoxNjQyMDk2MTgzLCJpc3MiOiIxTm92by5jb20uYnIiLCJhdWQiOiJzdXJmLm1heGRhdGFjZW50ZXIuY29tLmJyIn0.T-uy3Sumtue2x_LfL6RJ3FxxI9uXLpfrZXLpEmu5pq8");

            if (model == null)
            {
                return NotFound();
            }
            return View(model.ToUpload());
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
