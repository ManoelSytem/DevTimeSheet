using TimeSheet.Domain.Enty;

namespace TimeSheet.Domain.Interface.Service
{
    public interface IFluigService
    {
        string[][] IniciarProcesso(FluigProcess fluigProcess);
        Fechamento SalvarIdProcessoFluig(string processId);
        Usuario ObterUserCodPorEmailFluig(string email);
        Marcacao ObterMarcacaoFechamentoFluig(string processId, string matricula, string codMarcacao);
    }
}
