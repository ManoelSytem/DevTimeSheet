using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;

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

        public static string GetClaim(this ClaimsPrincipal user, string key) => user.Claims.FirstOrDefault(c => c.Type == key).Value;

        public static string GetSubjectId(this ClaimsPrincipal user) => user.Claims.FirstOrDefault(c => c.Type == "sub")?.Value.ToUpper();
        public static string[] GetPerfil(this ClaimsPrincipal user) => user.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value.ToUpper()).ToArray();
        public static bool CointainsPerfil(this ClaimsPrincipal user, string perfil) => user.GetPerfil().Any(x => x == perfil);

        public static string ToDateProtheusConvert(this string data) => data.Substring(6, 4) + data.Substring(3, 2) + data.Substring(0, 2);
        public static string ToDateProtheus(this string data) => data.Substring(0, 4) + data.Substring(5, 2) + data.Substring(8, 2);
        public static string ToDateProtheusReverse(this string data) => data.Substring(8, 2) + "/" + data.Substring(5, 2) + "/" + data.Substring(0, 4);
        public static string ToDateProtheusReverseformate(this string data) => data.Substring(6, 2) + "/" + data.Substring(4, 2) + "/" + data.Substring(0, 4);
        public static string ToShortDateProtheus(this string data) => data.Substring(0, 4) + data.Substring(5, 2);
        public static string ToDia(this string data) => data.Substring(5, 2);
        public static string ToAno(this string data) => data.Substring(0, 4);
        public static string ReplaceSaveObservacaoProthues(this string Observacao) => !String.IsNullOrWhiteSpace(Observacao) ? Regex.Replace(Observacao, @"\r\n?|\n", $"{(char)10}{(char)13}") : new string(' ', 252);

    }
}

