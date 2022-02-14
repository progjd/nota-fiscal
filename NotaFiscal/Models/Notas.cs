using System;
using System.Collections.Generic;


namespace NotaFiscal.Models
{
    //Notas myDeserializedClass = JsonConvert.DeserializeObject<Notas>(myJsonResponse);
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Destinatario
    {
        public string razaoSocial { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string municipio { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
        public string cnpjcpf { get; set; }
        public string ierg { get; set; }
        public long telefone { get; set; }
        public string email { get; set; }
        public int tipoCliente { get; set; }
        public int codigoMunicipio { get; set; }
        public string codigoIdentificacao { get; set; }
        public List<object> notifications { get; set; }
        public bool invalid { get; set; }
        public bool valid { get; set; }
    }

    public class Item
    {
        public string codigoitem { get; set; }
        public string descricaoitem { get; set; }
        public string unidade { get; set; }
        public double quantidadeContratada { get; set; }
        public double quantidadeFornecida { get; set; }
        public double quantidadeFaturada { get; set; }
        public double valorUnit { get; set; }
        public double aliquotaICMS { get; set; }
        public double reducao { get; set; }
        public double aliquotaPIS { get; set; }
        public double aliquotaCOFINS { get; set; }
        public double aliqValorTribFederais { get; set; }
        public double aliqValorTribEstaduais { get; set; }
        public double aliqValorTribMunicipais { get; set; }
        public double desconto { get; set; }
        public double outrosValores { get; set; }
        public int codigoClassificacao { get; set; }
        public int tipoIsencao { get; set; }
        public double tarifa { get; set; }
        public string indicacaoDescJudicial { get; set; }
        public string numeroContrato { get; set; }
        public List<string> infoAdicional { get; set; }
        public List<object> notifications { get; set; }
        public bool invalid { get; set; }
        public bool valid { get; set; }
    }

    public class Data
    {
        public int id { get; set; }
        public string owner { get; set; }
        public int numeroNF { get; set; }
        public string serie { get; set; }
        public bool incideBC { get; set; }
        public DateTime dataPrestacao { get; set; }
        public DateTime dataEmissao { get; set; }
        public int diaVencimento { get; set; }
        public int cfop { get; set; }
        public int modelo { get; set; }
        public int tipoUtilizacao { get; set; }
        public object obs { get; set; }
        public Destinatario destinatario { get; set; }
        public object responsavel { get; set; }
        public List<Item> itens { get; set; }
        public int nfInicial { get; set; }
        public bool cancelado { get; set; }
        public bool geraPDF { get; set; }
        public string linkPDF { get; set; }
        public List<object> notifications { get; set; }
        public bool invalid { get; set; }
        public bool valid { get; set; }
    }

    public class root
    {
        public bool success { get; set; }
        public string message { get; set; }
        public object messages { get; set; }
        public Data data { get; set; }
    }

}
