#pragma checksum "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\ThisProject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d1cd7287e1429d6915623f73d914e683f8af5d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_ThisProject), @"mvc.1.0.view", @"/Views/Projects/ThisProject.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d1cd7287e1429d6915623f73d914e683f8af5d5", @"/Views/Projects/ThisProject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"367a15edec66325899cb7c033727ac7108a486d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_ThisProject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row mt-5 mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d1cd7287e1429d6915623f73d914e683f8af5d53422", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\ThisProject.cshtml"
      
        foreach (var proj in Model.AllProjects)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"col-lg-4\">\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 208, "\"", 223, 1);
#nullable restore
#line 7 "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\ThisProject.cshtml"
WriteAttributeValue("", 214, proj.Img, 214, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" height=\"200\"");
                BeginWriteAttribute("alt", " alt=\"", 237, "\"", 253, 1);
#nullable restore
#line 7 "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\ThisProject.cshtml"
WriteAttributeValue("", 243, proj.Name, 243, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <h2>");
#nullable restore
#line 8 "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\ThisProject.cshtml"
               Write(proj.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                <p>Desc: ");
#nullable restore
#line 9 "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\ThisProject.cshtml"
                    Write(proj.LongDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 11 "C:\Users\2die4\Desktop\Crowdfunding\Crowdfunding\Crowdfunding\Views\Projects\ThisProject.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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