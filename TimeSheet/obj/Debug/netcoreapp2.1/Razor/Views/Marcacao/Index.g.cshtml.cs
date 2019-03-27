#pragma checksum "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8f6cc6c4a0b6ec29ecdc16b1c7a71a6a5048292"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f6cc6c4a0b6ec29ecdc16b1c7a71a6a5048292", @"/Views/Marcacao/Index.cshtml")]
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
            BeginContext(956, 200, true);
            WriteLiteral("                        <td>Aberto</td>\r\n                        <td>\r\n                            <button type=\"button\" class=\"btn btn-sm btn-visualizar\" name=\"visualizar\" title=\"Visualizar Marcação\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1156, "\"", 1241, 3);
            WriteAttributeValue("", 1166, "location.href=\'", 1166, 15, true);
#line 32 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 1181, Url.Action("Details", "Marcacao", new { id = item.Codigo}), 1181, 59, false);

#line default
#line hidden
            WriteAttributeValue("", 1240, "\'", 1240, 1, true);
            EndWriteAttribute();
            BeginContext(1242, 155, true);
            WriteLiteral("><i class=\"fas fa-eye\"></i></button>\r\n                            <button type=\"button\" class=\"btn btn-sm btn-editar\" name=\"editar\" title=\"Editar Marcação\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1397, "\"", 1479, 3);
            WriteAttributeValue("", 1407, "location.href=\'", 1407, 15, true);
#line 33 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 1422, Url.Action("Edit", "Marcacao", new { id = item.Codigo}), 1422, 56, false);

#line default
#line hidden
            WriteAttributeValue("", 1478, "\'", 1478, 1, true);
            EndWriteAttribute();
            BeginContext(1480, 158, true);
            WriteLiteral("><i class=\"fas fa-pen\"></i></button>\r\n                            <button type=\"button\" class=\"btn btn-sm btn-excluir\" name=\"excluir\" title=\"Excluir Marcação\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1638, "\"", 1694, 5);
            WriteAttributeValue("", 1648, "Delete(\'", 1648, 8, true);
#line 34 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 1656, item.Codigo, 1656, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1668, "\',\'", 1668, 3, true);
#line 34 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 1671, item.AnoMesDescricao, 1671, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 1692, "\')", 1692, 2, true);
            EndWriteAttribute();
            BeginContext(1695, 160, true);
            WriteLiteral("><i class=\"fas fa-trash\"></i></button>\r\n                            <button type=\"button\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Realizar Fechamento\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1855, "\"", 1952, 3);
            WriteAttributeValue("", 1865, "location.href=\'", 1865, 15, true);
#line 35 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 1880, Url.Action("ValidarFechamento", "Fechamento", new { id = item.Codigo}), 1880, 71, false);

#line default
#line hidden
            WriteAttributeValue("", 1951, "\'", 1951, 1, true);
            EndWriteAttribute();
            BeginContext(1953, 170, true);
            WriteLiteral(" class=\"btn btn-sm btn-aprovar\" name=\"lock\"><i class=\"fa fa-unlock-alt\"></i></button>\r\n                            <button type=\"button\" title=\"Imprimir espelho de ponto\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2123, "\"", 2163, 3);
            WriteAttributeValue("", 2133, "setaDadosModal(\'", 2133, 16, true);
#line 36 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 2149, item.Codigo, 2149, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2161, "\')", 2161, 2, true);
            EndWriteAttribute();
            BeginContext(2164, 155, true);
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#myModalRelatorio\" class=\"btn btn-sm btn-imprimir\"><i class=\"fas fa-print\"></i></button>\r\n                        </td>\r\n");
            EndContext();
#line 38 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"

                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2393, 201, true);
            WriteLiteral("                        <td>Fechado</td>\r\n                        <td>\r\n                            <button type=\"button\" class=\"btn btn-sm btn-visualizar\" name=\"visualizar\" title=\"Visualizar Marcação\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2594, "\"", 2679, 3);
            WriteAttributeValue("", 2604, "location.href=\'", 2604, 15, true);
#line 44 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 2619, Url.Action("Details", "Marcacao", new { id = item.Codigo}), 2619, 59, false);

#line default
#line hidden
            WriteAttributeValue("", 2678, "\'", 2678, 1, true);
            EndWriteAttribute();
            BeginContext(2680, 298, true);
            WriteLiteral(@"><i class=""fas fa-eye""></i></button>
                            <button type=""button"" data-toggle=""tooltip"" data-placement=""top"" title=""Fechado"" class=""btn btn-sm"" name=""lock""><i class=""fa fa-lock""></i></button>
                            <button type=""button"" title=""Imprimir espelho de ponto""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2978, "\"", 3018, 3);
            WriteAttributeValue("", 2988, "setaDadosModal(\'", 2988, 16, true);
#line 46 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 3004, item.Codigo, 3004, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 3016, "\')", 3016, 2, true);
            EndWriteAttribute();
            BeginContext(3019, 155, true);
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#myModalRelatorio\" class=\"btn btn-sm btn-imprimir\"><i class=\"fas fa-print\"></i></button>\r\n                        </td>\r\n");
            EndContext();
#line 48 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"

                    }

#line default
#line hidden
            BeginContext(3199, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 51 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(3264, 753, true);
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
            BeginContext(4017, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8342e8c724a44d50ab775fcf4e52b23a", async() => {
                BeginContext(4025, 9, true);
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
            BeginContext(4043, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4073, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0b7e216b1bc416da3394a165795ca77", async() => {
                BeginContext(4091, 9, true);
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
            BeginContext(4109, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4139, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7a777ebe80c4da8b148f7167e991283", async() => {
                BeginContext(4157, 9, true);
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
            BeginContext(4175, 853, true);
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
            BeginWriteAttribute("href", " href=\"", 5028, "\"", 5068, 1);
#line 95 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Marcacao\Index.cshtml"
WriteAttributeValue("", 5035, Url.Action("Create", "Marcacao"), 5035, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5069, 3251, true);
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
        ""lengthMenu"": [[10, 25, 50, -1], [10, 25, 50, ""Todos""]],
        ""columnDefs"": [
            { className: ""text-left"", ""targets"": [0, 1] },
            { ""orderable"": false, ""targets"": [2] }
        ],
        ""language"": {
            ""de");
            WriteLiteral(@"cimal"": """",
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
            WriteLiteral(@"          open: function () {
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
");
            WriteLiteral("\n                }\r\n            })\r\n            .fail(function (data) {\r\n                Danger(data.msg)\r\n            });\r\n        event.preventDefault();\r\n    }\r\n    </script>\r\n");
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
