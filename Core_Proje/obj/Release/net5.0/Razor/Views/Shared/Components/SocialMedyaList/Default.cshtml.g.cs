#pragma checksum "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMedyaList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f0701c8ab2809fa2096630a4a4c99054e34590331ed8b8713e6da2584d9e576f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SocialMedyaList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SocialMedyaList/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMedyaList\Default.cshtml"
using EntityLater.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f0701c8ab2809fa2096630a4a4c99054e34590331ed8b8713e6da2584d9e576f", @"/Views/Shared/Components/SocialMedyaList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SocialMedyaList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedya>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"social-nav\" data-aos=\"fade-up\" data-aos-delay=\"200\">\r\n\t<nav role=\"navigation\">\r\n\t\t<ul class=\"nav justify-content-left\">\r\n");
#nullable restore
#line 7 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMedyaList\Default.cshtml"
    foreach (var item in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<li class=\"nav-item\"><a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 273, "\"", 289, 1);
#nullable restore
#line 9 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMedyaList\Default.cshtml"
WriteAttributeValue("", 280, item.Url, 280, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " \r\n\t\t\t\t\ttitle=\"", 290, "\"", 315, 1);
#nullable restore
#line 10 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMedyaList\Default.cshtml"
WriteAttributeValue("", 305, item.Name, 305, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 319, "\"", 337, 1);
#nullable restore
#line 10 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMedyaList\Default.cshtml"
WriteAttributeValue("", 327, item.Icon, 327, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i><span class=\"menu-title sr-only\">");
#nullable restore
#line 10 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMedyaList\Default.cshtml"
                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></li>\r\n");
#nullable restore
#line 11 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMedyaList\Default.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\t</nav>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedya>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
