#pragma checksum "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8edd32fa7be2d3034661c72dfc7c36760e31e7ce"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8edd32fa7be2d3034661c72dfc7c36760e31e7ce", @"/Views/Marcacao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ceead436462ab04d0d9f6d82b35d9afd345d5f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Marcacao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TimeSheet.ViewModel.ViewModelMacacao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
  
    ViewData["Title"] = "Marcações";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(152, 73, true);
            WriteLiteral("\r\n<div class=\"card azulc-azule\">\r\n    <div class=\"card-header\">\r\n        ");
            EndContext();
            BeginContext(226, 13, false);
#line 10 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(239, 451, true);
            WriteLiteral(@"
    </div>
    <div class=""card-body"">
        <table id=""tbCabecalhoMarcacao"" class=""table table-striped table-bordered table-hover responsive nowrap"" cellspacing=""0"" width=""100%"">
            <thead>
                <tr>
                    <th>data</th>
                    <th style="""">Mês/Ano</th>
                    <th>Status</th>
                    <th>Ações</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 23 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
                   var count = 0;
                    

#line default
#line hidden
#line 24 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
                     if (Model != null)
                    {
                        foreach (var item in Model)
                        {
                            count++;

#line default
#line hidden
            BeginContext(907, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(978, 5, false);
#line 30 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
                               Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(983, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1027, 50, false);
#line 31 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.AnoMesDescricao));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 32 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
                                 if (item.Status == "1")
                                {

#line default
#line hidden
            BeginContext(1177, 236, true);
            WriteLiteral("                                    <td>Aberto</td>\r\n                                    <td>\r\n                                        <button type=\"button\" class=\"btn btn-sm btn-visualizar\" name=\"visualizar\" title=\"Visualizar Marcação\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1413, "\"", 1498, 3);
            WriteAttributeValue("", 1423, "location.href=\'", 1423, 15, true);
#line 36 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 1438, Url.Action("Details", "Marcacao", new { id = item.Codigo}), 1438, 59, false);

#line default
#line hidden
            WriteAttributeValue("", 1497, "\'", 1497, 1, true);
            EndWriteAttribute();
            BeginContext(1499, 167, true);
            WriteLiteral("><i class=\"fas fa-eye\"></i></button>\r\n                                        <button type=\"button\" class=\"btn btn-sm btn-editar\" name=\"editar\" title=\"Editar Marcação\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1666, "\"", 1748, 3);
            WriteAttributeValue("", 1676, "location.href=\'", 1676, 15, true);
#line 37 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 1691, Url.Action("Edit", "Marcacao", new { id = item.Codigo}), 1691, 56, false);

#line default
#line hidden
            WriteAttributeValue("", 1747, "\'", 1747, 1, true);
            EndWriteAttribute();
            BeginContext(1749, 170, true);
            WriteLiteral("><i class=\"fas fa-pen\"></i></button>\r\n                                        <button type=\"button\" class=\"btn btn-sm btn-excluir\" name=\"excluir\" title=\"Excluir Marcação\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1919, "\"", 1975, 5);
            WriteAttributeValue("", 1929, "Delete(\'", 1929, 8, true);
#line 38 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 1937, item.Codigo, 1937, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1949, "\',\'", 1949, 3, true);
#line 38 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 1952, item.AnoMesDescricao, 1952, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 1973, "\')", 1973, 2, true);
            EndWriteAttribute();
            BeginContext(1976, 172, true);
            WriteLiteral("><i class=\"fas fa-trash\"></i></button>\r\n                                        <button type=\"button\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Realizar Fechamento\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2148, "\"", 2186, 3);
            WriteAttributeValue("", 2158, "ConfirmaFerias(", 2158, 15, true);
#line 39 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 2173, item.Codigo, 2173, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2185, ")", 2185, 1, true);
            EndWriteAttribute();
            BeginContext(2187, 182, true);
            WriteLiteral(" class=\"btn btn-sm btn-aprovar\" name=\"lock\"><i class=\"fa fa-unlock-alt\"></i></button>\r\n                                        <button type=\"button\" title=\"Imprimir espelho de ponto\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2369, "\"", 2409, 3);
            WriteAttributeValue("", 2379, "setaDadosModal(\'", 2379, 16, true);
#line 40 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 2395, item.Codigo, 2395, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2407, "\')", 2407, 2, true);
            EndWriteAttribute();
            BeginContext(2410, 167, true);
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#myModalRelatorio\" class=\"btn btn-sm btn-imprimir\"><i class=\"fas fa-print\"></i></button>\r\n                                    </td>\r\n");
            EndContext();
#line 42 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"

                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2687, 237, true);
            WriteLiteral("                                    <td>Fechado</td>\r\n                                    <td>\r\n                                        <button type=\"button\" class=\"btn btn-sm btn-visualizar\" name=\"visualizar\" title=\"Visualizar Marcação\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2924, "\"", 3009, 3);
            WriteAttributeValue("", 2934, "location.href=\'", 2934, 15, true);
#line 48 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 2949, Url.Action("Details", "Marcacao", new { id = item.Codigo}), 2949, 59, false);

#line default
#line hidden
            WriteAttributeValue("", 3008, "\'", 3008, 1, true);
            EndWriteAttribute();
            BeginContext(3010, 322, true);
            WriteLiteral(@"><i class=""fas fa-eye""></i></button>
                                        <button type=""button"" data-toggle=""tooltip"" data-placement=""top"" title=""Fechado"" class=""btn btn-sm"" name=""lock""><i class=""fa fa-lock""></i></button>
                                        <button type=""button"" title=""Imprimir espelho de ponto""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3332, "\"", 3372, 3);
            WriteAttributeValue("", 3342, "setaDadosModal(\'", 3342, 16, true);
#line 50 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 3358, item.Codigo, 3358, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 3370, "\')", 3370, 2, true);
            EndWriteAttribute();
            BeginContext(3373, 167, true);
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#myModalRelatorio\" class=\"btn btn-sm btn-imprimir\"><i class=\"fas fa-print\"></i></button>\r\n                                    </td>\r\n");
            EndContext();
#line 52 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"

                                }

#line default
#line hidden
            BeginContext(3577, 35, true);
            WriteLiteral("                            </tr>\r\n");
            EndContext();
#line 55 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(3681, 753, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>
<div class=""modal"" id=""myModalRelatorio"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Seleção de Relatório</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""col-md-12"">
                    <div class=""form-group"">
                        <select id=""comboRelatorio"" class=""form-control"">
                            ");
            EndContext();
            BeginContext(4434, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6947a9b2ff9644a590bc9fe38fc3815d", async() => {
                BeginContext(4442, 9, true);
                WriteLiteral("Selecione");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4460, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4490, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b5a5acf15594cbf9931e60c3bb1cdbf", async() => {
                BeginContext(4508, 9, true);
                WriteLiteral("Analítico");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4526, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4556, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02d4524709c8435ebd60dbd2bc42a7f7", async() => {
                BeginContext(4574, 9, true);
                WriteLiteral("Sintético");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4592, 853, true);
            WriteLiteral(@"
                        </select>
                        <input disabled=""disabled"" style=""display:none""  type=""text"" name=""campo"" id=""codmarcacao"">
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button onclick=""GerarRelatorio()"" type=""button"" class=""btn btn-primary"">Gerar Relatório</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Sair</button>
            </div>
        </div>
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
            BeginWriteAttribute("href", " href=\"", 5445, "\"", 5485, 1);
#line 100 "C:\Users\manoelneto\Desktop\TimeSheetTeste\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 5452, Url.Action("Create", "Marcacao"), 5452, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5486, 3967, true);
            WriteLiteral(@" class=""btn-ft-item"" tooltip=""Nova Marcação Diária""><i class=""fas fa-plus""></i></a>
    </div>

    <script>

        function setaDadosModal(valor) {
            document.getElementById('codmarcacao').value = valor;
        };

        function GerarRelatorio() {
            var selecionado  = $(""#comboRelatorio option:selected"").val();
            if (selecionado === '1') {
                window.open('/Relatorio/EspelhoDePonto/' + document.getElementById('codmarcacao').value, '_blank');
            }
            if (selecionado === '2') {
                window.open('/Relatorio/EspelhoDePontoSintetico/'  + document.getElementById('codmarcacao').value, '_blank');
            }
           
    };

    $('#tbCabecalhoMarcacao').DataTable({
        ""columnDefs"": [
            {
                ""targets"": [0],
                ""visible"": false
            },
            {
                ""order"": [[0, ""desc""]]
            } 
        ],
        ""language"": {
            ""decimal"": """);
            WriteLiteral(@""",
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
           ");
            WriteLiteral(@" open: function () {
                $(this).html(""Todos os lançamentos para "" + anodescricao + "" serão apagados, deseja excluír esta marcação?"");
            },
            buttons: {
                ""Confirmar"": function () {
                    ExcluirMarcacao(id);
                    $(this).dialog(""close"");
                },
                Cancel: function () {
                    $(this).dialog(""close"");
                }
            },

        });

    }

      function ConfirmaFerias(id) {
            $(""#myModal"").dialog({
                resizable: false,
                height: 200,
                title: ""Confirmar férias"",
                modal: true,
                open: function () {
                    $(this).html(""Colaborador se encontra de férias?"");
                },
                buttons: {
                    ""Sim"": function () {
                        window.location.href = '/Fechamento/ConfirmacaoFerias/'+id;
                    },
                ");
            WriteLiteral(@"    ""Não"": function () {
                        window.location.href = '/Fechamento/ValidarFechamento/'+id;
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
