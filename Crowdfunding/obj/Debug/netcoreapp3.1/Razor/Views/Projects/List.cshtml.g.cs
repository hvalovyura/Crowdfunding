#pragma checksum "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e943be828b0ee414e4e17e0eea159bacd391178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_List), @"mvc.1.0.view", @"/Views/Projects/List.cshtml")]
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
#line 1 "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\_ViewImports.cshtml"
using Crowdfunding.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e943be828b0ee414e4e17e0eea159bacd391178", @"/Views/Projects/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"367a15edec66325899cb7c033727ac7108a486d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>All projects:</h1>\r\n<h3>");
#nullable restore
#line 2 "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\List.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 4 "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\List.cshtml"
      
        foreach (var proj in Model.AllProjects)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 210, "\"", 225, 1);
#nullable restore
#line 8 "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\List.cshtml"
WriteAttributeValue("", 216, proj.Img, 216, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\"");
            BeginWriteAttribute("alt", " alt=\"", 239, "\"", 255, 1);
#nullable restore
#line 8 "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\List.cshtml"
WriteAttributeValue("", 245, proj.Name, 245, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <h2>");
#nullable restore
#line 9 "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\List.cshtml"
               Write(proj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>Desc: ");
#nullable restore
#line 10 "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\List.cshtml"
                    Write(proj.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><a class=\"btn btn-warning\" href=\"#\">Description</a></p>\r\n            </div>\r\n");
#nullable restore
#line 13 "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\List.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
