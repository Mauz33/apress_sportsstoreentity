#pragma checksum "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5933c9a5caa2996b9ed6fb535da056445e4bc919"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Pages), @"mvc.1.0.view", @"/Views/Shared/Pages.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\_ViewImports.cshtml"
using SportsStoreEntity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\_ViewImports.cshtml"
using SportsStoreEntity.Models.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\_ViewImports.cshtml"
using SportsStoreEntity.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5933c9a5caa2996b9ed6fb535da056445e4bc919", @"/Views/Shared/Pages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcdbcc24ce712b15b10d81fa06ba23424e2dc1fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Pages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("pageform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline d-inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5933c9a5caa2996b9ed6fb535da056445e4bc9194619", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
     if(!Model.HasPreviousPage)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("          <button name=\"options.currentPage\"");
                BeginWriteAttribute("value", " value=\"", 218, "\"", 249, 1);
#nullable restore
#line 6 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
WriteAttributeValue("", 226, Model.CurrentPage -1, 226, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("class", "\r\n            class=\"", 250, "\"", 338, 3);
                WriteAttributeValue("", 271, "btn", 271, 3, true);
                WriteAttributeValue(" ", 274, "btn-outline-primary", 275, 20, true);
#nullable restore
#line 7 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
WriteAttributeValue(" ", 294, !Model.HasPreviousPage ? "disabled" : "", 295, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n            type=\"submit\" disabled>\r\n                Previous\r\n          </button>\r\n");
#nullable restore
#line 11 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button name=\"options.currentPage\"");
                BeginWriteAttribute("value", " value=\"", 491, "\"", 522, 1);
#nullable restore
#line 14 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
WriteAttributeValue("", 499, Model.CurrentPage -1, 499, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("class", "\r\n            class=\"", 523, "\"", 611, 3);
                WriteAttributeValue("", 544, "btn", 544, 3, true);
                WriteAttributeValue(" ", 547, "btn-outline-primary", 548, 20, true);
#nullable restore
#line 15 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
WriteAttributeValue(" ", 567, !Model.HasPreviousPage ? "disabled" : "", 568, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n            type=\"submit\">\r\n                Previous\r\n          </button>\r\n");
#nullable restore
#line 19 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n\r\n");
#nullable restore
#line 22 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
     for (int i = 1; i <= 3 && i <= Model.TotalPages; i++) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button name=\"options.currentPage\"");
                BeginWriteAttribute("value", " value=\"", 806, "\"", 816, 1);
#nullable restore
#line 23 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
WriteAttributeValue("", 814, i, 814, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"submit\"");
                BeginWriteAttribute("class", "\r\n                class=\"", 831, "\"", 921, 3);
                WriteAttributeValue("", 856, "btn", 856, 3, true);
                WriteAttributeValue(" ", 859, "btn-outline-primary", 860, 20, true);
#nullable restore
#line 24 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
WriteAttributeValue(" ", 879, Model.CurrentPage == i ? "active" : "", 880, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            ");
#nullable restore
#line 25 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
       Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </button>\r\n");
#nullable restore
#line 27 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
     if (Model.CurrentPage > 3 && Model.TotalPages - Model.CurrentPage >= 3) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                WriteLiteral("...\r\n        <button class=\"btn btn-outline-primary active\">");
#nullable restore
#line 30 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
                                                  Write(Model.CurrentPage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n");
#nullable restore
#line 31 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
     if (Model.TotalPages > 3) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                WriteLiteral("...\r\n");
#nullable restore
#line 34 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
         for (int i = Math.Max(4, Model.TotalPages - 2);
                                i <= Model.TotalPages; i++) {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <button name=\"options.currentPage\"");
                BeginWriteAttribute("value", " value=\"", 1369, "\"", 1379, 1);
#nullable restore
#line 36 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
WriteAttributeValue("", 1377, i, 1377, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"submit\"");
                BeginWriteAttribute("class", "\r\n                    class=\"", 1394, "\"", 1508, 3);
                WriteAttributeValue("", 1423, "btn", 1423, 3, true);
                WriteAttributeValue(" ", 1426, "btn-outline-primary", 1427, 20, true);
#nullable restore
#line 37 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
WriteAttributeValue("\r\n                   ", 1446, Model.CurrentPage == i ? "active" : "", 1467, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                ");
#nullable restore
#line 39 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </button>\r\n");
#nullable restore
#line 41 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
         
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
     if(!Model.HasNextPage)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button name=\"options.currentPage\"");
                BeginWriteAttribute("value", " value=\"", 1653, "\"", 1684, 1);
#nullable restore
#line 46 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
WriteAttributeValue("", 1661, Model.CurrentPage +1, 1661, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"submit\"");
                BeginWriteAttribute("class", "\r\n            class=\"", 1699, "\"", 1782, 3);
                WriteAttributeValue("", 1720, "btn", 1720, 3, true);
                WriteAttributeValue(" ", 1723, "btn-outline-primary", 1724, 20, true);
#nullable restore
#line 47 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
WriteAttributeValue(" ", 1743, !Model.HasNextPage? "disabled" : "", 1744, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\r\n            Next\r\n        </button>\r\n");
#nullable restore
#line 50 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button name=\"options.currentPage\"");
                BeginWriteAttribute("value", " value=\"", 1898, "\"", 1929, 1);
#nullable restore
#line 53 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
WriteAttributeValue("", 1906, Model.CurrentPage +1, 1906, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"submit\"");
                BeginWriteAttribute("class", "\r\n            class=\"", 1944, "\"", 2027, 3);
                WriteAttributeValue("", 1965, "btn", 1965, 3, true);
                WriteAttributeValue(" ", 1968, "btn-outline-primary", 1969, 20, true);
#nullable restore
#line 54 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
WriteAttributeValue(" ", 1988, !Model.HasNextPage? "disabled" : "", 1989, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            Next\r\n        </button>\r\n");
#nullable restore
#line 57 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    \r\n\r\n    <select name=\"options.pageSize\" class=\"form-control ml-1 mr-1\">\r\n");
#nullable restore
#line 62 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
         foreach (int val in new int[] { 10, 25, 50, 100 }) {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5933c9a5caa2996b9ed6fb535da056445e4bc91916132", async() => {
#nullable restore
#line 63 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
                                                                Write(val);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
               WriteLiteral(val);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 63 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
AddHtmlAttributeValue("", 2260, Model.PageSize == val, 2260, 24, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\Professional\source\repos\SportsStoreEntity\SportsStoreEntity\Views\Shared\Pages.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select>\r\n    <input type=\"hidden\" name=\"options.currentPage\" value=\"1\" />\r\n    <button type=\"submit\" class=\"btn btn-secondary\">Change Page Size</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
