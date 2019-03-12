using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheet.ViewModel
{
    public class ViewModelConfiguracao 
    {
        public int Codigo { get; set; }
        public string FilialProtheus { get; set; }
        public string MatriculaUsuario { get; set; }
        public int DiaMesLimiteFecha { get; set; }
        public int Frequencia_email { get; set; }
        public int Qtddiadatafechamento { get; set; }
        public int DiaInicio { get; set; }
        public int DiaFim { get; set; }
        public string AssuntoEmail { get; set; }
        public string TextoEmail { get; set; }
        public string Matricula { get; set; }
        public string CodDivergencia { get; set; }
        

      
        public ViewModelConfiguracao()
        {
        }

        public void ValidarDiaInicioFim()
        {

            if (this.DiaInicio <= this.DiaFim & this.DiaFim >= this.DiaInicio);
            else
                throw new Exception("Período informado estar incorreto");
        }

        public void ValidarDatalimiteEntrePeriodo()
        {
            if (this.DiaMesLimiteFecha <= this.DiaFim);
            else
                throw new Exception("Dia mês limite fechamento fora do período");
        }

        public void ValidarDiaEnvioEmail()
        {
            if (this.DiaMesLimiteFecha <= this.DiaFim);
            else
                throw new Exception("Dia envio email fora do período");
        }

        public void ValidarFrequenciaSelecionada()
        {
            if (this.Frequencia_email == 0)
                throw new Exception("Selecione a frequência de envio de email");
            else;
        }


    }


    public class CodDivergenciaViewModel
    {
        public int? codigo { get; set; }
        public string Descricao { get; set; }
        public string Constant { get; set; }

        public CodDivergenciaViewModel(int _codigo, string _desc, string _constant)
        {
            this.codigo = _codigo;
            this.Descricao = _desc;
            this.Constant = _constant;
        }

        public CodDivergenciaViewModel()
        {
        }
        public void ValidaCodigoDivergencia(Object codDivergencia) {

            if (codDivergencia == null) throw new Exception("Código de divergência não encontrado");
                
        }

        public void ValidaCodigoDivergenciaConstante(string constat, int? codigo)
        {
            if (codigo == null) { }
                else  if(constat == null)
                throw new Exception("Código de divergência não autorizado.");
        }

        public string ValidaConfiguracaoExiste(string erro)
        {
            if (erro.Substring(0, 9) == "ORA-00001") {
                return "Já existe uma configuração ativa";
            }                
            return null;
        }
    }
}
