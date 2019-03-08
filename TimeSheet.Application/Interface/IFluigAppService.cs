﻿using TimeSheet.Domain.Enty;

namespace TimeSheet.Application.Interface
{
    public interface IFluigAppService
    {
        string[][] IniciarProcesso(string userCodFluig, string matricula, string filial, string GrupoGerencia, string codmarcacao);
        void SaveProcessIdFluigFechamento(string processId, string matricula, string codMarcacao);
        Marcacao VerificaExisteFechamentoFluig(string processId, string matricula, string codMarcacao);
        Usuario ObterUserCodFluig(string email);
        Usuario ObterUserGerencia(string centroCusto);
        void ValidarUserFluig(Usuario user);
        bool ValidaNovoProcesso(Marcacao marcacao);
        Marcacao ObterCodFluig(string codMarcacao);
        string[][] RestartProcesso(string userCodFluig, string matricula, string filial, string GrupoGerencia, string codmarcacao);
    }
}
