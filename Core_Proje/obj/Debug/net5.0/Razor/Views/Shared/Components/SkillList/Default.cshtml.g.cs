#pragma checksum "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5ecdec03d5a633d9fedd22538e331a89750e7f4c54103be2ac91dc65fa198e0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SkillList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SkillList/Default.cshtml")]
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
#line 1 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
using EntityLater.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5ecdec03d5a633d9fedd22538e331a89750e7f4c54103be2ac91dc65fa198e0a", @"/Views/Shared/Components/SkillList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SkillList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skills>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""section px-3 px-lg-4 pt-5"" id=""skills"">
	<div class=""container-narrow"">
		<div class=""text-center mb-5"">
			<h2 class=""marker marker-center"">Yeteneklerimiz</h2>
		</div>
		<div class=""text-center"">
			<p class=""mx-auto mb-3"" style=""max-width:600px"">Aşağıda görmüş olduğunuz üzere kendimizi sürekli geliştiridiğimiz programalama dilleri ve araçları var.
            İhtiyaç olduğu durumda yeni bir prgramlama dilinin hızlıva öğreneip kavrayabilirim
			</p>
		</div>
		<div class=""bg-light p-3"">
			<div class=""row"">
				<div class=""col-md-"">
");
#nullable restore
#line 17 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
      foreach (var item in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"py-1\">\r\n\t\t\t\t\t\t\t<div class=\"d-flex text-small fw-bolder\"><span class=\"me-auto\">");
#nullable restore
#line 20 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>");
#nullable restore
#line 20 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                         Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n\t\t\t\t\t\t\t<div class=\"progress my-1\">\r\n\t\t\t\t\t\t\t\t<div class=\"progress-bar bg-primary\" role=\"progressbar\" data-aos=\"zoom-in-right\"\r\n\t\t\t\t\t\t\t\t\t data-aos-delay=\"100\" data-aos-anchor=\".skills-section\"");
            BeginWriteAttribute("style", " style=\"", 997, "\"", 1023, 3);
            WriteAttributeValue("", 1005, "width:", 1005, 6, true);
#nullable restore
#line 23 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue("", 1011, item.Value, 1011, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1022, "%", 1022, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1024, "\"", 1051, 1);
#nullable restore
#line 23 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue("", 1040, item.Value, 1040, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 28 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\r\n\t\t\t</div>\r\n\r\n\t\t</div>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skills>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
