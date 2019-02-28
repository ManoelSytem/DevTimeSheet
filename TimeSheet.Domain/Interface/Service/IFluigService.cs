using TimeSheet.Domain.Enty;

namespace TimeSheet.Domain.Interface.Service
{
    public interface IFluigService
    {
        string[][] IniciarProcesso(FluigProcess fluigProcess);
        Usuario ObterUserCodPorEmailFluig(string email);
        Marcacao ObterCodFluig(string codMarcacao, string codFluig);
        Marcacao ObterMarcacaoFechamentoFluig(string processId, string matricula, string codMarcacao);
        void SalvarIdProcessoFluig(string CodMarcacao, string processId);
        Usuario ObterUserGerencia(string centroCusto);

    }
}
