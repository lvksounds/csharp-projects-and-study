#pragma checksum "C:\Users\lucas.freitas\Documents\C#\exercicios\formteste\Views\Home\Data.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6234736fd2dc013989b1ee15125cea96fe9805a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Data), @"mvc.1.0.view", @"/Views/Home/Data.cshtml")]
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
#line 1 "C:\Users\lucas.freitas\Documents\C#\exercicios\formteste\Views\_ViewImports.cshtml"
using formteste;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lucas.freitas\Documents\C#\exercicios\formteste\Views\_ViewImports.cshtml"
using formteste.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6234736fd2dc013989b1ee15125cea96fe9805a", @"/Views/Home/Data.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04b8bd8c1a7bb497ecaad56e2eed022ae6015fc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Data : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card\">\r\n    <p>");
#nullable restore
#line 4 "C:\Users\lucas.freitas\Documents\C#\exercicios\formteste\Views\Home\Data.cshtml"
  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 5 "C:\Users\lucas.freitas\Documents\C#\exercicios\formteste\Views\Home\Data.cshtml"
  Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
