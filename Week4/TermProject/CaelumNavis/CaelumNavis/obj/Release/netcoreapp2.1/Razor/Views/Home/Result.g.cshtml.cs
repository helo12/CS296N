#pragma checksum "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c586f30b70d517cd3f9d440cf7df74aa47f65e8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\_ViewImports.cshtml"
using CaelumNavis;

#line default
#line hidden
#line 2 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\_ViewImports.cshtml"
using CaelumNavis.Models;

#line default
#line hidden
#line 3 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c586f30b70d517cd3f9d440cf7df74aa47f65e8a", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96d2399d9eb91e506edc1bb1d386abeb1bc47be6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete this item?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
  
	ViewData["Title"] = "Result";
	Layout = "/views/shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(96, 68, true);
            WriteLiteral("\n<h2>Result</h2>\n\n<table class=\"table\">\n\t<thead>\n\t\t<tr>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(165, 24, false);
#line 13 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
           Write(Html.DisplayName("Name"));

#line default
#line hidden
            EndContext();
            BeginContext(189, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(212, 27, false);
#line 16 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
           Write(Html.DisplayName("Address"));

#line default
#line hidden
            EndContext();
            BeginContext(239, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(262, 24, false);
#line 19 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
           Write(Html.DisplayName("City"));

#line default
#line hidden
            EndContext();
            BeginContext(286, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(309, 27, false);
#line 22 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
           Write(Html.DisplayName("ZipCode"));

#line default
#line hidden
            EndContext();
            BeginContext(336, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(359, 25, false);
#line 25 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
           Write(Html.DisplayName("Email"));

#line default
#line hidden
            EndContext();
            BeginContext(384, 23, true);
            WriteLiteral("\n\t\t\t</th>\n\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(408, 30, false);
#line 29 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
           Write(Html.DisplayName("CanContact"));

#line default
#line hidden
            EndContext();
            BeginContext(438, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(461, 25, false);
#line 32 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
           Write(Html.DisplayName("Terms"));

#line default
#line hidden
            EndContext();
            BeginContext(486, 63, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>Edit | Delete</th>\n\t\t</tr>\n\t</thead>\n\t<tbody>\n");
            EndContext();
#line 38 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
         foreach (var item in Model.Customers)
		{

#line default
#line hidden
            BeginContext(594, 22, true);
            WriteLiteral("\t\t\t<tr>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(617, 39, false);
#line 42 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(656, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(682, 42, false);
#line 45 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(724, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(750, 39, false);
#line 48 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
               Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(789, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(815, 42, false);
#line 51 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
               Write(Html.DisplayFor(modelItem => item.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(857, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(883, 40, false);
#line 54 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(923, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(949, 45, false);
#line 57 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
               Write(Html.DisplayFor(modelItem => item.CanContact));

#line default
#line hidden
            EndContext();
            BeginContext(994, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(1020, 40, false);
#line 60 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
               Write(Html.DisplayFor(modelItem => item.Terms));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 44, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t<a>Edit</a> |\n\t\t\t\t\t");
            EndContext();
            BeginContext(1104, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5068994230474c26a3c450b1cb712136", async() => {
                BeginContext(1207, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1217, 20, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t</tr>\n");
            EndContext();
#line 67 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week4\TermProject\CaelumNavis\CaelumNavis\Views\Home\Result.cshtml"
		}

#line default
#line hidden
            BeginContext(1241, 17, true);
            WriteLiteral("\t</tbody>\n\t<p>\n\t\t");
            EndContext();
            BeginContext(1258, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80435a4a95a449b58c3d611a717063a2", async() => {
                BeginContext(1321, 24, true);
                WriteLiteral("Go Back to Customer View");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1349, 15, true);
            WriteLiteral("\n\t</p>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
