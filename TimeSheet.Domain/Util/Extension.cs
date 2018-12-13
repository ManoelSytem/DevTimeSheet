using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace TimeSheet.Domain.Util
{
    public static class Extension
    {
        public static string GetDados(this ClaimsPrincipal user, string key)
        {
            foreach (var dado in user.Claims.Where(c => c.Type == "dados"))
                if (dado.Value.Split(';')[0] == key)
                    return dado.Value.Split(';')[1];
            return null;
        }

        public static string GetSubjectId(this ClaimsPrincipal user) => user.Claims.FirstOrDefault(c => c.Type == "sub")?.Value.ToUpper();
        public static string[] GetPerfil(this ClaimsPrincipal user) => user.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value.ToUpper()).ToArray();
        public static bool CointainsPerfil(this ClaimsPrincipal user, string perfil) => user.GetPerfil().Any(x => x == perfil);
       
    }
}
