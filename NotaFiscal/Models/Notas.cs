using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotaFiscal.Models
{
    public class Notas
    {
        public string Owner { get; set; }
        public int NumeroNota { get; set; }
        public string Serie { get; set; }
        public bool IncideBC { get; set; }
        public string DataPrestacao { get; set; }
        public string DataEmissao { get; set; }
        public int DataVencimento { get; set; }
        public int Cfop { get; set; }
        public int Modelo { get; set; }
        public int TipoUtilizacao { get; set; }
        public string Observacao { get; set; }
    
    }

    public class Destinatario
    {
        public string RazaoSocial { get; set; }
        public string logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public int Cep { get; set; }
        public int Cpf { get; set; }
        public string Ierg { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public int TipoCliente { get; set; }
        public int CodigoMuncipio { get; set; }
        public string CodigoIdentificacao { get; set; }
      
    }
    class Responsavel
    {
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Ierg { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public int CodigoMuncipio { get; set; }
        public string Uf { get; set; }
        public int Cep { get; set; }
   
    }
}
