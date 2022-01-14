using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;



    public class NotaApiClient
    {
        private HttpClient _httpClient;
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
    private HttpContent CreateMultipartFormDataContent(NotaFiscal.Models.Notas model)
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
        if (model.Owner !=null )
        {
            content.Add(new StringContent(model.Owner.ToString()), EnvolveComAspasDuplas("Owner"));
        }

        //upload de arquivo capa
        //if (model.Capa != null)
        //{
        //    var imagemContent = new ByteArrayContent(model.Capa.ConvertToBytes());
        //    imagemContent.Headers.Add("content-type", "image/png");
        //    content.Add(imagemContent,
        //        EnvolveComAspasDuplas("capa"),
        //        EnvolveComAspasDuplas("capa.png")
        //       );

        //}
        return content;
    }
}

