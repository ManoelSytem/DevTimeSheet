using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheet.Domain.Enty
{
    public class Marcacao
    {
        public string Filial { get; set; }
        public string Codigo { get; set; }
        public string MatUsuario { get; set; }
        public string AnoMes { get; set; }
        public string Status { get; set; }
        public string CodLancamento { get; set; }
        public string codigojornada { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public string CodigoFluig { get; set; }
        public virtual List<Lancamento> Lancamentolist { get; set; }
       

        public void ValidarAbeturaMarcacaoExiste(List<Marcacao> listmarcacao, string ano, string mes)
        {
            foreach (Marcacao MarcacaoResult in listmarcacao)
            {
                if(MarcacaoResult.AnoMes == ano+mes && MarcacaoResult.Status == "1")
                {
                    throw new Exception("Existe marcação aberta para a data informada! Favor verificar");
                }
            }
        }
        public string AbeturaExiste(List<Marcacao> listmarcacao, string mes, string ano)
        {
           string codigo = "0";
            foreach (Marcacao MarcacaoResult in listmarcacao)
            {
                if (MarcacaoResult.AnoMes == ano + mes && MarcacaoResult.Status == "1")
                {
                    codigo = MarcacaoResult.Codigo;
                }
                if (MarcacaoResult.AnoMes == ano + mes && MarcacaoResult.Status == "2")
                {
                    throw new Exception("Não é possivel realizar novos lançamentos! O período se encontra fechado.");
                }

            }

            return codigo;
        }

        public void MarcacaoExiste(string codigoAbertura)
        {
            if (codigoAbertura != "0")
            {
                throw new Exception("Existe marcação aberta para a data informada! Favor verificar");
            }
        }

        public void ValidaMarcacaoFoiFechada(Marcacao marcacao)
        {
            if (marcacao.Status == "2")
            {
                throw new Exception("Marcação se encontra fechada!");
            }
        }


    }
}
