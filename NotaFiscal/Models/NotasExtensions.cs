using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotaFiscal.Models
{
    public static class NotasExtensions
    {
        public static Notas ToUpload(this Notas nota)
        {
            return new Notas
            {
                Id = nota.Id,
                Owner = nota.Owner,
                NumeroNota = nota.NumeroNota,
                Serie = nota.Serie,
                IncideBC = nota.IncideBC,
                DataPrestacao = nota.DataPrestacao,
                DataEmissao = nota.DataEmissao,
                DataVencimento = nota.DataVencimento,
                Cfop = nota.Cfop,
                Modelo = nota.Modelo,
                TipoUtilizacao = nota.TipoUtilizacao,
                Observacao = nota.Observacao,
                
            };
        }
    }
}
