using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;

namespace TimeSheet.Domain.Interface
{

    public interface IFluig 
    {
         Usuario ObterUsuarioFluig(string email);
    }
}
