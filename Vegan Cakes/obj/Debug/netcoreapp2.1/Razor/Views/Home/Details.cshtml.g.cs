#pragma checksum "C:\Users\Bhushan\source\repos\Vegan Cakes\Vegan Cakes\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5384e557750d264177707f81696ca2e58853ff6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\Users\Bhushan\source\repos\Vegan Cakes\Vegan Cakes\Views\Home\Details.cshtml"
using Vegan_Cakes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5384e557750d264177707f81696ca2e58853ff6d", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cake>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Bhushan\source\repos\Vegan Cakes\Vegan Cakes\Views\Home\Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(76, 30, true);
            WriteLiteral("\r\n<h2 class=\"well\">Details of ");
            EndContext();
            BeginContext(107, 10, false);
#line 9 "C:\Users\Bhushan\source\repos\Vegan Cakes\Vegan Cakes\Views\Home\Details.cshtml"
                       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(117, 42, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"thumbnail\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 159, "\"", 180, 1);
#line 12 "C:\Users\Bhushan\source\repos\Vegan Cakes\Vegan Cakes\Views\Home\Details.cshtml"
WriteAttributeValue("", 165, Model.ImageUrl, 165, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(181, 61, true);
            WriteLiteral(">\r\n    <div class=\"caption\">\r\n        <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(243, 25, false);
#line 14 "C:\Users\Bhushan\source\repos\Vegan Cakes\Vegan Cakes\Views\Home\Details.cshtml"
                          Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(268, 32, true);
            WriteLiteral("</h3>\r\n        <h3>\r\n           ");
            EndContext();
            BeginContext(301, 10, false);
#line 16 "C:\Users\Bhushan\source\repos\Vegan Cakes\Vegan Cakes\Views\Home\Details.cshtml"
      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(311, 28, true);
            WriteLiteral("\r\n        </h3>\r\n        <p>");
            EndContext();
            BeginContext(340, 21, false);
#line 18 "C:\Users\Bhushan\source\repos\Vegan Cakes\Vegan Cakes\Views\Home\Details.cshtml"
      Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(361, 26, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cake> Html { get; private set; }
    }
}
#pragma warning restore 1591
