#pragma checksum "C:\Users\ramir\OneDrive\Documentos\proyectos\Sistema\Sistema\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6fd6dfa9a6acd09fff8b7f558a75861f5104a3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\ramir\OneDrive\Documentos\proyectos\Sistema\Sistema\Views\_ViewImports.cshtml"
using Sistema;

#line default
#line hidden
#line 2 "C:\Users\ramir\OneDrive\Documentos\proyectos\Sistema\Sistema\Views\_ViewImports.cshtml"
using Sistema.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6fd6dfa9a6acd09fff8b7f558a75861f5104a3f", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16effa8210c79f1dd6cc37d126f760b7307719b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ramir\OneDrive\Documentos\proyectos\Sistema\Sistema\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contacto";

#line default
#line hidden
            BeginContext(44, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(49, 17, false);
#line 4 "C:\Users\ramir\OneDrive\Documentos\proyectos\Sistema\Sistema\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(66, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(78, 19, false);
#line 5 "C:\Users\ramir\OneDrive\Documentos\proyectos\Sistema\Sistema\Views\Home\Contact.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(97, 287, true);
            WriteLiteral(@"</h3>

<address>
    Colombia - Bogotá<br />
    Redmond, WA 98052-6399<br />
    <abbr title=""Phone"">P:</abbr>
    312 518 7951
</address>

<address>
    <strong>Soporte:</strong> <a href=""vramirezdia@uniminuto.edu.co"">vramirezdia@uniminuto.edu.co</a><br />
   
</address>
");
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
