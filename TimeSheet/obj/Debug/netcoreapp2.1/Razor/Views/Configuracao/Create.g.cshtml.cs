#pragma checksum "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb99d67b2f6764f2a77be35cd00315d1da0767be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Configuracao_Create), @"mvc.1.0.view", @"/Views/Configuracao/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Configuracao/Create.cshtml", typeof(AspNetCore.Views_Configuracao_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb99d67b2f6764f2a77be35cd00315d1da0767be", @"/Views/Configuracao/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ceead436462ab04d0d9f6d82b35d9afd345d5f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Configuracao_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TimeSheet.ViewModel.ViewModelConfiguracao>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
  
    ViewData["Title"] = "Configurações";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 7 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
 if (TempData["CreateSucesso"] != null)
{

#line default
#line hidden
            BeginContext(192, 217, true);
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"body\">\r\n            <div class=\"alert alert-success\">\r\n                <strong>Configuração realizada com sucesso!</strong>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 16 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
}

#line default
#line hidden
#line 16 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
  if (TempData["Createfalse"] != null)
{

#line default
#line hidden
            BeginContext(452, 311, true);
            WriteLiteral(@"    <div class=""card"">
        <div class=""alert alert-danger"">
            <strong><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Ops!  </font></font></strong><font style=""vertical-align: inherit;"">
                <font style=""vertical-align: inherit;"">
                    ");
            EndContext();
            BeginContext(764, 34, false);
#line 22 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
               Write(TempData["Createfalse"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(798, 77, true);
            WriteLiteral(";\r\n                </font>\r\n            </font>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 27 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
}

#line default
#line hidden
            BeginContext(878, 146, true);
            WriteLiteral("<div class=\"my-row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card azulc-azule\">\r\n            <div class=\"card-header\">\r\n                ");
            EndContext();
            BeginContext(1025, 13, false);
#line 32 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
           Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1038, 59, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n");
            EndContext();
#line 35 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                 using (Html.BeginForm())
                {
                    

#line default
#line hidden
            BeginContext(1180, 23, false);
#line 37 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1226, 64, false);
#line 38 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 489, true);
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-sm-2"">
                            <label for=""DiaMesLimiteFecha"">
                                Dia do mês limite fechamento
                                <span data-toggle=""tooltip"" data-placement=""right""><i title=""Último dia do mês para os colaboradores realizarem o fechamento das marcações."" class='fas fa-info-circle'></i></span>
                            </label>
                            ");
            EndContext();
            BeginContext(1782, 135, false);
#line 45 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                       Write(Html.EditorFor(model => model.DiaMesLimiteFecha, new { htmlAttributes = new { @class = "form-control", @placeholder = "Dia do Mês" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1917, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1947, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d374f0fef016457ebeefb3a7005e07dd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 46 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DiaMesLimiteFecha);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2019, 363, true);
            WriteLiteral(@"
                        </div>

                        <div class=""col-sm-1"">
                            <span data-toggle=""tooltip"" data-placement=""right""><i title=""Dia inicial e final, para apontamento das marcações."" class='fas fa-info-circle'></i></span>
                            <label for=""DiaFim"">Dia início</label>
                            ");
            EndContext();
            BeginContext(2383, 123, false);
#line 52 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                       Write(Html.EditorFor(model => model.DiaInicio, new { htmlAttributes = new { @class = "form-control", @placeholder = "Início" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2506, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2536, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0370a40cfdd46cba244b36d465e55cb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 53 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DiaInicio);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2600, 175, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-1\">\r\n                            <label for=\"DiaFim\">Dia fim</label>\r\n                            ");
            EndContext();
            BeginContext(2776, 117, false);
#line 57 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                       Write(Html.EditorFor(model => model.DiaFim, new { htmlAttributes = new { @class = "form-control", @placeholder = "Fim" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2893, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2924, 84, false);
#line 58 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                       Write(Html.ValidationMessageFor(model => model.DiaFim, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3008, 454, true);
            WriteLiteral(@"
                        </div>
                        <div class=""col-md-2 col-sm-4 coddivergencia"">
                            <label for=""DiaFim"">Código de divergência</label>
                            <span data-toggle=""tooltip"" data-placement=""right""><i title=""Código de divergência para aprovação da GERHU."" class='fas fa-info-circle'></i></span>
                            <div class=""input-group mb-3"">
                                ");
            EndContext();
            BeginContext(3463, 191, false);
#line 64 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                           Write(Html.EditorFor(model => model.CodDivergencia, new { htmlAttributes = new { @type = "text", @id = "searchInput", @class = "form-control  col-md-12", @placeholder = "Código divergência..." } }));

#line default
#line hidden
            EndContext();
            BeginContext(3654, 341, true);
            WriteLiteral(@"
                                <div class=""input-group-append"">
                                    <button class=""btn btn-outline-secondary"" type=""button"" onclick=""CarregarEmpreendimentos();""><i class=""fas fa-search""></i></button>
                                </div>
                            </div>
                            ");
            EndContext();
            BeginContext(3996, 92, false);
#line 69 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                       Write(Html.ValidationMessageFor(model => model.CodDivergencia, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4088, 787, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <br />
                    <br />
                    <div class=""row"">
                        <div class=""col-xs-6 col-sm-2""> <b>Configurações de e-mail:</b></div>
                    </div>
                    <br />
                    <div class=""row"">
                        <div class=""col-xs-6 col-sm-2"">
                            <label for=""FrequenciaEmail"">
                                Frequência de envio de e-mail
                                <span data-toggle=""tooltip"" data-placement=""right""><i title=""É a frequência de envio do e-mail de aviso sobre fechamento."" class='fas fa-info-circle'></i></span>
                            </label>
                            ");
            EndContext();
            BeginContext(4876, 415, false);
#line 84 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                       Write(Html.DropDownListFor(model => model.Frequencia_email, new List<SelectListItem>
                             {
                               new SelectListItem { Text="Escolha a opção..", Value = "0"},
                                new SelectListItem{ Text="Diário", Value = "1"},
                                new SelectListItem{ Text="Semanal", Value = "2"}}, new { @class = "form-control grid-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5291, 824, true);
            WriteLiteral(@"
                        </div>
                        <div class=""col-md-4 col-sm-4"">
                            <label for=""DiasEnvioEmail"">
                                Dias para início do envio do e-mail
                                <span  data-toggle=""tooltip"" data-placement=""right""><i title=""Quantidade de dias, antes do fechamento para inicio do envio do e-mail. 
Funciona casado com os campos Dia do mês limite fechamento e Frequência de envio de e-mail.
Ex.: Dia do mês fechamento for 10, Frequência de envio de e-mail = Semanal, Dias para início do envio do e-mail = 20
        Semanalmente, a partir do dia 21 o tecnico começará a receber e-mail avisando quer precisa fechar o timesheet.""  class='fas fa-info-circle'></i></span>
                            </label>
                            ");
            EndContext();
            BeginContext(6116, 149, false);
#line 98 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                       Write(Html.EditorFor(model => model.Qtddiadatafechamento, new { htmlAttributes = new { @class = "form-control col-md-4", @placeholder = "Início envio" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6265, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(6296, 98, false);
#line 99 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Qtddiadatafechamento, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6394, 375, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <br />
                    <br />
                    <div class=""row"">
                        <div class=""col-xs-6 col-sm-6"">
                            <label for=""TextoEmail"">
                                Assunto
                            </label>
                            ");
            EndContext();
            BeginContext(6770, 138, false);
#line 109 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                       Write(Html.EditorFor(model => model.AssuntoEmail, new { htmlAttributes = new { @class = "form-control  col-md-12", @placeholder = "Assunto" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6908, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(6939, 90, false);
#line 110 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                       Write(Html.ValidationMessageFor(model => model.AssuntoEmail, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(7029, 317, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-xs-6 col-sm-6"">
                            <label for=""TextoEmail"">
                                Texto
                            </label>
                            ");
            EndContext();
            BeginContext(7347, 127, false);
#line 118 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                       Write(Html.TextAreaFor(model => model.TextoEmail, new { @Id = "comentario", @class = "form-control comment", @cols = 50, @rows = 7 }));

#line default
#line hidden
            EndContext();
            BeginContext(7474, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(7505, 88, false);
#line 119 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                       Write(Html.ValidationMessageFor(model => model.TextoEmail, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(7593, 62, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 122 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"

                }

#line default
#line hidden
            BeginContext(7676, 407, true);
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<div class=""btn-ft"">
    <input type=""checkbox"" href=""#"" class=""btn-ft-open"" name=""btn-ft-open"" id=""btn-ft-open"" />
    <label class=""btn-ft-item-open"" for=""btn-ft-open"">
        <span><i class=""fas fa-plus""></i></span>
    </label>
    <a onclick=""$('form').submit();"" class=""btn-ft-item"" tooltip=""Salvar""><i class=""fas fa-save""></i></a>
    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8083, "\"", 8126, 1);
#line 134 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
WriteAttributeValue("", 8090, Url.Action("Index", "Configuracao"), 8090, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8127, 227, true);
            WriteLiteral(" class=\"btn-ft-item\" tooltip=\"Voltar\"><i class=\"fas fa-arrow-left\"></i></a>\r\n</div>\r\n\r\n<script>\r\n    $(\"#searchInput\").autocomplete({\r\n        source: function (request, response) {\r\n            $.ajax({\r\n                url: \'");
            EndContext();
            BeginContext(8355, 43, false);
#line 141 "C:\Users\manoelneto\Desktop\TimeSheet\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                 Write(Url.Action("GetSearchValue","Configuracao"));

#line default
#line hidden
            EndContext();
            BeginContext(8398, 861, true);
            WriteLiteral(@"',
                dataType: ""json"",
                data: { search: $(""#searchInput"").val() },
                success: function (data) {
                    response($.map(data, function (item) {
                        return {label: item.codigo+""-""+item.descricao, value: item.codigo};
                    }));
                },
                error: function (xhr, status, error) {
                    alert(""Error"");
                }
            });
        }
    });

    var Myeditor;
    ClassicEditor.create(document.querySelector('.comment'), {
        language: 'pt-br'
    }).then(editor => {
        Myeditor = editor;
        console.log(editor);
    }).catch(error => {
        console.error(error);
        });

    $(document).ready(function () {
        $('[data-toggle=""tooltip""]').tooltip();
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TimeSheet.ViewModel.ViewModelConfiguracao> Html { get; private set; }
    }
}
#pragma warning restore 1591
