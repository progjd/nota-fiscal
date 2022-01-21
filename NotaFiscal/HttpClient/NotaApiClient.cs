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

        public Task<Notas> GetNotas(string notaSid)
        {
            var request = new RestRequest("http://servluc01.ddns.com.br/NFeModelo2122Diginota/v1/Invoice/Notas/{notaSid}");

            _client.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
            "Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6Ik9taWUgIHRlc3RlIChUUklBTCkiLCJQSUQiOiIzY2ZlZTRkNy03NzM3LTRhNzQtYTRmNy05NGUwNjBhOTRmNjciLCJSb2xlIjoiQ3VzdG9tZXIiLCJuYmYiOjE2NDIwOTYxODMsImV4cCI6MTY3MzYzMjE4MywiaWF0IjoxNjQyMDk2MTgzLCJpc3MiOiIxTm92by5jb20uYnIiLCJhdWQiOiJzdXJmLm1heGRhdGFjZW50ZXIuY29tLmJyIn0.T-uy3Sumtue2x_LfL6RJ3FxxI9uXLpfrZXLpEmu5pq8");

            request.RootElement = "Notas";
            request.AddParameter(notaSid, Method.Get);
          
            var response = _client.GetAsync<Notas>(request);
            return response;
            
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

