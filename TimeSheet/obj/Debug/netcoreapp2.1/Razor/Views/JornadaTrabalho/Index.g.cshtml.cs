#pragma checksum "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f591325df3c59b6efc65963cde22b820268c08a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JornadaTrabalho_Index), @"mvc.1.0.view", @"/Views/JornadaTrabalho/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JornadaTrabalho/Index.cshtml", typeof(AspNetCore.Views_JornadaTrabalho_Index))]
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
#line 1 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\_ViewImports.cshtml"
using TimeSheet;

#line default
#line hidden
#line 2 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\_ViewImports.cshtml"
using TimeSheet.Models;

#line default
#line hidden
#line 3 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\_ViewImports.cshtml"
using TimeSheet.Domain.Util;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f591325df3c59b6efc65963cde22b820268c08a", @"/Views/JornadaTrabalho/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ceead436462ab04d0d9f6d82b35d9afd345d5f4", @"/Views/_ViewImports.cshtml")]
    public class Views_JornadaTrabalho_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TimeSheet.ViewModel.ViewModelCadastroHora>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"
  
    ViewData["Title"] = "Cadastro de Jornada";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(160, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"
 if (TempData["Createfalse"] != null)
{

#line default
#line hidden
            BeginContext(204, 312, true);
            WriteLiteral(@"    <div class=""card"">
        <div class=""alert alert-danger"">
            <strong><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Erro.  </font></font></strong><font style=""vertical-align: inherit;"">
                <font style=""vertical-align: inherit;"">
                    ");
            EndContext();
            BeginContext(517, 34, false);
#line 14 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"
               Write(TempData["Createfalse"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(551, 77, true);
            WriteLiteral(";\r\n                </font>\r\n            </font>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 19 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"
}

#line default
#line hidden
            BeginContext(631, 71, true);
            WriteLiteral("<div class=\"card azulc-azule\">\r\n    <div class=\"card-header\">\r\n        ");
            EndContext();
            BeginContext(703, 13, false);
#line 22 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(716, 469, true);
            WriteLiteral(@"
    </div>
    <div class=""card-body"">
        <table id=""tbCabecalhoMarcacao"" class=""table table-striped table-bordered table-hover responsive nowrap"" cellspacing=""0"" width=""100%"">
            <thead>
                <tr>
                    <th>Código</th>
                    <th>Descrição da Jornada</th>
                    <th>Período da Jornada</th>
                    <th>Ações</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 35 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"
                 if (Model != null)
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1313, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1376, 41, false);
#line 40 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(1417, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1457, 46, false);
#line 41 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DescJornada));

#line default
#line hidden
            EndContext();
            BeginContext(1503, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1543, 39, false);
#line 42 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"
                           Write(item.DataInicio?.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1582, 11, true);
            WriteLiteral("    até    ");
            EndContext();
            BeginContext(1594, 36, false);
#line 42 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"
                                                                              Write(item.DataFim?.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1630, 147, true);
            WriteLiteral(" </td>\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-sm btn-visualizar\" name=\"visualizar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1777, "\"", 1869, 3);
            WriteAttributeValue("", 1787, "location.href=\'", 1787, 15, true);
#line 44 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"
WriteAttributeValue("", 1802, Url.Action("Details", "JornadaTrabalho", new { id = item.Codigo}), 1802, 66, false);

#line default
#line hidden
            WriteAttributeValue("", 1868, "\'", 1868, 1, true);
            EndWriteAttribute();
            BeginContext(1870, 135, true);
            WriteLiteral("><i class=\"fas fa-eye\"></i></button>\r\n                                <button type=\"button\" class=\"btn btn-sm btn-editar\" name=\"editar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2005, "\"", 2094, 3);
            WriteAttributeValue("", 2015, "location.href=\'", 2015, 15, true);
#line 45 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"
WriteAttributeValue("", 2030, Url.Action("Edit", "JornadaTrabalho", new { id = item.Codigo}), 2030, 63, false);

#line default
#line hidden
            WriteAttributeValue("", 2093, "\'", 2093, 1, true);
            EndWriteAttribute();
            BeginContext(2095, 137, true);
            WriteLiteral("><i class=\"fas fa-pen\"></i></button>\r\n                                <button type=\"button\" class=\"btn btn-sm btn-excluir\" name=\"excluir\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2232, "\"", 2323, 3);
            WriteAttributeValue("", 2242, "location.href=\'", 2242, 15, true);
#line 46 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"
WriteAttributeValue("", 2257, Url.Action("Delete", "JornadaTrabalho", new { id = item.Codigo}), 2257, 65, false);

#line default
#line hidden
            WriteAttributeValue("", 2322, "\'", 2322, 1, true);
            EndWriteAttribute();
            BeginContext(2324, 106, true);
            WriteLiteral("><i class=\"fas fa-trash\"></i></button>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 49 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"

                    }
                }

#line default
#line hidden
            BeginContext(2474, 306, true);
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
            BeginWriteAttribute("href", " href=\"", 2780, "\"", 2834, 1);
#line 62 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\Index.cshtml"
WriteAttributeValue("", 2787, Url.Action("CadastrarHora", "JornadaTrabalho"), 2787, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2835, 1227, true);
            WriteLiteral(@" class=""btn-ft-item"" tooltip=""Cadastrar Horas""><i class=""fas fa-plus""></i></a>
</div>

<script>
    $('#tbCabecalhoMarcacao').DataTable({
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
            ""paginat");
            WriteLiteral("e\": {\r\n                \"first\": \"Primeira\",\r\n                \"last\": \"Última\",\r\n                \"next\": \"Próxima\",\r\n                \"previous\": \"Anterior\"\r\n            }\r\n        },\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TimeSheet.ViewModel.ViewModelCadastroHora>> Html { get; private set; }
    }
}
#pragma warning restore 1591
