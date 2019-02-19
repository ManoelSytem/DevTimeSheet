using TimeSheet.Domain.Enty;

namespace TimeSheet.Application
{
    public interface IFluigAppService
    {
        string[][] IniciarProcesso(string userCodFluig, string matricula, string filial, string projeto, string GrupoGerencia, string PoolGrupo);
        void SaveProcessIdFluigFechamento(string processId, string matricula, string codMarcacao);
        Marcacao VerificaExisteFechamentoFluig(string processId, string matricula, string codMarcacao);
        Usuario ObterUserCodFluig(string email);
    }
}
