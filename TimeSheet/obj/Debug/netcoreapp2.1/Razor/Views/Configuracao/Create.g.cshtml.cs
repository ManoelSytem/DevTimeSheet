#pragma checksum "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4abcb9398d9acc92d2babcbe79bddb189cea7bb4"
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
#line 1 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\_ViewImports.cshtml"
using TimeSheet;

#line default
#line hidden
#line 2 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\_ViewImports.cshtml"
using TimeSheet.Models;

#line default
#line hidden
#line 3 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\_ViewImports.cshtml"
using TimeSheet.Domain.Util;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4abcb9398d9acc92d2babcbe79bddb189cea7bb4", @"/Views/Configuracao/Create.cshtml")]
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
#line 3 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
  
    ViewData["Title"] = "Configurações";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 7 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
 if (TempData["CreateSucesso"] != null)
{

#line default
#line hidden
            BeginContext(192, 217, true);
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"body\">\r\n            <div class=\"alert alert-success\">\r\n                <strong>Configuração realizada com sucesso!</strong>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 16 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
}

#line default
#line hidden
#line 16 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
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
#line 22 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
               Write(TempData["Createfalse"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(798, 77, true);
            WriteLiteral(";\r\n                </font>\r\n            </font>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 27 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
}

#line default
#line hidden
            BeginContext(878, 166, true);
            WriteLiteral("    <div class=\"my-row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"card azulc-azule\">\r\n                <div class=\"card-header\">\r\n                    ");
            EndContext();
            BeginContext(1045, 13, false);
#line 32 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
               Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1058, 67, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-body\">\r\n");
            EndContext();
#line 35 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                     using (Html.BeginForm())
                    {
                        

#line default
#line hidden
            BeginContext(1220, 23, false);
#line 37 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1270, 64, false);
#line 38 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1336, 739, true);
            WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-xs-6 col-sm-2""></div>
                            <div class=""col-xs-6 col-sm-4"">Dia inícial e final do período de marcações:</div>
                            <!-- Optional: clear the XS cols if their content doesn't match in height -->
                            <div class=""clearfix visible-xs-block""></div>
                            <div class=""col-xs-6 col-sm-4""></div>
                        </div>
                        <div class=""row"">
                            <div class=""col-xs-6 col-sm-2"">
                                <label for=""DiaMesLimiteFecha"">Dia do mês limite fechamento</label>
                                ");
            EndContext();
            BeginContext(2076, 144, false);
#line 49 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                           Write(Html.EditorFor(model => model.DiaMesLimiteFecha, new { htmlAttributes = new { @class = "form-control col-md-6", @placeholder = "Dia do Mês" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2220, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2254, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b625712759b64a979d3638c63972a7a5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 50 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
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
            BeginContext(2326, 199, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-1 col-sm-4\">\r\n                                <label for=\"DiaFim\">Início</label>\r\n                                ");
            EndContext();
            BeginContext(2526, 133, false);
#line 54 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                           Write(Html.EditorFor(model => model.DiaInicio, new { htmlAttributes = new { @class = "form-control col-md-12", @placeholder = "Início" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2659, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2693, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99a30c6afd454d2e9198715f9262d7bf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 55 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
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
            BeginContext(2757, 196, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-2 col-sm-4\">\r\n                                <label for=\"DiaFim\">Fim</label>\r\n                                ");
            EndContext();
            BeginContext(2954, 127, false);
#line 59 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                           Write(Html.EditorFor(model => model.DiaFim, new { htmlAttributes = new { @class = "form-control  col-md-6", @placeholder = "Fim" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3081, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3116, 84, false);
#line 60 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.DiaFim, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3200, 311, true);
            WriteLiteral(@"
                            </div>
                            <div class=""col-md-2 col-sm-4 coddivergencia"">
                                <label for=""DiaFim"">Código de divergência para atestado</label>
                                <div class=""input-group mb-3"">
                                    ");
            EndContext();
            BeginContext(3512, 191, false);
#line 65 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                               Write(Html.EditorFor(model => model.CodDivergencia, new { htmlAttributes = new { @type = "text", @id = "searchInput", @class = "form-control  col-md-12", @placeholder = "Código divergência..." } }));

#line default
#line hidden
            EndContext();
            BeginContext(3703, 363, true);
            WriteLiteral(@"
                                    <div class=""input-group-append"">
                                        <button class=""btn btn-outline-secondary"" type=""button"" onclick=""CarregarEmpreendimentos();""><i class=""fas fa-search""></i></button>
                                    </div>

                                </div>
                                ");
            EndContext();
            BeginContext(4067, 92, false);
#line 71 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.CodDivergencia, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4159, 206, true);
            WriteLiteral("\r\n                            </div>\r\n                            <script>\r\n    $(\"#searchInput\").autocomplete({\r\n        source: function (request, response) {\r\n            $.ajax({\r\n                url: \'");
            EndContext();
            BeginContext(4366, 43, false);
#line 77 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                 Write(Url.Action("GetSearchValue","Configuracao"));

#line default
#line hidden
            EndContext();
            BeginContext(4409, 1138, true);
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
                            </script>
                        </div>
                        <br />
                        <br />
                        <div class=""row"">
                            <div class=""col-xs-6 col-sm-2""> <b>Configurações de Email:</b></div>
                        </div>
                        <br />
                        <div class=""row"">
                            <div class=""col-xs-6 col-sm-2"">
                                <label for=""FrequenciaEmail"">
                          ");
            WriteLiteral("          Frequência de envio de email\r\n                                </label>\r\n                                ");
            EndContext();
            BeginContext(5548, 431, false);
#line 104 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                           Write(Html.DropDownListFor(model => model.Frequencia_email, new List<SelectListItem>
                                 {
                                   new SelectListItem { Text="Escolha a opção..", Value = "0"},
                                    new SelectListItem{ Text="Diário", Value = "1"},
                                    new SelectListItem{ Text="Semanal", Value = "2"}}, new { @class = "form-control grid-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5979, 308, true);
            WriteLiteral(@"
                            </div>
                            <div class=""col-md-4 col-sm-4"">
                                <label for=""DiasEnvioEmail"">
                                    Dias para início do envio do e-mail
                                </label>
                                ");
            EndContext();
            BeginContext(6288, 149, false);
#line 114 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                           Write(Html.EditorFor(model => model.Qtddiadatafechamento, new { htmlAttributes = new { @class = "form-control col-md-4", @placeholder = "Início envio" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6437, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(6472, 98, false);
#line 115 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Qtddiadatafechamento, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6570, 415, true);
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
            BeginContext(6986, 138, false);
#line 125 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                           Write(Html.EditorFor(model => model.AssuntoEmail, new { htmlAttributes = new { @class = "form-control  col-md-12", @placeholder = "Assunto" } }));

#line default
#line hidden
            EndContext();
            BeginContext(7124, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(7159, 90, false);
#line 126 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.AssuntoEmail, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(7249, 349, true);
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
            BeginContext(7599, 127, false);
#line 134 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                           Write(Html.TextAreaFor(model => model.TextoEmail, new { @Id = "comentario", @class = "form-control comment", @cols = 50, @rows = 7 }));

#line default
#line hidden
            EndContext();
            BeginContext(7726, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(7761, 88, false);
#line 135 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.TextoEmail, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(7849, 70, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 138 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"

                    }

#line default
#line hidden
            BeginContext(7944, 793, true);
            WriteLiteral(@"                </div>
            </div>
        </div>
        <script>
            var Myeditor;
            ClassicEditor.create(document.querySelector('.comment'), {
                language: 'pt-br'
            }).then(editor => {
                Myeditor = editor;
                console.log(editor);
            }).catch(error => {
                console.error(error);
            });
        </script>
    </div>

<div class=""btn-ft"">
    <input type=""checkbox"" href=""#"" class=""btn-ft-open"" name=""btn-ft-open"" id=""btn-ft-open"" />
    <label class=""btn-ft-item-open"" for=""btn-ft-open"">
        <span><i class=""fas fa-plus""></i></span>
    </label>
    <a  onclick=""$('form').submit();"" class=""btn-ft-item"" tooltip=""Salvar""><i class=""fas fa-save""></i></a>
    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8737, "\"", 8780, 1);
#line 162 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Create.cshtml"
WriteAttributeValue("", 8744, Url.Action("Index", "Configuracao"), 8744, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8781, 83, true);
            WriteLiteral(" class=\"btn-ft-item\" tooltip=\"Voltar\"><i class=\"fas fa-arrow-left\"></i></a>\r\n</div>");
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
