#pragma checksum "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fc8a2646bae79fa08158442542fd4dbf822f6c0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fc8a2646bae79fa08158442542fd4dbf822f6c0", @"/Views/Home/CustomerView.cshtml")]
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
            BeginContext(130, 23, true);
            WriteLiteral("\n<h2>CustomerView</h2>\n");
            EndContext();
            BeginContext(153, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d099c3d309894b0a9b534a4cdde0ede3", async() => {
                BeginContext(173, 137, true);
                WriteLiteral("\n\t<input type=\"text\" name=\"searchString\" placeholder=\"search for\" />\n\t<input type=\"submit\" value=\"searchString\" class=\"btn-secondary\" />\n");
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
            BeginContext(317, 6, true);
            WriteLiteral("\n<p>\n\t");
            EndContext();
            BeginContext(323, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da185840d3214872b888f84f8e8e7685", async() => {
                BeginContext(388, 15, true);
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
            BeginContext(407, 56, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n\t<thead>\n\t\t<tr>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(464, 24, false);
#line 19 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
           Write(Html.DisplayName("Name"));

#line default
#line hidden
            EndContext();
            BeginContext(488, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(511, 27, false);
#line 22 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
           Write(Html.DisplayName("Address"));

#line default
#line hidden
            EndContext();
            BeginContext(538, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(561, 24, false);
#line 25 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
           Write(Html.DisplayName("City"));

#line default
#line hidden
            EndContext();
            BeginContext(585, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(608, 27, false);
#line 28 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
           Write(Html.DisplayName("ZipCode"));

#line default
#line hidden
            EndContext();
            BeginContext(635, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(658, 25, false);
#line 31 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
           Write(Html.DisplayName("Email"));

#line default
#line hidden
            EndContext();
            BeginContext(683, 23, true);
            WriteLiteral("\n\t\t\t</th>\n\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(707, 30, false);
#line 35 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
           Write(Html.DisplayName("CanContact"));

#line default
#line hidden
            EndContext();
            BeginContext(737, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(760, 25, false);
#line 38 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
           Write(Html.DisplayName("Terms"));

#line default
#line hidden
            EndContext();
            BeginContext(785, 54, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>Edit</th>\n\t\t</tr>\n\t</thead>\n\t<tbody>\n");
            EndContext();
#line 44 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
         foreach (var item in Model.Customers)
		{

#line default
#line hidden
            BeginContext(884, 22, true);
            WriteLiteral("\t\t\t<tr>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(907, 39, false);
#line 48 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(946, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(972, 42, false);
#line 51 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(1040, 39, false);
#line 54 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
               Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(1105, 42, false);
#line 57 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
               Write(Html.DisplayFor(modelItem => item.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(1173, 40, false);
#line 60 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(1239, 45, false);
#line 63 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
               Write(Html.DisplayFor(modelItem => item.CanContact));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(1310, 40, false);
#line 66 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
               Write(Html.DisplayFor(modelItem => item.Terms));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 62, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t<a>Edit</a> \n\t\t\t\t\n\t\t\t\t</td>\n\t\t\t</tr>\n");
            EndContext();
#line 73 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\TermProject\TermProject\CaelumNavis\CaelumNavis\Views\Home\CustomerView.cshtml"
		}

#line default
#line hidden
            BeginContext(1416, 18, true);
            WriteLiteral("\t</tbody>\n</table>");
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
