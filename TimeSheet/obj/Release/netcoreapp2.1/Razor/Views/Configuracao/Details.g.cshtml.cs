#pragma checksum "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad4a786f4b85c47eec01c445783dbe9c8033072a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Configuracao_Details), @"mvc.1.0.view", @"/Views/Configuracao/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Configuracao/Details.cshtml", typeof(AspNetCore.Views_Configuracao_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad4a786f4b85c47eec01c445783dbe9c8033072a", @"/Views/Configuracao/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ceead436462ab04d0d9f6d82b35d9afd345d5f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Configuracao_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TimeSheet.ViewModel.ViewModelConfiguracao>
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
#line 3 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
  
    ViewData["Title"] = "Configurações";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 7 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
 if (TempData["CreateSucesso"] != null)
{

#line default
#line hidden
            BeginContext(192, 204, true);
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"body\">\r\n            <div class=\"alert alert-success\">\r\n                <strong>Configuração excluída!</strong>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 16 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
}

#line default
#line hidden
#line 16 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
  if (TempData["Createfalse"] != null)
{

#line default
#line hidden
            BeginContext(439, 311, true);
            WriteLiteral(@"    <div class=""card"">
        <div class=""alert alert-danger"">
            <strong><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Ops!  </font></font></strong><font style=""vertical-align: inherit;"">
                <font style=""vertical-align: inherit;"">
                    ");
            EndContext();
            BeginContext(751, 34, false);
#line 22 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
               Write(TempData["Createfalse"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(785, 77, true);
            WriteLiteral(";\r\n                </font>\r\n            </font>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 27 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
}

#line default
#line hidden
            BeginContext(865, 166, true);
            WriteLiteral("    <div class=\"my-row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"card azulc-azule\">\r\n                <div class=\"card-header\">\r\n                    ");
            EndContext();
            BeginContext(1032, 13, false);
#line 32 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
               Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1045, 67, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-body\">\r\n");
            EndContext();
#line 35 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                     using (Html.BeginForm())
                    {
                        

#line default
#line hidden
            BeginContext(1207, 23, false);
#line 37 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1257, 64, false);
#line 38 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1323, 739, true);
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
            BeginContext(2063, 115, false);
#line 49 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                           Write(Html.HiddenFor(model => model.Codigo, new { htmlAttributes = new { @class = "form-control", @placeholder = "", } }));

#line default
#line hidden
            EndContext();
            BeginContext(2178, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2213, 168, false);
#line 50 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                           Write(Html.EditorFor(model => model.DiaMesLimiteFecha, new { htmlAttributes = new { @class = "form-control col-md-6", @disabled = "disabled", @placeholder = "Dia do Mês" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2381, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2415, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e81bd6980f848dfa712b77e38712d12", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 51 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
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
            BeginContext(2487, 199, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-1 col-sm-4\">\r\n                                <label for=\"DiaFim\">Início</label>\r\n                                ");
            EndContext();
            BeginContext(2687, 157, false);
#line 55 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                           Write(Html.EditorFor(model => model.DiaInicio, new { htmlAttributes = new { @class = "form-control col-md-12", @disabled = "disabled", @placeholder = "Início" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2844, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2878, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e4fecbc74e04fd6878eaf76bedfc9ed", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 56 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
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
            BeginContext(2942, 196, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-2 col-sm-4\">\r\n                                <label for=\"DiaFim\">Fim</label>\r\n                                ");
            EndContext();
            BeginContext(3139, 151, false);
#line 60 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                           Write(Html.EditorFor(model => model.DiaFim, new { htmlAttributes = new { @class = "form-control  col-md-6", @disabled = "disabled", @placeholder = "Fim" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3290, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3325, 84, false);
#line 61 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                           Write(Html.ValidationMessageFor(model => model.DiaFim, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3409, 243, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-2 col-sm-4 coddivergencia\">\r\n                                <label for=\"DiaFim\">Código de divergência para atestado</label>\r\n                                ");
            EndContext();
            BeginContext(3653, 178, false);
#line 65 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                           Write(Html.EditorFor(model => model.CodDivergencia, new { htmlAttributes = new { @class = "form-control  col-md-12", @disabled = "disabled", @placeholder = "Código divergência..." } }));

#line default
#line hidden
            EndContext();
            BeginContext(3831, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3866, 92, false);
#line 66 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                           Write(Html.ValidationMessageFor(model => model.CodDivergencia, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3958, 646, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class=""row"">
                            <div class=""col-xs-6 col-sm-2""> <b>Configurações de email:</b></div>
                        </div>
                        <br />
                        <div class=""row"">
                            <div class=""col-xs-6 col-sm-2"">
                                <label for=""FrequenciaEmail"">
                                    Frequência de envio de email
                                </label>
                                ");
            EndContext();
            BeginContext(4605, 456, false);
#line 80 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                           Write(Html.DropDownListFor(model => model.Frequencia_email, new List<SelectListItem>
                                 {
                                   new SelectListItem { Text="Escolha a opção..", Value = "0"},
                                    new SelectListItem{ Text="Diário", Value = "1"},
                                    new SelectListItem{ Text="Semanal", Value = "2"}}, new { @class = "form-control grid-control" , @disabled = "disabled" }));

#line default
#line hidden
            EndContext();
            BeginContext(5061, 308, true);
            WriteLiteral(@"
                            </div>
                            <div class=""col-md-4 col-sm-4"">
                                <label for=""DiasEnvioEmail"">
                                    Dias para início do envio do e-mail
                                </label>
                                ");
            EndContext();
            BeginContext(5370, 173, false);
#line 90 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                           Write(Html.EditorFor(model => model.Qtddiadatafechamento, new { htmlAttributes = new { @class = "form-control col-md-4", @disabled = "disabled", @placeholder = "Ínicio envio" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5543, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(5578, 98, false);
#line 91 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Qtddiadatafechamento, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5676, 415, true);
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
            BeginContext(6092, 162, false);
#line 101 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                           Write(Html.EditorFor(model => model.AssuntoEmail, new { htmlAttributes = new { @class = "form-control  col-md-12", @disabled = "disabled", @placeholder = "Assunto" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6254, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(6289, 90, false);
#line 102 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                           Write(Html.ValidationMessageFor(model => model.AssuntoEmail, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6379, 349, true);
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
            BeginContext(6729, 151, false);
#line 110 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                           Write(Html.TextAreaFor(model => model.TextoEmail, new { @Id = "comentario", @class = "form-control comment", @disabled = "disabled", @cols = 50, @rows = 7 }));

#line default
#line hidden
            EndContext();
            BeginContext(6880, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(6915, 88, false);
#line 111 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                           Write(Html.ValidationMessageFor(model => model.TextoEmail, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(7003, 70, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 114 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(7096, 685, true);
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
    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7781, "\"", 7824, 1);
#line 136 "C:\Users\manoelneto\source\repos\DevTimeSheet\TimeSheet\Views\Configuracao\Details.cshtml"
WriteAttributeValue("", 7788, Url.Action("Index", "Configuracao"), 7788, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7825, 83, true);
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
