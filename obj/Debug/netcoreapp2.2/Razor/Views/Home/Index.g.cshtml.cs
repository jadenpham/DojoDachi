#pragma checksum "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\DojoDachi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33b1a1e494a8576be0099d30ca41b794ec72ab8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\DojoDachi\Views\_ViewImports.cshtml"
using DojoDachi;

#line default
#line hidden
#line 2 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\DojoDachi\Views\_ViewImports.cshtml"
using DojoDachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33b1a1e494a8576be0099d30ca41b794ec72ab8f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bce70f5dafba3f05b5d94a87a662fc8c5511826", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 40, true);
            WriteLiteral("<div>\r\n    <div>\r\n        <h3>Fullness: ");
            EndContext();
            BeginContext(41, 16, false);
#line 3 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\DojoDachi\Views\Home\Index.cshtml"
                 Write(ViewBag.Fullness);

#line default
#line hidden
            EndContext();
            BeginContext(57, 30, true);
            WriteLiteral("</h3>\r\n        <h3>Happiness: ");
            EndContext();
            BeginContext(88, 17, false);
#line 4 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\DojoDachi\Views\Home\Index.cshtml"
                  Write(ViewBag.Happiness);

#line default
#line hidden
            EndContext();
            BeginContext(105, 26, true);
            WriteLiteral("</h3>\r\n        <h3>Meals: ");
            EndContext();
            BeginContext(132, 13, false);
#line 5 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\DojoDachi\Views\Home\Index.cshtml"
              Write(ViewBag.Meals);

#line default
#line hidden
            EndContext();
            BeginContext(145, 27, true);
            WriteLiteral("</h3>\r\n        <h3>Energy: ");
            EndContext();
            BeginContext(173, 14, false);
#line 6 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\DojoDachi\Views\Home\Index.cshtml"
               Write(ViewBag.Energy);

#line default
#line hidden
            EndContext();
            BeginContext(187, 42, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div>\r\n        <h1>");
            EndContext();
            BeginContext(230, 19, false);
#line 9 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\DojoDachi\Views\Home\Index.cshtml"
       Write(TempData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(249, 223, true);
            WriteLiteral(" </h1>\r\n    </div>\r\n    <div>\r\n        <a href=\"/feed\">Feed</a>\r\n        <a href=\"/play\">Play</a>\r\n        <a href=\"/work\">Work</a>\r\n        <a href=\"/sleep\">Sleep</a>\r\n        <a href=\"/reset\">Reset</a>\r\n    </div>\r\n</div>");
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
