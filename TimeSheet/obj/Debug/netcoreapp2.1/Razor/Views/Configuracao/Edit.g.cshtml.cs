#pragma checksum "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adaac166e7a3de0332f0369a08d8e5adee81d7d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Configuracao_Edit), @"mvc.1.0.view", @"/Views/Configuracao/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Configuracao/Edit.cshtml", typeof(AspNetCore.Views_Configuracao_Edit))]
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
#line 1 "C:\DevTimeSheet\TimeSheet\Views\_ViewImports.cshtml"
using TimeSheet;

#line default
#line hidden
#line 2 "C:\DevTimeSheet\TimeSheet\Views\_ViewImports.cshtml"
using TimeSheet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adaac166e7a3de0332f0369a08d8e5adee81d7d1", @"/Views/Configuracao/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d7036a8495e566242915d53879884387daf7875", @"/Views/_ViewImports.cshtml")]
    public class Views_Configuracao_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TimeSheet.ViewModel.ViewModelConfiguracao>
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
#line 3 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
  
    ViewData["Title"] = "Edição de Configuração";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
 if (TempData["CreateSucesso"] != null)
{

#line default
#line hidden
            BeginContext(203, 216, true);
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"body\">\r\n            <div class=\"alert alert-success\">\r\n                <strong>Atualização realizada com sucesso!</strong>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 17 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
}

#line default
#line hidden
#line 17 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
  if (TempData["Createfalse"] != null)
{

#line default
#line hidden
            BeginContext(462, 346, true);
            WriteLiteral(@"    <div class=""card"">
        <div class=""alert alert-danger"">
            <strong><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Ops! ocorreu algum problema no sistema.  </font></font></strong><font style=""vertical-align: inherit;"">
                <font style=""vertical-align: inherit;"">
                    ");
            EndContext();
            BeginContext(809, 34, false);
#line 23 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
               Write(TempData["Createfalse"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(843, 77, true);
            WriteLiteral(";\r\n                </font>\r\n            </font>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 28 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(923, 146, true);
            WriteLiteral("<div class=\"my-row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card azulc-azule\">\r\n            <div class=\"card-header\">\r\n                ");
            EndContext();
            BeginContext(1070, 13, false);
#line 33 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
           Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1083, 59, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n");
            EndContext();
#line 36 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                 using (Html.BeginForm())
                {
                    

#line default
#line hidden
            BeginContext(1225, 23, false);
#line 38 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1271, 64, false);
#line 39 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 695, true);
            WriteLiteral(@"                    <div class=""row"">
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
            BeginContext(2033, 114, false);
#line 50 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                       Write(Html.HiddenFor(model => model.Codigo, new { htmlAttributes = new { @class = "form-control", @placeholder = "",} }));

#line default
#line hidden
            EndContext();
            BeginContext(2147, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2178, 144, false);
#line 51 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                       Write(Html.EditorFor(model => model.DiaMesLimiteFecha, new { htmlAttributes = new { @class = "form-control col-md-6", @placeholder = "Dia do Mês" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2322, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2352, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a25164304a74110a781385b9efe4328", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 52 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
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
            BeginContext(2424, 183, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-1 col-sm-4\">\r\n                            <label for=\"DiaFim\">Ínicio</label>\r\n                            ");
            EndContext();
            BeginContext(2608, 133, false);
#line 56 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                       Write(Html.EditorFor(model => model.DiaInicio, new { htmlAttributes = new { @class = "form-control col-md-12", @placeholder = "Ínicio" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2741, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2771, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ecb20370b4a4328b164c20a8b28633d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 57 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
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
            BeginContext(2835, 180, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-2 col-sm-4\">\r\n                            <label for=\"DiaFim\">Fim</label>\r\n                            ");
            EndContext();
            BeginContext(3016, 127, false);
#line 61 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                       Write(Html.EditorFor(model => model.DiaFim, new { htmlAttributes = new { @class = "form-control  col-md-6", @placeholder = "Fim" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3143, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3174, 84, false);
#line 62 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.DiaFim, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3258, 227, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-2 col-sm-4 coddivergencia\">\r\n                            <label for=\"DiaFim\">Código de divergência para atestado</label>\r\n                            ");
            EndContext();
            BeginContext(3486, 154, false);
#line 66 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                       Write(Html.EditorFor(model => model.CodDivergencia, new { htmlAttributes = new { @class = "form-control  col-md-12", @placeholder = "Código divergência..." } }));

#line default
#line hidden
            EndContext();
            BeginContext(3640, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3671, 92, false);
#line 67 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.CodDivergencia, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3763, 590, true);
            WriteLiteral(@"
                        </div>
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
                                Frequência de envio de email
                            </label>
                            ");
            EndContext();
            BeginContext(4354, 415, false);
#line 81 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                       Write(Html.DropDownListFor(model => model.Frequencia_email, new List<SelectListItem>
                             {
                               new SelectListItem { Text="Escolha a opção..", Value = "0"},
                                new SelectListItem{ Text="Diário", Value = "1"},
                                new SelectListItem{ Text="Semanal", Value = "2"}}, new { @class = "form-control grid-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4769, 284, true);
            WriteLiteral(@"
                        </div>
                        <div class=""col-md-4 col-sm-4"">
                            <label for=""DiasEnvioEmail"">
                                Dias para início do envio do e-mail
                            </label>
                            ");
            EndContext();
            BeginContext(5054, 149, false);
#line 91 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Qtddiadatafechamento, new { htmlAttributes = new { @class = "form-control col-md-4", @placeholder = "Ínicio envio" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5203, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(5234, 98, false);
#line 92 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Qtddiadatafechamento, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5332, 375, true);
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
            BeginContext(5708, 138, false);
#line 102 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                       Write(Html.EditorFor(model => model.AssuntoEmail, new { htmlAttributes = new { @class = "form-control  col-md-12", @placeholder = "Assunto" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5846, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(5877, 90, false);
#line 103 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.AssuntoEmail, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5967, 317, true);
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
            BeginContext(6285, 108, false);
#line 111 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                       Write(Html.TextAreaFor(model => model.TextoEmail, new { @class = "form-control required", @cols = 50, @rows = 7 }));

#line default
#line hidden
            EndContext();
            BeginContext(6393, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(6424, 88, false);
#line 112 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.TextoEmail, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6512, 62, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 115 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"

                }

#line default
#line hidden
            BeginContext(6595, 409, true);
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
            BeginWriteAttribute("href", " href=\"", 7004, "\"", 7047, 1);
#line 128 "C:\DevTimeSheet\TimeSheet\Views\Configuracao\Edit.cshtml"
WriteAttributeValue("", 7011, Url.Action("Index", "Configuracao"), 7011, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7048, 83, true);
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