#pragma checksum "C:\Users\carve\Desktop\School\Fall Term 2018\CS 295N ASP.NET MVC\Week 8\week8Lab\week6Lab\Views\Info\Leaders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a30752f0f8de80e4518b7e0101ecfaaa99bdf06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Info_Leaders), @"mvc.1.0.view", @"/Views/Info/Leaders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Info/Leaders.cshtml", typeof(AspNetCore.Views_Info_Leaders))]
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
#line 1 "C:\Users\carve\Desktop\School\Fall Term 2018\CS 295N ASP.NET MVC\Week 8\week8Lab\week6Lab\Views\_ViewImports.cshtml"
using week6Lab;

#line default
#line hidden
#line 2 "C:\Users\carve\Desktop\School\Fall Term 2018\CS 295N ASP.NET MVC\Week 8\week8Lab\week6Lab\Views\_ViewImports.cshtml"
using week6Lab.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a30752f0f8de80e4518b7e0101ecfaaa99bdf06", @"/Views/Info/Leaders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a4f29ded570a15ade2898892e8c24b7b261fc1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Info_Leaders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<week6Lab.Models.Leaders.LeaderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\carve\Desktop\School\Fall Term 2018\CS 295N ASP.NET MVC\Week 8\week8Lab\week6Lab\Views\Info\Leaders.cshtml"
  
    ViewData["Title"] = "Leader";
    Layout = "/views/shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(138, 59, true);
            WriteLiteral("\r\n<h2>Leaders</h2>\r\n<p>These are the Leaders of HOAKU</p>\r\n");
            EndContext();
#line 10 "C:\Users\carve\Desktop\School\Fall Term 2018\CS 295N ASP.NET MVC\Week 8\week8Lab\week6Lab\Views\Info\Leaders.cshtml"
 foreach (var leader in Model.LeaderRepo.leaders)
{

#line default
#line hidden
            BeginContext(251, 12, true);
            WriteLiteral("    <br /><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 263, "\"", 282, 1);
#line 12 "C:\Users\carve\Desktop\School\Fall Term 2018\CS 295N ASP.NET MVC\Week 8\week8Lab\week6Lab\Views\Info\Leaders.cshtml"
WriteAttributeValue("", 270, leader.Link, 270, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(283, 41, true);
            WriteLiteral(" style=\"text-align:center;\" target=\"new\">");
            EndContext();
            BeginContext(325, 11, false);
#line 12 "C:\Users\carve\Desktop\School\Fall Term 2018\CS 295N ASP.NET MVC\Week 8\week8Lab\week6Lab\Views\Info\Leaders.cshtml"
                                                                    Write(leader.Name);

#line default
#line hidden
            EndContext();
            BeginContext(336, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 13 "C:\Users\carve\Desktop\School\Fall Term 2018\CS 295N ASP.NET MVC\Week 8\week8Lab\week6Lab\Views\Info\Leaders.cshtml"
}

#line default
#line hidden
            BeginContext(345, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<week6Lab.Models.Leaders.LeaderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591