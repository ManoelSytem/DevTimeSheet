#pragma checksum "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2742423144dbd8d8022cc401ed553eb70a6d1b97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Configuracao_Index), @"mvc.1.0.view", @"/Views/Configuracao/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Configuracao/Index.cshtml", typeof(AspNetCore.Views_Configuracao_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\_ViewImports.cshtml"
using TimeSheet;

#line default
#line hidden
#line 2 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\_ViewImports.cshtml"
using TimeSheet.Models;

#line default
#line hidden
#line 3 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\_ViewImports.cshtml"
using TimeSheet.Domain.Util;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2742423144dbd8d8022cc401ed553eb70a6d1b97", @"/Views/Configuracao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ceead436462ab04d0d9f6d82b35d9afd345d5f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Configuracao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TimeSheet.ViewModel.ViewModelConfiguracao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
  
    ViewData["Title"] = "Configurações";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(161, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
 if (TempData["Createfalse"] != null)
{

#line default
#line hidden
            BeginContext(205, 312, true);
            WriteLiteral(@"    <div class=""card"">
        <div class=""alert alert-danger"">
            <strong><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Erro.  </font></font></strong><font style=""vertical-align: inherit;"">
                <font style=""vertical-align: inherit;"">
                    ");
            EndContext();
            BeginContext(518, 34, false);
#line 14 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
               Write(TempData["Createfalse"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(552, 77, true);
            WriteLiteral(";\r\n                </font>\r\n            </font>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 19 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
}

#line default
#line hidden
            BeginContext(632, 71, true);
            WriteLiteral("<div class=\"card azulc-azule\">\r\n    <div class=\"card-header\">\r\n        ");
            EndContext();
            BeginContext(704, 13, false);
#line 22 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(717, 492, true);
            WriteLiteral(@"
    </div>
    <div class=""card-body"">
        <table id=""tbConfiguracao"" class=""table table-striped table-bordered table-hover responsive nowrap"" cellspacing=""0"" width=""100%"">
            <thead>
                <tr>
                    <th>Código</th>
                    <th>Dia início</th>
                    <th>Dia fim</th>
                    <th>Código divergência</th>
                    <th>Ações</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 36 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
                 if (Model.First() != null)
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1345, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1408, 41, false);
#line 41 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1489, 44, false);
#line 42 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DiaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1573, 41, false);
#line 43 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DiaFim));

#line default
#line hidden
            EndContext();
            BeginContext(1614, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1654, 49, false);
#line 44 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CodDivergencia));

#line default
#line hidden
            EndContext();
            BeginContext(1703, 146, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-sm btn-visualizar\" name=\"visualizar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1849, "\"", 1938, 3);
            WriteAttributeValue("", 1859, "location.href=\'", 1859, 15, true);
#line 46 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
WriteAttributeValue("", 1874, Url.Action("Details", "Configuracao", new { id = item.Codigo}), 1874, 63, false);

#line default
#line hidden
            WriteAttributeValue("", 1937, "\'", 1937, 1, true);
            EndWriteAttribute();
            BeginContext(1939, 135, true);
            WriteLiteral("><i class=\"fas fa-eye\"></i></button>\r\n                                <button type=\"button\" class=\"btn btn-sm btn-editar\" name=\"editar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2074, "\"", 2160, 3);
            WriteAttributeValue("", 2084, "location.href=\'", 2084, 15, true);
#line 47 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
WriteAttributeValue("", 2099, Url.Action("Edit", "Configuracao", new { id = item.Codigo}), 2099, 60, false);

#line default
#line hidden
            WriteAttributeValue("", 2159, "\'", 2159, 1, true);
            EndWriteAttribute();
            BeginContext(2161, 137, true);
            WriteLiteral("><i class=\"fas fa-pen\"></i></button>\r\n                                <button type=\"button\" class=\"btn btn-sm btn-excluir\" name=\"excluir\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2298, "\"", 2386, 3);
            WriteAttributeValue("", 2308, "location.href=\'", 2308, 15, true);
#line 48 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
WriteAttributeValue("", 2323, Url.Action("Delete", "Configuracao", new { id = item.Codigo}), 2323, 62, false);

#line default
#line hidden
            WriteAttributeValue("", 2385, "\'", 2385, 1, true);
            EndWriteAttribute();
            BeginContext(2387, 106, true);
            WriteLiteral("><i class=\"fas fa-trash\"></i></button>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2535, 306, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<div class=""btn-ft"">
    <input type=""checkbox"" href=""#"" class=""btn-ft-open"" name=""btn-ft-open"" id=""btn-ft-open"" />
    <label class=""btn-ft-item-open"" for=""btn-ft-open"">
        <span><i class=""fas fa-plus""></i></span>
    </label>
    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2841, "\"", 2885, 1);
#line 63 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Configuracao\Index.cshtml"
WriteAttributeValue("", 2848, Url.Action("Create", "Configuracao"), 2848, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2886, 1222, true);
            WriteLiteral(@" class=""btn-ft-item"" tooltip=""Nova Configuração""><i class=""fas fa-plus""></i></a>
</div>

<script>
    $('#tbConfiguracao').DataTable({
        ""lengthMenu"": [[10, 25, 50, -1], [10, 25, 50, ""Todos""]],
        ""columnDefs"": [
            { className: ""text-left"", ""targets"": [0, 1] },
            { ""orderable"": false, ""targets"": [2] }
        ],
        ""language"": {
            ""decimal"": """",
            ""emptyTable"": ""Nenhum registro disponível na tabela"",
            ""info"": ""Visualizando _START_ de _END_ de _TOTAL_ registros"",
            ""infoEmpty"": ""Visualizando 0 de 0 de 0 registros"",
            ""infoFiltered"": ""(filtered from _MAX_ total entries)"",
            ""infoPostFix"": """",
            ""thousands"": "","",
            ""lengthMenu"": ""Mostrar _MENU_ registros"",
            ""loadingRecords"": ""Carregando..."",
            ""processing"": ""Processando..."",
            ""search"": ""Pesquisar:"",
            ""zeroRecords"": ""Nenhum registro correspondente encontrado"",
            ""paginate"":");
            WriteLiteral(" {\r\n                \"first\": \"Primeira\",\r\n                \"last\": \"Última\",\r\n                \"next\": \"Próxima\",\r\n                \"previous\": \"Anterior\"\r\n            }\r\n        },\r\n    });\r\n</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TimeSheet.ViewModel.ViewModelConfiguracao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
