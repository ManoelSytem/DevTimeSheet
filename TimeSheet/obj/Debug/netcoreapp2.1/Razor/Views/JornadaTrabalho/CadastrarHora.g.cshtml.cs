#pragma checksum "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "346e7b9ff0d92f479f78b6d34e15d38a71c9f39d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JornadaTrabalho_CadastrarHora), @"mvc.1.0.view", @"/Views/JornadaTrabalho/CadastrarHora.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JornadaTrabalho/CadastrarHora.cshtml", typeof(AspNetCore.Views_JornadaTrabalho_CadastrarHora))]
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
#line 3 "C:\DevTimeSheet\TimeSheet\Views\_ViewImports.cshtml"
using TimeSheet.Domain.Util;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"346e7b9ff0d92f479f78b6d34e15d38a71c9f39d", @"/Views/JornadaTrabalho/CadastrarHora.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ceead436462ab04d0d9f6d82b35d9afd345d5f4", @"/Views/_ViewImports.cshtml")]
    public class Views_JornadaTrabalho_CadastrarHora : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TimeSheet.ViewModel.ViewModelCadastroHora>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/relogio.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Smiley face"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("42"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("42"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/intervalo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
  
    ViewData["Title"] = "Cadastro de Horas";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(152, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
 if (TempData["CreateSucesso"] != null)
{

#line default
#line hidden
            BeginContext(198, 213, true);
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"body\">\r\n            <div class=\"alert alert-success\">\r\n                <strong>Cadastro realizado com sucesso!</strong>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 17 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
}

#line default
#line hidden
#line 17 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
  if (TempData["Createfalse"] != null)
{

#line default
#line hidden
            BeginContext(454, 311, true);
            WriteLiteral(@"    <div class=""card"">
        <div class=""alert alert-danger"">
            <strong><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Ops!  </font></font></strong><font style=""vertical-align: inherit;"">
                <font style=""vertical-align: inherit;"">
                    ");
            EndContext();
            BeginContext(766, 34, false);
#line 23 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
               Write(TempData["Createfalse"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(800, 77, true);
            WriteLiteral(";\r\n                </font>\r\n            </font>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 28 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
}

#line default
#line hidden
            BeginContext(880, 146, true);
            WriteLiteral("<div class=\"my-row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card azulc-azule\">\r\n            <div class=\"card-header\">\r\n                ");
            EndContext();
            BeginContext(1027, 13, false);
#line 33 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
           Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1040, 59, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n");
            EndContext();
#line 36 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
                 using (Html.BeginForm())
                {
                    

#line default
#line hidden
            BeginContext(1182, 23, false);
#line 38 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1228, 64, false);
#line 39 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 663, true);
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-xs-6 col-sm-4""></div>
                        <div class=""col-xs-6 col-sm-4"">Período da Jornada:</div>
                        <!-- Optional: clear the XS cols if their content doesn't match in height -->
                        <div class=""clearfix visible-xs-block""></div>
                        <div class=""col-xs-6 col-sm-4""></div>
                    </div>
                    <div class=""row"">
                        <div class=""col-xs-6 col-sm-4"">
                            <label for=""DescricaodaJornada"">Descrição da Jornada</label>
                            ");
            EndContext();
            BeginContext(1958, 152, false);
#line 50 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
                       Write(Html.EditorFor(model => model.DescJornada, new { htmlAttributes = new { @class = "form-control col-md-12", @placeholder = "Descrição da Jornada..." } }));

#line default
#line hidden
            EndContext();
            BeginContext(2110, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2140, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adfa5798b58d42fcbbf5d6884ba70694", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 51 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DescJornada);

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
            BeginContext(2206, 192, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-2 col-sm-4\">\r\n                            <label for=\"DataInicio\">Data início</label>\r\n                            ");
            EndContext();
            BeginContext(2399, 115, false);
#line 55 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
                       Write(Html.EditorFor(model => model.DataInicio, new { htmlAttributes = new { @class = "form-control", @type = "date" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2514, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2544, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52d406228704443dade507bf0810309d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 56 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DataInicio);

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
            BeginContext(2609, 186, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-2 col-sm-4\">\r\n                            <label for=\"DataFim\">Data fim</label>\r\n                            ");
            EndContext();
            BeginContext(2796, 112, false);
#line 60 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
                       Write(Html.EditorFor(model => model.DataFim, new { htmlAttributes = new { @class = "form-control", @type = "date" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2908, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2939, 85, false);
#line 61 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
                       Write(Html.ValidationMessageFor(model => model.DataFim, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3024, 357, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <br />
                    <div class=""row"">
                        <div class=""col-xs-6 col-sm-2"">
                            <label for=""JornadaDiaria"">
                                Jornada diária
                            </label>
                            ");
            EndContext();
            BeginContext(3382, 112, false);
#line 70 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
                       Write(Html.EditorFor(model => model.JornadaDiaria, new {  htmlAttributes = new { @class = "form-control col-md-6" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3494, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3524, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b2c81fa043e425390dde661180f46a8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 71 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.JornadaDiaria);

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
            BeginContext(3592, 181, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <br />\r\n                    <br />\r\n                    <div class=\"row\">\r\n                        ");
            EndContext();
            BeginContext(3773, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b37bf4421d2d4d9d97dd3b94b821fd36", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3846, 435, true);
            WriteLiteral(@"
                        <div class=""col-xs-6 col-sm-2""><h3>Horários</h3></div>
                    </div>
                    <br />
                    <div style=""align-content='center'"" class=""row"">
                        <div class=""col-xs-6 col-sm-1"">
                            <label for=""HoraInicioDe"">
                                Hora início de
                            </label>
                            ");
            EndContext();
            BeginContext(4282, 149, false);
#line 86 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
                       Write(Html.EditorFor(model => model.HoraInicioDe, new { htmlAttributes = new { @type = "time", @class = "form-control col-md-12", @placeholder = "..." } }));

#line default
#line hidden
            EndContext();
            BeginContext(4431, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4461, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adf8c75bf5dd419098d230cd2ef2365e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 87 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HoraInicioDe);

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
            BeginContext(4528, 263, true);
            WriteLiteral(@"
                        </div>
                        <div class=""col-md-1 col-sm-4"">
                            <label for=""HoraInicioAte"">
                                Hora início até
                            </label>
                            ");
            EndContext();
            BeginContext(4792, 150, false);
#line 93 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
                       Write(Html.EditorFor(model => model.HoraInicioAte, new { htmlAttributes = new { @type = "time", @class = "form-control col-md-12", @placeholder = "..." } }));

#line default
#line hidden
            EndContext();
            BeginContext(4942, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4972, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f867c67ae48141d2b46b74b6a86291f7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 94 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HoraInicioAte);

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
            BeginContext(5040, 254, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-1 col-sm-4\">\r\n                            <label for=\"HoraFinal\">\r\n                                Hora final\r\n                            </label>\r\n                            ");
            EndContext();
            BeginContext(5295, 146, false);
#line 100 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
                       Write(Html.EditorFor(model => model.HoraFinal, new { htmlAttributes = new { @type = "time", @class = "form-control col-md-12", @placeholder = "..." } }));

#line default
#line hidden
            EndContext();
            BeginContext(5441, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(5471, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41605351a4194fc5ad34e6ffdc1319bc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 101 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HoraFinal);

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
            BeginContext(5535, 153, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <br />\r\n                    <div class=\"row\">\r\n                        ");
            EndContext();
            BeginContext(5688, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ed7b39bbcd944d0b950d03d6bd5d680", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5763, 428, true);
            WriteLiteral(@"
                        <div class=""col-xs-6 col-sm-2""><h3>Intervalos</h3></div>
                    </div>
                    <br />
                    <div style=""align-content='center'"" class=""row"">
                        <div class=""col-xs-6 col-sm-1"">
                            <label for=""interInicio"">
                                Início
                            </label>
                            ");
            EndContext();
            BeginContext(6192, 148, false);
#line 115 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
                       Write(Html.EditorFor(model => model.InterInicio, new { htmlAttributes = new { @type = "time", @class = "form-control col-md-12", @placeholder = "..." } }));

#line default
#line hidden
            EndContext();
            BeginContext(6340, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(6370, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5c41e5c4f3849578fd40b407eba797c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 116 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.InterInicio);

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
            BeginContext(6436, 246, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-1 col-sm-4\">\r\n                            <label for=\"interFim\">\r\n                                Fim\r\n                            </label>\r\n                            ");
            EndContext();
            BeginContext(6683, 145, false);
#line 122 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
                       Write(Html.EditorFor(model => model.InterFim, new { htmlAttributes = new { @type = "time", @class = "form-control col-md-12", @placeholder = "..." } }));

#line default
#line hidden
            EndContext();
            BeginContext(6828, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(6858, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "790e68d06dfa4940ab0f2aa9f2d9b1d6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 123 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.InterFim);

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
            BeginContext(6921, 249, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-1 col-sm-4\">\r\n                            <label for=\"interMin\">\r\n                                Mínimo\r\n                            </label>\r\n                            ");
            EndContext();
            BeginContext(7171, 145, false);
#line 129 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
                       Write(Html.EditorFor(model => model.InterMin, new { htmlAttributes = new { @type = "time", @class = "form-control col-md-12", @placeholder = "..." } }));

#line default
#line hidden
            EndContext();
            BeginContext(7316, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(7346, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b432b3c6d92f4fb48686daffd786c72c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 130 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.InterMin);

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
            BeginContext(7409, 249, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-1 col-sm-4\">\r\n                            <label for=\"interMax\">\r\n                                Máximo\r\n                            </label>\r\n                            ");
            EndContext();
            BeginContext(7659, 145, false);
#line 136 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
                       Write(Html.EditorFor(model => model.InterMax, new { htmlAttributes = new { @type = "time", @class = "form-control col-md-12", @placeholder = "..." } }));

#line default
#line hidden
            EndContext();
            BeginContext(7804, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(7834, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a777f9acbec46c39938b511a974a148", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 137 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.InterMax);

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
            BeginContext(7897, 62, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 140 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
                }

#line default
#line hidden
            BeginContext(7978, 409, true);
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
            BeginWriteAttribute("href", " href=\"", 8387, "\"", 8433, 1);
#line 152 "C:\DevTimeSheet\TimeSheet\Views\JornadaTrabalho\CadastrarHora.cshtml"
WriteAttributeValue("", 8394, Url.Action("Index", "JornadaTrabalho"), 8394, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8434, 83, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TimeSheet.ViewModel.ViewModelCadastroHora> Html { get; private set; }
    }
}
#pragma warning restore 1591