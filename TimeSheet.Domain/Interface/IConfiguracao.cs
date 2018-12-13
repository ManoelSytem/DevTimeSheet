using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet.Domain.Enty.Interface
{
    public interface IConfiguracao
    {
        void AtualizarConfiguracao(Configuracao config);
        Configuracao ObterConfiguracao();
        Configuracao ObterConfiguracaoPorCodigo(string id);
        void SalvarConfiguracao(Configuracao config, string filial, string matricula);
        void DeleteConfiguracao(Configuracao configuracao);
        void SalvarTextoEmail(string texto);
    }
}
