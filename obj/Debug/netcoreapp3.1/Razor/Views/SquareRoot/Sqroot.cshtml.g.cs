#pragma checksum "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a979685705e115fffb550c77c5611bdd4cf5321"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SquareRoot_Sqroot), @"mvc.1.0.view", @"/Views/SquareRoot/Sqroot.cshtml")]
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
#line 1 "C:\Users\USMAN\Task4\Views\_ViewImports.cshtml"
using Task4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USMAN\Task4\Views\_ViewImports.cshtml"
using Task4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a979685705e115fffb550c77c5611bdd4cf5321", @"/Views/SquareRoot/Sqroot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c25832c8e2cc42194312570864dbd9dabd8e962", @"/Views/_ViewImports.cshtml")]
    public class Views_SquareRoot_Sqroot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SquareRoot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sqroot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml"
  
    ViewData["Title"] = "Square Root Checker";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>This page displays the number which has a higher square root.</p>\r\n");
#nullable restore
#line 7 "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml"
  
    if(ViewBag.firstRoot > ViewBag.secondRoot){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <p>The number ");
#nullable restore
#line 10 "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml"
                 Write(ViewBag.firstNum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with square root ");
#nullable restore
#line 10 "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml"
                                                    Write(ViewBag.firstRoot);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has a higher square root than the number ");
#nullable restore
#line 10 "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml"
                                                                                                                Write(ViewBag.secondNum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with square root ");
#nullable restore
#line 10 "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml"
                                                                                                                                                    Write(ViewBag.secondRoot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml"
    }

    else if(ViewBag.firstRoot < ViewBag.secondRoot){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <p>The number ");
#nullable restore
#line 16 "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml"
                 Write(ViewBag.secondNum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with square root ");
#nullable restore
#line 16 "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml"
                                                     Write(ViewBag.secondRoot);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has a higher square root than the number ");
#nullable restore
#line 16 "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml"
                                                                                                                  Write(ViewBag.firstNum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with square root ");
#nullable restore
#line 16 "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml"
                                                                                                                                                     Write(ViewBag.firstRoot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml"
    }
    else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <p> The numbers have the same root </p>\r\n    </div>\r\n");
#nullable restore
#line 23 "C:\Users\USMAN\Task4\Views\SquareRoot\Sqroot.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a979685705e115fffb550c77c5611bdd4cf53217850", async() => {
                WriteLiteral("\r\n        <input type=\'number\' placeholder=\'First Number\' name=\'firstNumber\' />\r\n        <input type=\'number\' placeholder=\'Second Number\' name=\'secondNumber\'/>\r\n        <button type=\'submit\'>Submit</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
