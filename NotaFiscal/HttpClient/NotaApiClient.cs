using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using NotaFiscal.Models;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Authenticators.OAuth2;

namespace NotaFiscal.HttpClients
{

    public class NotaApiClient
    {
     
        readonly RestClient _client;

        public NotaApiClient(RestClient client)
        {
            _client = client;
        }

        public async Task<Notas> GetNotas(string guid)
        {
            var options = new RestClientOptions()
            {
                ThrowOnAnyError = true,
                Timeout = 1000
            };
            var client = new RestClient(options);
            try
            {
  
                var request = new RestRequest(guid, Method.Post);
                request.AddHeader("Authorization", "");
                request.AddHeader(KnownHeaders.ContentType, "application/json");
                var response = await client.ExecuteGetAsync<Notas>(request);
                return response.Data;
               

            }
            catch (Exception ex)
            {

                throw new Exception("Error parameter null or Not Unauthorization", ex);
            }
            
        }

        public Task<Notas> PutNotaSharp(Notas options)
        {
            var request = new RestRequest("Notas")
            {
                RootElement = "options"
            }
                .AddHeader("Content-Type", "multipart/form-data;boundary=[]")
                .AddParameter("Owner", options.owner)
                .AddParameter("numeroNota", options.numeroNF)
                .AddParameter("Serie", options.serie)
                .AddParameter("incideBC", options.incideBC)
                .AddParameter("dataPrestacao", options.dataPrestacao)
                .AddParameter("dataEmissao", options.dataEmissao)
                .AddParameter("diaVencimento", options.diaVencimento)
                .AddParameter("cfop", options.cfop)
                .AddParameter("modelo", options.modelo)
                .AddParameter("tipoUtilizacao", options.tipoUtilizacao)
                .AddParameter("geraPDF", options.geraPDF)
                .AddParameter("linkPDF", options.linkPDF)
                .AddParameter("nfInicial", options.nfInicial)
                .AddParameter("cancelado", options.cancelado)
                .AddParameter("destinatario", options.destinatario.razaoSocial)
                .AddParameter("destinatario", options.destinatario.logradouro)
                .AddParameter("destinatario", options.destinatario.numero)
                .AddParameter("destinatario", options.destinatario.municipio)
                .AddParameter("destinatario", options.destinatario.bairro)
                .AddParameter("destinatario", options.destinatario.cep)
                .AddParameter("destinatario", options.destinatario.email)
                .AddParameter("destinatario", options.destinatario.uf)
                .AddParameter("destinatario", options.destinatario.cnpjcpf)
                .AddParameter("destinatario", options.destinatario.codigoIdentificacao)
                .AddParameter("destinatario", options.destinatario.codigoMunicipio)
                .AddParameter("destinatario", options.destinatario.telefone)
                .AddParameter("destinatario", options.destinatario.tipoCliente)
                .AddParameter("destinatario", options.destinatario.ierg)
                .AddParameter("Responsavel", options.responsavel.nomeFantasia)
                .AddParameter("Responsavel", options.responsavel.razaoSocial)
                .AddParameter("Responsavel", options.responsavel.bairro)
                .AddParameter("Responsavel", options.responsavel.cep)
                .AddParameter("Responsavel", options.responsavel.cnpjcpf)
                .AddParameter("Responsavel", options.responsavel.codigoMunicipio)
                .AddParameter("Responsavel", options.responsavel.complemento)
                .AddParameter("Responsavel", options.responsavel.email)
                .AddParameter("Responsavel", options.responsavel.ie)
                .AddParameter("Responsavel", options.responsavel.logradouro)
                .AddParameter("Responsavel", options.responsavel.numero)
                .AddParameter("Responsavel", options.responsavel.telefone)
                .AddParameter("Responsavel", options.responsavel.uf);
            if (options.Id > 0)
            {
                request.AddParameter("id", options.Id);
            }
            return _client.PutAsync<Notas>(request);
        }
    }
}

