#pragma checksum "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\CaelumNavis\CaelumNavis\Views\Home\CreateCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b77a10ff2569e13aeb2a1757917a03dc6651a1e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateCustomer), @"mvc.1.0.view", @"/Views/Home/CreateCustomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CreateCustomer.cshtml", typeof(AspNetCore.Views_Home_CreateCustomer))]
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
#line 1 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\CaelumNavis\CaelumNavis\Views\_ViewImports.cshtml"
using CaelumNavis;

#line default
#line hidden
#line 2 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\CaelumNavis\CaelumNavis\Views\_ViewImports.cshtml"
using CaelumNavis.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b77a10ff2569e13aeb2a1757917a03dc6651a1e1", @"/Views/Home/CreateCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2de792b087f54b6a12608cab3228800291e42d3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\CaelumNavis\CaelumNavis\Views\Home\CreateCustomer.cshtml"
  
	ViewData["Title"] = "CreateCustomer";
	Layout = "/views/shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(92, 29, true);
            WriteLiteral("\r\n<h2>CreateCustomer</h2>\r\n\r\n");
            EndContext();
            BeginContext(121, 1158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7548fdc990fe48f39d48d643e8c9ee7d", async() => {
                BeginContext(169, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(218, 1054, true);
                WriteLiteral(@"	<label Name=""Name"">Your Name:  </label>
	<input Name=""Name"" placeholder=""Your Name goes here"" /><br />
	<!--Email-->
	<label Name=""Email"">Your Email:  </label>
	<input Name=""Email"" placeholder=""Your Email goes here"" /><br />
	<!--Address-->
	<label Name=""Address"">Your Address:  </label>
	<input Name=""Address"" placeholder=""Your Address goes here"" /><br />
	<!--City-->
	<label Name=""City"">Your City:  </label>
	<input Name=""City"" placeholder=""Your City goes here"" /><br />
	<!--BugOrError-->
	<label Name=""ZipCode"">Is this about a bug or error? </label>
	<input Name=""ZipCode"" placeholder=""97402"" /><br />
	<!--CanContact-->
	<label Name=""CanContact"">Can we contact you with special offers? </label>
	<input Name=""CanContact"" type=""checkbox"" value=""true"" checked /><br />
	<!--Terms-->
	<label Name=""Terms"">Do you agree to the terms of service?  </label>
	<input Name=""Terms"" type=""checkbox"" value=""true"" checked /><br />


	<p>
		<input type=""submit"" value=""Submit My Pledge"" />
		<input type=""res");
                WriteLiteral("et\" value=\"Cancel\" />\r\n\t</p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1279, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
