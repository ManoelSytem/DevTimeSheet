#pragma checksum "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42aa1a890618b174de38b9b0351a57732ac49acc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Marcacao_Index), @"mvc.1.0.view", @"/Views/Marcacao/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Marcacao/Index.cshtml", typeof(AspNetCore.Views_Marcacao_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42aa1a890618b174de38b9b0351a57732ac49acc", @"/Views/Marcacao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ceead436462ab04d0d9f6d82b35d9afd345d5f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Marcacao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TimeSheet.ViewModel.ViewModelMacacao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
  
    ViewData["Title"] = "Marcações";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(152, 73, true);
            WriteLiteral("\r\n<div class=\"card azulc-azule\">\r\n    <div class=\"card-header\">\r\n        ");
            EndContext();
            BeginContext(226, 13, false);
#line 10 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(239, 416, true);
            WriteLiteral(@"
    </div>
    <div class=""card-body"">
        <table id=""tbCabecalhoMarcacao"" class=""table table-striped table-bordered table-hover responsive nowrap"" cellspacing=""0"" width=""100%"">
            <thead>
                <tr>
                    <th style="""">Mês/Ano</th>
                    <th>Status</th>
                    <th>Ações</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 22 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
                 if (Model != null)
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(783, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(830, 50, false);
#line 27 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AnoMesDescricao));

#line default
#line hidden
            EndContext();
            BeginContext(880, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 28 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
                     if (item.Status == "1")
                    {

#line default
#line hidden
            BeginContext(956, 172, true);
            WriteLiteral("                        <td>Aberto</td>\r\n                        <td>\r\n                            <button type=\"button\" class=\"btn btn-sm btn-visualizar\" name=\"visualizar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1128, "\"", 1213, 3);
            WriteAttributeValue("", 1138, "location.href=\'", 1138, 15, true);
#line 32 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 1153, Url.Action("Details", "Marcacao", new { id = item.Codigo}), 1153, 59, false);

#line default
#line hidden
            WriteAttributeValue("", 1212, "\'", 1212, 1, true);
            EndWriteAttribute();
            BeginContext(1214, 131, true);
            WriteLiteral("><i class=\"fas fa-eye\"></i></button>\r\n                            <button type=\"button\" class=\"btn btn-sm btn-editar\" name=\"editar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1345, "\"", 1427, 3);
            WriteAttributeValue("", 1355, "location.href=\'", 1355, 15, true);
#line 33 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 1370, Url.Action("Edit", "Marcacao", new { id = item.Codigo}), 1370, 56, false);

#line default
#line hidden
            WriteAttributeValue("", 1426, "\'", 1426, 1, true);
            EndWriteAttribute();
            BeginContext(1428, 133, true);
            WriteLiteral("><i class=\"fas fa-pen\"></i></button>\r\n                            <button type=\"button\" class=\"btn btn-sm btn-excluir\" name=\"excluir\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1561, "\"", 1617, 5);
            WriteAttributeValue("", 1571, "Delete(\'", 1571, 8, true);
#line 34 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 1579, item.Codigo, 1579, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1591, "\',\'", 1591, 3, true);
#line 34 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 1594, item.AnoMesDescricao, 1594, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 1615, "\')", 1615, 2, true);
            EndWriteAttribute();
            BeginContext(1618, 160, true);
            WriteLiteral("><i class=\"fas fa-trash\"></i></button>\r\n                            <button type=\"button\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Realizar Fechamento\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1778, "\"", 1875, 3);
            WriteAttributeValue("", 1788, "location.href=\'", 1788, 15, true);
#line 35 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 1803, Url.Action("ValidarFechamento", "Fechamento", new { id = item.Codigo}), 1803, 71, false);

#line default
#line hidden
            WriteAttributeValue("", 1874, "\'", 1874, 1, true);
            EndWriteAttribute();
            BeginContext(1876, 213, true);
            WriteLiteral(" class=\"btn btn-sm btn-aprovar\" name=\"lock\"><i class=\"fa fa-unlock-alt\"></i></button>\r\n                            <button type=\"button\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Imprimir espelho de ponto\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2089, "\"", 2182, 3);
            WriteAttributeValue("", 2099, "location.href=\'", 2099, 15, true);
#line 36 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 2114, Url.Action("EspelhoDePonto", "Relatorio", new { id = item.Codigo}), 2114, 67, false);

#line default
#line hidden
            WriteAttributeValue("", 2181, "\'", 2181, 1, true);
            EndWriteAttribute();
            BeginContext(2183, 103, true);
            WriteLiteral(" class=\"btn btn-sm btn-imprimir\"><i class=\"fas fa-print\"></i></button>\r\n                        </td>\r\n");
            EndContext();
#line 38 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"

                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2360, 164, true);
            WriteLiteral("                        <td>Fechado</td>\r\n                        <button type=\"button\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Imprimir espelho de ponto\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2524, "\"", 2617, 3);
            WriteAttributeValue("", 2534, "location.href=\'", 2534, 15, true);
#line 43 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 2549, Url.Action("EspelhoDePonto", "Relatorio", new { id = item.Codigo}), 2549, 67, false);

#line default
#line hidden
            WriteAttributeValue("", 2616, "\'", 2616, 1, true);
            EndWriteAttribute();
            BeginContext(2618, 254, true);
            WriteLiteral(" class=\"btn btn-sm btn-imprimir\"><i class=\"fas fa-print\"></i></button>\r\n                        <td><button type=\"button\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Fechado\" class=\"btn btn-sm\" name=\"lock\"><i class=\"fa fa-lock\"></i></button></td>\r\n");
            EndContext();
#line 45 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2895, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 47 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2960, 372, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<div id=""myModal"" role=""dialog"">
</div>
    <div class=""btn-ft"">
        <input type=""checkbox"" href=""#"" class=""btn-ft-open"" name=""btn-ft-open"" id=""btn-ft-open"" />
        <label class=""btn-ft-item-open"" for=""btn-ft-open"">
            <span><i class=""fas fa-plus""></i></span>
        </label>
        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3332, "\"", 3372, 1);
#line 61 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 3339, Url.Action("Create", "Marcacao"), 3339, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3373, 2945, true);
            WriteLiteral(@" class=""btn-ft-item"" tooltip=""Nova Marcação Diária""><i class=""fas fa-plus""></i></a>
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
        ");
            WriteLiteral(@"        ""zeroRecords"": ""Nenhum registro correspondente encontrado"",
                ""paginate"": {
                    ""first"": ""Primeira"",
                    ""last"": ""Última"",
                    ""next"": ""Próxima"",
                    ""previous"": ""Anterior""
                }
            },
        });

       
        function Delete(id, anodescricao) {
            $(""#myModal"").dialog({
                resizable: false,
                height: 200,
                title: ""Exclusão de Marcação"",
                modal: true,
                open: function () {
                    $(this).html(""Todos os lançamentos para "" + anodescricao + "" serão apagados, deseja excluír esta marcação?"");
                },
                buttons: {
                    ""Confirmar"": function () {
                        ExcluirMarcacao(id);
                        $(this).dialog(""close"");
                    },
                    Cancel: function () {
                        $(this).dialog(""close"");");
            WriteLiteral(@"
                    }
                },

            });

        }

        function ExcluirMarcacao(codmarcao) {
            $.ajax({
                type: ""post"",
                dataType: 'json',
                url: '/Marcacao/Excluir',
                data: { codigo: codmarcao }
            })
                .done(function (data) {
                    if (data.erro === true) {
                        Danger(data.msg)
                    } else {
                        Success(data.sucesso);
                        setTimeout(function () {
                            window.location.reload();
                        }, 5000);
                        
                    }
                })
                .fail(function (data) {
                    Danger(data.msg)
                });
            event.preventDefault();
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TimeSheet.ViewModel.ViewModelMacacao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
