using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using NotaFiscal.Models;

namespace NotaFiscal.HttpClients
{
    public class NotaApiClient
    {
        private readonly HttpClient _httpClient;
        private IHttpContextAccessor _accessor;

        public NotaApiClient(HttpClient httpClient, IHttpContextAccessor accessor)
        {
            _httpClient = httpClient;
            _accessor = accessor;

        }
    private string EnvolveComAspasDuplas(string valor)
    {
        return $"\"{valor}\"";
    }

    //formulario inclusao de nota
    private HttpContent CreateMultipartFormDataContent(Notas model)
    {
        var content = new MultipartFormDataContent();

        //content.Add(new StringContent(model.Titulo), EnvolveComAspasDuplas("titulo"));
        //content.Add(new StringContent(model.Lista.ParaString()), EnvolveComAspasDuplas("lista"));

        ////campo preenchimento nao obrigatorio
        //if (!string.IsNullOrEmpty(model.Subtitulo))
        //{
        //    content.Add(new StringContent(model.Subtitulo), EnvolveComAspasDuplas("subtitulo"));
        //}
        //if (!string.IsNullOrEmpty(model.Resumo))
        //{
        //    content.Add(new StringContent(model.Resumo), EnvolveComAspasDuplas("resumo"));
        //}
        //if (!string.IsNullOrEmpty(model.Autor))
        //{
        //    content.Add(new StringContent(model.Autor), EnvolveComAspasDuplas("autor"));
        //}

        //Atualizar nota
        if (model.id !=null )
        {
            content.Add(new StringContent(model.id.ToString()), EnvolveComAspasDuplas("id"));
        }

       
        return content;
    }

    public Task PutNotaAsync(Notas model)
    {
      throw new NotImplementedException();
    }
  }
}
