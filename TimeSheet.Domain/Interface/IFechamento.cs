using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;

namespace TimeSheet.Domain.Interface
{
    public interface IFechamento
    {
        void SalvarFechamento(Fechamento item, string filial, string dataProtheus, string matUser);
        List<Fechamento> ObterFechamento(string data, string matricula);
       
    }
}
