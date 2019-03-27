using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TimeSheetDirectmail.Model;
using TimeSheetDirectmail.Repository;

namespace TimeSheetDirectmail.Controller
{
    public class Controlle
    {
        private ProtheusRepository _repositoryProthues;
        private static string Local = "Z:/";
        private static string Arquivo = "textEmail.rdf";
       

        public Controlle(ProtheusRepository repositoryProthues)
        {
            _repositoryProthues = repositoryProthues;
        }

        public void EnviarEmail(string email, string usuario, string mesagem)
        {
          
           Notificacao notificacao = new Notificacao();
           Configuracao config = new Configuracao();
           config  =  _repositoryProthues.ObterConfiguracao();
           notificacao.EnviarEmail(email, mesagem, config.AssuntoEmail);


            if (config.ValidaDataEnvioEmail())
            {
               if(config.Frequencia_email == 1)
                {

                    notificacao.EnviarEmail(email, mesagem, config.AssuntoEmail);
                }
                else
                { 
                    if(config.Qtddiadatafechamento == DateTime.Now.Day | DateTime.Now.DayOfWeek == DayOfWeek.Sunday
                    &&
                    DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                    {
                        notificacao.EnviarEmail(email, mesagem, config.AssuntoEmail);
                    }
                }

            }    
           
        }

        public string[] Leitura()
        {
            string[] lines = null;
            if (!Directory.Exists(Local + Arquivo))
            {
                string local = Local.Substring(0, 3);
                lines = File.ReadAllLines(local+ Arquivo);
                return lines;
            }

            return lines;
        }

        public string Login(string usuario, string senha)
        {
           var disco = DiscoveryClient.GetAsync("http://localhost:8081").GetAwaiter().GetResult();
           var tokenClient = new TokenClient(disco.TokenEndpoint, "Timesheet.Client", "timesheetSecret");
           var tokenResponse =  tokenClient.RequestResourceOwnerPasswordAsync(usuario, senha, string.Join(" ", Scopes)).GetAwaiter().GetResult();

            return tokenResponse.AccessToken;
        }

        private static readonly string[] Scopes = {
            "Timesheet",
            "permissions",
            "dados",
            "openid",
            ClaimTypes.Role,
            ClaimTypes.Name,
            ClaimTypes.Email,
        };

        public IEnumerable<Usuario> ObterTecnicos(string token, string contratada)
        {
            HttpClient Client = new HttpClient();
            IList<Usuario> tecnicos = new List<Usuario>();
            Client.SetBearerToken(token);

           
            var response = Client.GetAsync($"http://localhost:8081/api/usuarios/obterporperfil?Perfil={Constante.COLABORADOR}").GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var usuarios = JArray.Parse(content).Where(up => up["usuarioPerfil"].Any(p => p["perfil"]["nome"].ToString().ToUpper() == Constante.COLABORADOR));
                foreach (var item in usuarios)
                {
                    tecnicos.Add(new Usuario()
                    {
                        Id = Guid.Parse(item["id"].ToString()),
                        SubjectId = item["id"].ToString().ToUpper(),
                        Nome = item["nome"].ToString(),
                        Email = item["email"].ToString()
                    });
                }
            }
            return tecnicos;
        }
    }

}
