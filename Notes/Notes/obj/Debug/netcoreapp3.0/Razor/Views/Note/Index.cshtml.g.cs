#pragma checksum "C:\repos\Examples\Notes\Notes\Views\Note\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c71eb38b887522919e27aeddce2a4e4cef10cb96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Note_Index), @"mvc.1.0.view", @"/Views/Note/Index.cshtml")]
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
#line 1 "C:\repos\Examples\Notes\Notes\Views\_ViewImports.cshtml"
using Notes.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repos\Examples\Notes\Notes\Views\_ViewImports.cshtml"
using Notes.Views.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c71eb38b887522919e27aeddce2a4e4cef10cb96", @"/Views/Note/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"236b5707b81c6a2e32b6fff0130f367c2587a29a", @"/Views/_ViewImports.cshtml")]
    public class Views_Note_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Note>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\repos\Examples\Notes\Notes\Views\Note\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mw-100"">
    <div class=""row"">
        <div class=""col-4 clr-main"">
            <header class=""border-bottom"">
                <div class=""list-head-padding"">
                    <h4>Notes</h4>
                </div>
            </header>
            <div class=""vh-91"">
");
#nullable restore
#line 16 "C:\repos\Examples\Notes\Notes\Views\Note\Index.cshtml"
                 foreach (var note in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <component");
            BeginWriteAttribute("type", " type=\"", 468, "\"", 497, 1);
#nullable restore
#line 18 "C:\repos\Examples\Notes\Notes\Views\Note\Index.cshtml"
WriteAttributeValue("", 475, typeof(NoteComponent), 475, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></component>\r\n");
#nullable restore
#line 19 "C:\repos\Examples\Notes\Notes\Views\Note\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"col-8\">\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Note>> Html { get; private set; }
    }
}
#pragma warning restore 1591
