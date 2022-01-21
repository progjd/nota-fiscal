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
                owner = nota.owner,
                numeroNF = nota.numeroNF,
                serie = nota.serie,
                incideBC = nota.incideBC,
                dataPrestacao = nota.dataPrestacao,
                dataEmissao = nota.dataEmissao,
                diaVencimento = nota.diaVencimento,
                cfop = nota.cfop,
                modelo = nota.modelo,
                tipoUtilizacao = nota.tipoUtilizacao,
                obs = nota.obs,
                nfInicial = nota.nfInicial,
                geraPDF = nota.geraPDF,
                linkPDF = nota.linkPDF,
                cancelado = nota.cancelado,
                
            };
        }
    }
}
