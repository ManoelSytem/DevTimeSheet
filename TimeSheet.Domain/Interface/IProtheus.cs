﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheet.Domain.Enty.Interface
{
    public interface IProtheus
    {
        IEnumerable<CodDivergencia> ObterListCodDivergenciaPordescricao(string descricao);
        CodDivergencia ObterCodigoDivergenciaPorCodigo(string cod);
        IEnumerable<Empreendimento> ObterListEmpreendimentos(string nome);
        List<Apontamento> ObterBatidasDePonto(string mat, string filial, string Data);
        Feriado ObterFeriadoPorDataLancamento(string data, string filial);
        Usuario ObterUsuarioNome(string mat);
        Usuario ObterCoordenadorPorCentroDeCusto(string centroCusto);
        Usuario ObterListColaboradorPorCentroDeCusto(string centroCusto);

    }
}
