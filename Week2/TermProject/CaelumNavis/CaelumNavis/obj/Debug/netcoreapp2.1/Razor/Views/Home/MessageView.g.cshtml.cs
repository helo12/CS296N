#pragma checksum "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60b9e80a4586439deda73f279e16a774ed845ea5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MessageView), @"mvc.1.0.view", @"/Views/Home/MessageView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MessageView.cshtml", typeof(AspNetCore.Views_Home_MessageView))]
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
#line 1 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\_ViewImports.cshtml"
using CaelumNavis;

#line default
#line hidden
#line 2 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\_ViewImports.cshtml"
using CaelumNavis.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60b9e80a4586439deda73f279e16a774ed845ea5", @"/Views/Home/MessageView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ceffd9400045af48fcaede8fe61b16468dfe3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MessageView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CaelumNavis.Models.Repos.IMessageRepo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FindCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MessageForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete this item?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
  
	ViewData["Title"] = "MessageView";
	Layout = "/views/shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(128, 42, true);
            WriteLiteral("\n<h2>MessageView</h2>\n\n<p>\n\tFind by name: ");
            EndContext();
            BeginContext(171, 28, false);
#line 10 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
             Write(Html.TextBox("SearchString"));

#line default
#line hidden
            EndContext();
            BeginContext(199, 2, true);
            WriteLiteral("\n\t");
            EndContext();
            BeginContext(201, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c13b083cd949460b9efa6f4df5d6b817", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(287, 11, true);
            WriteLiteral("\n</p>\n<p>\n\t");
            EndContext();
            BeginContext(298, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2532cb6232a40b5bcc67286c4f617e1", async() => {
                BeginContext(360, 14, true);
                WriteLiteral("Create Message");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(378, 56, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n\t<thead>\n\t\t<tr>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(435, 24, false);
#line 20 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
           Write(Html.DisplayName("Name"));

#line default
#line hidden
            EndContext();
            BeginContext(459, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(482, 25, false);
#line 23 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
           Write(Html.DisplayName("Email"));

#line default
#line hidden
            EndContext();
            BeginContext(507, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(530, 26, false);
#line 26 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
           Write(Html.DisplayName("Reason"));

#line default
#line hidden
            EndContext();
            BeginContext(556, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(579, 31, false);
#line 29 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
           Write(Html.DisplayName("MessageText"));

#line default
#line hidden
            EndContext();
            BeginContext(610, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(633, 27, false);
#line 32 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
           Write(Html.DisplayName("Address"));

#line default
#line hidden
            EndContext();
            BeginContext(660, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(683, 24, false);
#line 35 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
           Write(Html.DisplayName("City"));

#line default
#line hidden
            EndContext();
            BeginContext(707, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(730, 30, false);
#line 38 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
           Write(Html.DisplayName("bugOrError"));

#line default
#line hidden
            EndContext();
            BeginContext(760, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(783, 30, false);
#line 41 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
           Write(Html.DisplayName("CanContact"));

#line default
#line hidden
            EndContext();
            BeginContext(813, 22, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>\n\t\t\t\t");
            EndContext();
            BeginContext(836, 25, false);
#line 44 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
           Write(Html.DisplayName("Terms"));

#line default
#line hidden
            EndContext();
            BeginContext(861, 63, true);
            WriteLiteral("\n\t\t\t</th>\n\t\t\t<th>Edit | Delete</th>\n\t\t</tr>\n\t</thead>\n\t<tbody>\n");
            EndContext();
#line 50 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
         foreach (var item in Model.Sent)
		{

#line default
#line hidden
            BeginContext(964, 22, true);
            WriteLiteral("\t\t\t<tr>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(987, 44, false);
#line 54 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
               Write(Html.DisplayFor(modelItem => item.cust.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(1057, 45, false);
#line 57 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
               Write(Html.DisplayFor(modelItem => item.cust.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(1128, 41, false);
#line 60 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
               Write(Html.DisplayFor(modelItem => item.Reason));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(1195, 46, false);
#line 63 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
               Write(Html.DisplayFor(modelItem => item.MessageText));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(1267, 47, false);
#line 66 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
               Write(Html.DisplayFor(modelItem => item.cust.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1314, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(1340, 44, false);
#line 69 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
               Write(Html.DisplayFor(modelItem => item.cust.City));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(1410, 45, false);
#line 72 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
               Write(Html.DisplayFor(modelItem => item.bugOrError));

#line default
#line hidden
            EndContext();
            BeginContext(1455, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(1481, 50, false);
#line 75 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
               Write(Html.DisplayFor(modelItem => item.cust.CanContact));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 25, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
            EndContext();
            BeginContext(1557, 45, false);
#line 78 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
               Write(Html.DisplayFor(modelItem => item.cust.Terms));

#line default
#line hidden
            EndContext();
            BeginContext(1602, 44, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t<a>Edit</a> |\n\t\t\t\t\t");
            EndContext();
            BeginContext(1646, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "139857e88ac741fbb8a835ca051fa2b1", async() => {
                BeginContext(1749, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1759, 20, true);
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t</tr>\n");
            EndContext();
#line 85 "C:\Users\carve\Desktop\School\WinterTerm2018\CS296N\CS296N\Week2\TermProject\CaelumNavis\CaelumNavis\Views\Home\MessageView.cshtml"
		}

#line default
#line hidden
            BeginContext(1783, 19, true);
            WriteLiteral("\t</tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CaelumNavis.Models.Repos.IMessageRepo> Html { get; private set; }
    }
}
#pragma warning restore 1591
