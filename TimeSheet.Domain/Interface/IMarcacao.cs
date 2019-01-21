﻿using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;

namespace TimeSheet.Domain.Interface
{
    public interface IMarcacao 
    {
        void SalvarMarcacao(Marcacao item);
        void AtualizarMarcacao(Marcacao item);
        void DeleteMarcacao(string codigo);
        List<Marcacao> ObterListMarcacaoPorMatUser(string mat);
        List<Marcacao> ObterListMarcacaoPorCodigo(string codigo);
        Marcacao ObterMarcacao(string codigo);
    }
}