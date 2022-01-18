using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using NotaFiscal.Models;
using RestSharp;

namespace NotaFiscal.HttpClients
{

    public class NotaApiClient
    {
        const string BaseUrl = "http://servluc01.ddns.com.br/NFeModelo2122Diginota/v1/Invoice/List";
        readonly RestClient _httpClient;
        

        public NotaApiClient(RestClient httpClient)
        {
            _httpClient = new RestClient(BaseUrl);
            _httpClient = httpClient;
        }

        //private string EnvolveComAspasDuplas(string valor)
        //{
        //    return $"\"{valor}\"";
        //}

        //formulario inclusao de nota
        private HttpContent CreateMultiFormContent(Notas model)
        {
            var content = new MultipartContent();

            content.Add(new StringContent(model.owner));

            //campo preenchimento nao obrigatorio
            if (!string.IsNullOrEmpty(model.numeroNF.ToString()))
            {
            content.Add(new StringContent(model.numeroNF.ToString()));
                
            }
            if (!string.IsNullOrEmpty(model.serie))
            {
                content.Add(new StringContent(model.serie));
            }
            if (!string.IsNullOrEmpty(model.incideBC.ToString()))
            {
                content.Add(new StringContent(model.incideBC.ToString()));
            }
            if (!string.IsNullOrEmpty(model.dataPrestacao))
            {
                content.Add(new StringContent(model.dataPrestacao));
            }
            if (!string.IsNullOrEmpty(model.dataEmissao))
            {
                content.Add(new StringContent(model.dataEmissao));
            }
            if (!string.IsNullOrEmpty(model.diaVencimento.ToString()))
            {
                content.Add(new StringContent(model.diaVencimento.ToString()));
            }
            if (!string.IsNullOrEmpty(model.cfop.ToString()))
            {
                content.Add(new StringContent(model.cfop.ToString()));
            }
            if (!string.IsNullOrEmpty(model.modelo.ToString()))
            {
                content.Add(new StringContent(model.modelo.ToString()));
            }
            if (!string.IsNullOrEmpty(model.tipoUtilizacao.ToString()))
            {
                content.Add(new StringContent(model.tipoUtilizacao.ToString()));
            }
            if (!string.IsNullOrEmpty(model.obs))
            {
                content.Add(new StringContent(model.obs));
            }
            if (!string.IsNullOrEmpty(model.nfInicial.ToString()))
            {
                content.Add(new StringContent(model.nfInicial.ToString()));
            }
            if ((model.cancelado))
            {
                content.Add(new StringContent(model.cancelado.ToString()));
            }
            if (model.geraPDF)
            {
                content.Add(new StringContent(model.geraPDF.ToString()));
            }
            if (!string.IsNullOrEmpty(model.linkPDF))
            {
                content.Add(new StringContent(model.linkPDF));
            }

            //formulario destinatario
          
            //formulario responsavel
           
            //formulario item
            if (!string.IsNullOrEmpty(model.item.codigoitem))
            {
                content.Add(new StringContent(model.item.codigoitem));
            }
            if (!string.IsNullOrEmpty(model.item.descricaoitem))
            {
                content.Add(new StringContent(model.item.descricaoitem));
            }
            if (!string.IsNullOrEmpty(model.item.unidade))
            {
                content.Add(new StringContent(model.item.unidade));
            }
            if (!string.IsNullOrEmpty(model.item.quantidadeContratada.ToString()))
            {
                content.Add(new StringContent(model.item.quantidadeContratada.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.quantidadeFornecida.ToString()))
            {
                content.Add(new StringContent(model.item.quantidadeFornecida.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.quantidadeFaturada.ToString()))
            {
                content.Add(new StringContent(model.item.quantidadeFaturada.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.valorUnit.ToString()))
            {
                content.Add(new StringContent(model.item.valorUnit.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.aliquotaICMS.ToString()))
            {
                content.Add(new StringContent(model.item.aliquotaICMS.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.reducao.ToString()))
            {
                content.Add(new StringContent(model.item.reducao.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.aliquotaPIS.ToString()))
            {
                content.Add(new StringContent(model.item.aliquotaPIS.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.aliquotaCOFINS.ToString()))
            {
                content.Add(new StringContent(model.item.aliquotaCOFINS.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.aliqValorTribFederais.ToString()))
            {
                content.Add(new StringContent(model.item.aliqValorTribFederais.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.aliqValorTribEstaduais.ToString()))
            {
                content.Add(new StringContent(model.item.aliqValorTribEstaduais.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.aliqValorTribMunicipais.ToString()))
            {
                content.Add(new StringContent(model.item.aliqValorTribMunicipais.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.desconto.ToString()))
            {
                content.Add(new StringContent(model.item.desconto.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.outrosValores.ToString()))
            {
                content.Add(new StringContent(model.item.outrosValores.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.codigoClassificacao.ToString()))
            {
                content.Add(new StringContent(model.item.codigoClassificacao.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.tipoIsencao.ToString()))
            {
                content.Add(new StringContent(model.item.tipoIsencao.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.tarifa.ToString()))
            {
                content.Add(new StringContent(model.item.tarifa.ToString()));
            }
            if (!string.IsNullOrEmpty(model.item.indicacaoDescJudicial))
            {
                content.Add(new StringContent(model.item.indicacaoDescJudicial));
            }
            if (!string.IsNullOrEmpty(model.item.numeroContrato))
            {
                content.Add(new StringContent(model.item.numeroContrato));
            }
            if (!string.IsNullOrEmpty(model.item.infoAdicional.ToString()))
            {
                content.Add(new StringContent(model.item.infoAdicional.ToString()));
            }
             
            //Atualizar nota
        
                     
            return content;
        }

        public Task<Notas> GetNotas(string notaSid)
        {
            var request = new RestRequest("Notas/{NotaSid}");
            request.RootElement = "Notas";
            request.AddParameter("NotaSid", notaSid, ParameterType.GetOrPost);

            return _httpClient.GetAsync<Notas>(request);
        }

        public Task<Notas> PutNotaSharp(Notas options)
        {
            var request = new RestRequest("options", Method.Put)
            {
                RootElement = "options"
            }
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
                .AddParameter("obs", options.geraPDF)
                .AddParameter("obs", options.linkPDF)
                .AddParameter("obs", options.nfInicial)
                .AddParameter("obs", options.cancelado)
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
                if(options.Id > 0)
                {
                    request.AddParameter("id", options.Id);
                }
            return _httpClient.PutAsync<Notas>(request);
        }
    }
}
