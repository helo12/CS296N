#pragma checksum "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be5ad1122a4727eee1fab9b3a3f26d108808412f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CustomerView), @"mvc.1.0.view", @"/Views/Home/CustomerView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CustomerView.cshtml", typeof(AspNetCore.Views_Home_CustomerView))]
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
#line 1 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\_ViewImports.cshtml"
using CaelumNavis;

#line default
#line hidden
#line 2 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\_ViewImports.cshtml"
using CaelumNavis.Models;

#line default
#line hidden
#line 3 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be5ad1122a4727eee1fab9b3a3f26d108808412f", @"/Views/Home/CustomerView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96d2399d9eb91e506edc1bb1d386abeb1bc47be6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CustomerView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CaelumNavis.Models.Repos.ICustomerRepo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
  
	ViewData["Title"] = "CustomerView";
	Layout = "/views/shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 25, true);
            WriteLiteral("\r\n<h2>CustomerView</h2>\r\n");
            EndContext();
            BeginContext(160, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "282c7d92d52e4017b4598d4eac22f20f", async() => {
                BeginContext(180, 140, true);
                WriteLiteral("\r\n\t<input type=\"text\" name=\"searchString\" placeholder=\"search for\" />\r\n\t<input type=\"submit\" value=\"searchString\" class=\"btn-secondary\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(327, 8, true);
            WriteLiteral("\r\n<p>\r\n\t");
            EndContext();
            BeginContext(335, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a83169e8b74847509bd3fe7012128711", async() => {
                BeginContext(400, 15, true);
                WriteLiteral("Create Customer");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(419, 62, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(482, 24, false);
#line 19 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
           Write(Html.DisplayName("Name"));

#line default
#line hidden
            EndContext();
            BeginContext(506, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(532, 27, false);
#line 22 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
           Write(Html.DisplayName("Address"));

#line default
#line hidden
            EndContext();
            BeginContext(559, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(585, 24, false);
#line 25 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
           Write(Html.DisplayName("City"));

#line default
#line hidden
            EndContext();
            BeginContext(609, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(635, 27, false);
#line 28 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
           Write(Html.DisplayName("ZipCode"));

#line default
#line hidden
            EndContext();
            BeginContext(662, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(688, 25, false);
#line 31 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
           Write(Html.DisplayName("Email"));

#line default
#line hidden
            EndContext();
            BeginContext(713, 27, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(741, 30, false);
#line 35 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
           Write(Html.DisplayName("CanContact"));

#line default
#line hidden
            EndContext();
            BeginContext(771, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(797, 25, false);
#line 38 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
           Write(Html.DisplayName("Terms"));

#line default
#line hidden
            EndContext();
            BeginContext(822, 60, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>Edit</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
            EndContext();
#line 44 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
         foreach (var item in Model.Customers)
		{

#line default
#line hidden
            BeginContext(929, 24, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(954, 43, false);
#line 48 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(997, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1026, 42, false);
#line 51 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1097, 39, false);
#line 54 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
               Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1165, 42, false);
#line 57 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
               Write(Html.DisplayFor(modelItem => item.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(1207, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1236, 40, false);
#line 60 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1305, 45, false);
#line 63 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
               Write(Html.DisplayFor(modelItem => item.CanContact));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1379, 40, false);
#line 66 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
               Write(Html.DisplayFor(modelItem => item.Terms));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 69, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<a>Edit</a> \r\n\t\t\t\t\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 73 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
		}

#line default
#line hidden
            BeginContext(1493, 19, true);
            WriteLiteral("\t</tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CaelumNavis.Models.Repos.ICustomerRepo> Html { get; private set; }
    }
}
#pragma warning restore 1591
