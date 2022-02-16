using System;
using System.Threading.Tasks;
using NotaFiscal.Models;
using RestSharp;
using System.Net;
using Newtonsoft.Json;



namespace NotaFiscal.HttpClients
{

    public class NotaApiClient
    {
        readonly RestClient _client;
        public NotaApiClient(RestClient client)
        {
            _client = client;
        }

        string token = "1234";
        public async Task<root> GetNotas(string guid)
        {
            var options = new RestClientOptions("")
            {
                ThrowOnAnyError = true,
                Timeout = 1000
            };
            var client = new RestClient(options);

            try
            {
                var request = new RestRequest(guid, Method.Get);
                request.AddHeader("Authorization", token);
                request.AddHeader(KnownHeaders.Accept, "Content");

                var response = await client.ExecuteGetAsync<Data>(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    root jsonNotas = JsonConvert.DeserializeObject<root>(response.Content);
                    return jsonNotas;
                }
                else
                {
                    dynamic jsonNotas = "";
                    return new root
                    {
                        data = JsonConvert.SerializeObject(jsonNotas),
                        message = string.Format("{0} - {1}", ((int)response.StatusCode).ToString(), response.StatusDescription),
                        success = false
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error parameter null or Not Unauthorization", ex);
            }
        }

        public async Task<root> postNotas(string owner)
        {
            var options = new RestClientOptions($"")
            {
                ThrowOnAnyError = true,
                Timeout = 1000
            };
            var client = new RestClient(options);

            try
            {
                var request = new RestRequest();
                request.AddHeader("Authorization", token);
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader(KnownHeaders.Accept, "Content");
                request.AddParameter(owner, ParameterType.GetOrPost);
                
                var response = await client.ExecuteAsync<Data>(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    root jsonNotas = JsonConvert.DeserializeObject<root>(response.Content);
                    return jsonNotas;
                }
                else
                {
                    dynamic jsonNotas = "";
                    return new root
                    {
                        data = JsonConvert.SerializeObject(jsonNotas),
                        success = false
                    };
                }
             }
            catch (Exception ex)
            {
                throw new Exception("Error parameter null or Not Unauthorization", ex);
            }
        }

        public async Task<Data> PutNotaSharp(Data options)
            {

            var request = new RestRequest($"", Method.Put)
            {
                RootElement = "options"
            }
                .AddHeader(KnownHeaders.Authorization, token)
                .AddHeader("Content-Type", "application/x-www-form-urlencoded")
                 .AddHeader("Content-Type", "application/json")
                .AddHeader(KnownHeaders.Accept, "Content")
                .AddParameter("application/json", ParameterType.RequestBody)
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
                .AddParameter("nfInicial", options.nfInicial)
                .AddParameter("cancelado", options.cancelado)
                .AddParameter("geraPDF", options.geraPDF)
                .AddParameter("linkPDF", options.linkPDF);
            if (options.numeroNF > 0)
            {
                request.AddParameter("numeroNF", options.numeroNF);
            }
            var response = await _client.PutAsync<root>(request);
            return response.data;
        }
       

    }
}

