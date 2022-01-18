using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotaFiscal.Models
{
    //Nota myDeserializedClass = JsonConvert.DeserializeObject<Nota>(myJsonResponse);
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
        public int telefone { get; set; }
        public string email { get; set; }
        public int tipoCliente { get; set; }
        public int codigoMunicipio { get; set; }
        public string codigoIdentificacao { get; set; }
    }

    public class Responsavel
    {
        public string nomeFantasia { get; set; }
        public string razaoSocial { get; set; }
        public string cnpjcpf { get; set; }
        public string ie { get; set; }
        public string email { get; set; }
        public int telefone { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string municipio { get; set; }
        public int codigoMunicipio { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
    }

    public class Item
    {
        public string codigoitem { get; set; }
        public string descricaoitem { get; set; }
        public string unidade { get; set; }
        public int quantidadeContratada { get; set; }
        public int quantidadeFornecida { get; set; }
        public int quantidadeFaturada { get; set; }
        public int valorUnit { get; set; }
        public int aliquotaICMS { get; set; }
        public int reducao { get; set; }
        public int aliquotaPIS { get; set; }
        public int aliquotaCOFINS { get; set; }
        public int aliqValorTribFederais { get; set; }
        public int aliqValorTribEstaduais { get; set; }
        public int aliqValorTribMunicipais { get; set; }
        public int desconto { get; set; }
        public int outrosValores { get; set; }
        public int codigoClassificacao { get; set; }
        public int tipoIsencao { get; set; }
        public int tarifa { get; set; }
        public string indicacaoDescJudicial { get; set; }
        public string numeroContrato { get; set; }
        public List<string> infoAdicional { get; set; }
    }

    public class Notas
    {
        public int Id { get; set; }
        public string owner { get; set; }
        public int numeroNF { get; set; }
        public string serie { get; set; }
        public bool incideBC { get; set; }
        public string dataPrestacao { get; set; }
        public string dataEmissao { get; set; }
        public int diaVencimento { get; set; }
        public int cfop { get; set; }
        public int modelo { get; set; }
        public int tipoUtilizacao { get; set; }
        public string obs { get; set; }
        public Destinatario destinatario { get; set; }
        public Responsavel responsavel { get; set; }
        public Item item { get; set; }
        public List<Item> itens { get; set; }
        public int nfInicial { get; set; }
        public bool cancelado { get; set; }
        public bool geraPDF { get; set; }
        public string linkPDF { get; set; }
    }


}
